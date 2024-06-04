using Kursass.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursass.Forms
{
    public partial class LoginForm : Form
    {
        private GreetingForm greetingForm;
        private string role;
        public LoginForm(GreetingForm greetingForm, string role)
        {
            InitializeComponent();
            this.greetingForm = greetingForm;
            this.role = role;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users(role);
            if (role == "worker")
            {
                if (user.Login(textBox1.Text, textBox2.Text, role))
                {
                    MessageBox.Show("Вхід успішно виконано.");
                    WorkerForm workerForm = new WorkerForm(greetingForm);
                    workerForm.Show();
                    greetingForm.Hide();
                    Close();
                } 
                else MessageBox.Show("Помилка входу! Перевірте введені дані.");
            }
            else if (role == "applicant")
            {
                if (user.Login(textBox1.Text, textBox2.Text, role))
                {
                    MessageBox.Show("Вхід успішно виконано.");
                    ApplicantForm applicantForm = new ApplicantForm(greetingForm, textBox1.Text);
                    applicantForm.Show();
                    greetingForm.Hide();
                    Close();
                }
                else MessageBox.Show("Помилка входу! Перевірте введені дані.");
            }
        }

        private void cancelLogin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
