using Kursass.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kursass.Controllers
{
    internal class RecommendationFinisher
    {
        public static void RecommendAllToBudget()
        {
            var coursesList = new CoursesList();
            var applicationsList = new ApplicationsList();
            foreach (var course in coursesList.Courses)
            {
                if (!course.IsClosed)
                {
                    MessageBox.Show("Спочатку потрібно закрити набір для усіх програм.");
                    return;
                }
                if (course.IsBudgeted)
                {
                    MessageBox.Show("Рекомендації на бюджет вже були завершені раніше.");
                    return;
                }
            }

            int counter = 0;
            do
            {
                counter = 0;

                foreach (var course in coursesList.Courses)
                {
                    
                    if (!course.IsBudgeted)
                    {
                        var applications = applicationsList.Applications
                            .Where(a => a.Destination == course.Code && a.ApplicationStatus == "Допущено" && a.Priority != "К")
                            .OrderByDescending(a => a.AverageGrade)
                            .ThenBy(a => a.Priority)
                            .ToList();

                        int budgetLimit = course.BudgetLimit;
                        int currentBudgetRecommendations = applicationsList.Applications.Count(a => a.Destination == course.Code && a.ApplicationStatus == "Рекомендовано (Бюджет)");

                        int recommendCount = Math.Min(applications.Count, budgetLimit - currentBudgetRecommendations);

                        if (recommendCount > 0)
                        {
                            for (int i = 0; i < recommendCount; i++)
                            {
                                applications[i].ApplicationStatus = "Рекомендовано (Бюджет)";
                                var lowerPriorityApplications = applicationsList.Applications
                                    .Where(a => a.ApplicantId == applications[i].ApplicantId && a.Priority != "К" && a.Priority.CompareTo(applications[i].Priority) > 0 && a.ApplicationStatus != "Відмова")
                                    .ToList();

                                foreach (var app in lowerPriorityApplications)
                                {
                                    app.ApplicationStatus = "Деактивовано";
                                    StatusChanger.SaveApplicationToFile(app);
                                }
                                StatusChanger.SaveApplicationToFile(applications[i]);
                            }
                        }
                        else counter++;
                    }
                }
            }
            while (counter < coursesList.Courses.Count);

            foreach (var course in coursesList.Courses)
            {
                if (!course.IsBudgeted) course.IsBudgeted = true;
            }

            CourseCloser.SaveCoursesToFile(coursesList);
            MessageBox.Show("Рекомендації на бюджет для всіх спеціальностей успішно завершено.");
        }

        public static void RecommendAllToContract()
        {
            var coursesList = new CoursesList();
            var applicationsList = new ApplicationsList();
            foreach (var course in coursesList.Courses)
            {
                if (!course.IsClosed)
                {
                    MessageBox.Show("Спочатку потрібно закрити набір для усіх програм.");
                    return;
                }
                if (!course.IsBudgeted)
                {
                    MessageBox.Show("Спочатку потрібно завершити рекомендації на бюджет.");
                    return;
                }
                if (course.IsContracted)
                {
                    MessageBox.Show("Рекомендації на контракт вже були завершені раніше.");
                    return;
                }
            }

            int counter;

            do
            {
                counter = 0;

                foreach (var course in coursesList.Courses)
                {
                    if (!course.IsContracted)
                    {
                        var applications = applicationsList.Applications
                            .Where(a => a.Destination == course.Code && a.ApplicationStatus == "Допущено" && a.ReadyForContract)
                            .OrderByDescending(a => a.AverageGrade)
                            .ThenBy(a => a.Priority)
                            .ToList();

                        int contractLimit = course.ContractLimit;
                        int currentContractRecommendations = applicationsList.Applications.Count(a => a.Destination == course.Code && a.ApplicationStatus == "Рекомендовано (Контракт)");

                        int recommendCount = Math.Min(applications.Count, contractLimit - currentContractRecommendations);

                        if (recommendCount > 0)
                        {
                            for (int i = 0; i < recommendCount; i++)
                            {
                                if (applications[i].CanAffordContract)
                                {
                                    applications[i].ApplicationStatus = "Рекомендовано (Контракт)";
                                    StatusChanger.SaveApplicationToFile(applications[i]);
                                }
                                else
                                {
                                    applications[i].ApplicationStatus = "До співбесіди";
                                    StatusChanger.SaveApplicationToFile(applications[i]);
                                }
                            }
                        }
                        else counter++;
                    }
                }
            }
            while (counter < coursesList.Courses.Count);
            foreach (var course in coursesList.Courses)
            {
                course.IsContracted = true;
            }

            CourseCloser.SaveCoursesToFile(coursesList);
            MessageBox.Show("Рекомендації на контракт для всіх спеціальностей успішно завершено.");
        }

        public static void GenerateOrder()
        {
            var coursesList = new CoursesList();
            var applicationsList = new ApplicationsList();
            foreach (var course in coursesList.Courses)
            {
                if (!course.IsClosed)
                {
                    MessageBox.Show("Спочатку потрібно закрити набір для усіх програм.");
                    return;
                }
                if (!course.IsBudgeted || !course.IsContracted)
                {
                    MessageBox.Show("Спочатку потрібно завершити рекомендації на бюджет і на контракт.");
                    return;
                }
                if (course.IsOrdered)
                {
                    MessageBox.Show("Заяви вже були направлені до наказу раніше.");
                    return;
                }
            }

            foreach (var course in coursesList.Courses)
            {
                var applications = applicationsList.Applications
                    .Where(a => a.Destination == course.Code)
                    .ToList();

                foreach (var app in applications)
                {
                    if (app.ApplicationStatus == "Рекомендовано (Бюджет)")
                    {
                        if (app.IsConfirmed)
                        {
                            app.ApplicationStatus = "До наказу (Бюджет)";
                            StatusChanger.SaveApplicationToFile(app);
                        }
                        else
                        {
                            app.ApplicationStatus = "Відхилено (Бюджет)";
                            StatusChanger.SaveApplicationToFile(app);
                        }
                    }
                    else if (app.ApplicationStatus == "Рекомендовано (Контракт)")
                    {
                        if (app.IsConfirmed)
                        {
                            app.ApplicationStatus = "До наказу (Контракт)";
                            StatusChanger.SaveApplicationToFile(app);
                        }
                        else
                        {
                            app.ApplicationStatus = "Відхилено (Контракт)";
                            StatusChanger.SaveApplicationToFile(app);
                        }
                    }
                }

                course.IsOrdered = true;
            }

            CourseCloser.SaveCoursesToFile(coursesList);
            MessageBox.Show("Заяви для всіх спеціальностей успішно направлені до наказу.");
        }

    }
}
