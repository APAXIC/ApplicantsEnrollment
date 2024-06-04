namespace Kursass.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            loginButton = new Button();
            textBox2 = new TextBox();
            cancelLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(7, 3);
            label1.Name = "label1";
            label1.Size = new Size(207, 21);
            label1.TabIndex = 0;
            label1.Text = "Введіть ім'я користувача";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(7, 90);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 1;
            label2.Text = "Введіть ваш пароль";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 2;
            textBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 211);
            panel1.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginButton.Location = new Point(104, 164);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(87, 32);
            loginButton.TabIndex = 1;
            loginButton.Text = "Увійти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 4;
            textBox2.TabStop = false;
            // 
            // cancelLogin
            // 
            cancelLogin.Anchor = AnchorStyles.Bottom;
            cancelLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelLogin.Location = new Point(108, 381);
            cancelLogin.Name = "cancelLogin";
            cancelLogin.Size = new Size(127, 32);
            cancelLogin.TabIndex = 2;
            cancelLogin.Text = "Повернутися";
            cancelLogin.UseVisualStyleBackColor = true;
            cancelLogin.Click += cancelLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 425);
            Controls.Add(cancelLogin);
            Controls.Add(panel1);
            MinimumSize = new Size(327, 313);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вхід до акаунту";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Panel panel1;
        private Button loginButton;
        private TextBox textBox2;
        private Button cancelLogin;
    }
}