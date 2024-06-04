using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursass.Models;
using Kursass.Forms;
using Newtonsoft.Json;

namespace Kursass.Controllers
{
    internal class RecommendingApplications
    {
        public static bool Recommend(List<Models.Application> applications, string courseCode, int count, string recommendType)
        {
            var course = new CoursesList().Courses.FirstOrDefault(c => c.Code == courseCode);
            if (course == null)
            {
                MessageBox.Show("Курс не знайдено.");
                return false;
            }

            if (recommendType == "Бюджет")
            {
                if (course.IsBudgeted)
                {
                    MessageBox.Show("Рекомендації на бюджет для цього курсу вже були зроблені.");
                    return false;
                }

                int budgetLimit = course.BudgetLimit;
                int currentBudgetRecommendations = applications.Count(a => a.ApplicationStatus == "Рекомендовано (Бюджет)");

                if (count > (budgetLimit - currentBudgetRecommendations))
                {
                    MessageBox.Show("Введена кількість перевищує доступні місця для бюджету.");
                    return false;
                }

                var eligibleApplications = applications
                    .Where(a => a.ApplicationStatus == "Допущено" && a.Priority != "К")
                    .OrderByDescending(a => a.AverageGrade)
                    .Take(count)
                    .ToList();

                foreach (var app in eligibleApplications)
                {
                    app.ApplicationStatus = "Рекомендовано (Бюджет)";
                    DeactivateLowerPriorityApplications(app, applications);
                    StatusChanger.SaveApplicationToFile(app);
                }
            }
            else if (recommendType == "Контракт")
            {
                if (!course.IsBudgeted)
                {
                    MessageBox.Show("Спочатку потрібно завершити рекомендації на бюджет.");
                    return false;
                }
                if (course.IsContracted)
                {
                    MessageBox.Show("Рекомендації на контракт для цього курсу вже були зроблені.");
                    return false;
                }

                int contractLimit = course.ContractLimit;
                int currentContractRecommendations = applications.Count(a => a.ApplicationStatus == "Рекомендовано (Контракт)");

                if (count > (contractLimit - currentContractRecommendations))
                {
                    MessageBox.Show("Введена кількість перевищує доступні місця для контракту.");
                    return false;
                }

                var eligibleApplications = applications
                    .Where(a => a.ApplicationStatus == "Допущено")
                    .OrderByDescending(a => a.AverageGrade)
                    .Take(count)
                    .ToList();

                foreach (var app in eligibleApplications)
                {
                    app.ApplicationStatus = "Рекомендовано (Контракт)";
                    StatusChanger.SaveApplicationToFile(app);
                }
            }

            return true;
        }

        public static void DeactivateLowerPriorityApplications(Models.Application application, List<Models.Application> applications)
        {
            var applications1 = new ApplicationsList();
            var lowerPriorityApplications = applications1.Applications
                .Where(a => a.ApplicantId == application.ApplicantId && a.Priority != "К" && a.Priority.CompareTo(application.Priority) > 0 && a.ApplicationStatus != "Відмова")
                .ToList();

            foreach (var app in lowerPriorityApplications)
            {
                app.ApplicationStatus = "Деактивовано";
                StatusChanger.SaveApplicationToFile(app);
            }
        }
    }
}
