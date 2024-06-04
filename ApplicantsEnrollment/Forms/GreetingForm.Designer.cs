namespace Kursass.Forms
{
    partial class GreetingForm
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
            applicantButton = new Button();
            workerButton = new Button();
            mainExitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(256, 85);
            label1.Name = "label1";
            label1.Size = new Size(293, 26);
            label1.TabIndex = 0;
            label1.Text = "Вітаємо! Вкажіть, хто ви є";
            // 
            // applicantButton
            // 
            applicantButton.Anchor = AnchorStyles.None;
            applicantButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            applicantButton.Location = new Point(111, 201);
            applicantButton.Name = "applicantButton";
            applicantButton.Size = new Size(202, 100);
            applicantButton.TabIndex = 1;
            applicantButton.Text = "Я абітурієнт";
            applicantButton.UseVisualStyleBackColor = true;
            applicantButton.Click += applicantButton_Click;
            // 
            // workerButton
            // 
            workerButton.Anchor = AnchorStyles.None;
            workerButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            workerButton.Location = new Point(487, 201);
            workerButton.Name = "workerButton";
            workerButton.Size = new Size(202, 100);
            workerButton.TabIndex = 2;
            workerButton.Text = "Я працівник";
            workerButton.UseVisualStyleBackColor = true;
            workerButton.Click += workerButton_Click;
            // 
            // mainExitButton
            // 
            mainExitButton.Anchor = AnchorStyles.Bottom;
            mainExitButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mainExitButton.Location = new Point(347, 407);
            mainExitButton.Name = "mainExitButton";
            mainExitButton.Size = new Size(107, 31);
            mainExitButton.TabIndex = 3;
            mainExitButton.Text = "Вийти";
            mainExitButton.UseVisualStyleBackColor = true;
            mainExitButton.Click += mainExitButton_Click;
            // 
            // GreetingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainExitButton);
            Controls.Add(workerButton);
            Controls.Add(applicantButton);
            Controls.Add(label1);
            MinimumSize = new Size(607, 368);
            Name = "GreetingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головне меню";
            FormClosing += GreetingForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button applicantButton;
        private Button workerButton;
        private Button mainExitButton;
    }
}