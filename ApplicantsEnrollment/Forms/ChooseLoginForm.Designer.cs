namespace Kursass.Forms
{
    partial class ChooseLoginForm
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
            cancelLogin = new Button();
            createNewButton = new Button();
            label1 = new Label();
            loginButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // cancelLogin
            // 
            cancelLogin.Anchor = AnchorStyles.Bottom;
            cancelLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelLogin.Location = new Point(110, 381);
            cancelLogin.Name = "cancelLogin";
            cancelLogin.Size = new Size(127, 32);
            cancelLogin.TabIndex = 3;
            cancelLogin.Text = "Повернутися";
            cancelLogin.UseVisualStyleBackColor = true;
            cancelLogin.Click += cancelLogin_Click;
            // 
            // createNewButton
            // 
            createNewButton.Anchor = AnchorStyles.None;
            createNewButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createNewButton.Location = new Point(86, 75);
            createNewButton.Name = "createNewButton";
            createNewButton.Size = new Size(172, 86);
            createNewButton.TabIndex = 1;
            createNewButton.Text = "Створити новий акаунт";
            createNewButton.UseVisualStyleBackColor = true;
            createNewButton.Click += createNewButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(87, 219);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 7;
            label1.Text = "У мене вже є акаунт:";
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginButton.Location = new Point(86, 255);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(172, 86);
            loginButton.TabIndex = 2;
            loginButton.Text = "Увійти в існуючий акаунт";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(77, 9);
            label2.Name = "label2";
            label2.Size = new Size(188, 22);
            label2.TabIndex = 9;
            label2.Text = "Оберіть спосіб входу";
            // 
            // ChooseLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 425);
            Controls.Add(label2);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(createNewButton);
            Controls.Add(cancelLogin);
            MinimumSize = new Size(327, 395);
            Name = "ChooseLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оберіть спосіб входу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelLogin;
        private Button createNewButton;
        private Label label1;
        private Button loginButton;
        private Label label2;
    }
}