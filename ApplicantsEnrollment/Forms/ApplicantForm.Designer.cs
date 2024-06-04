namespace Kursass.Forms
{
    partial class ApplicantForm
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
            backButton = new Button();
            mathApplicationButton = new Button();
            piApplicationButton = new Button();
            infoApplicationButton = new Button();
            aiApplicationButton = new Button();
            ciApplicationButton = new Button();
            safeApplicationButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backButton.Location = new Point(12, 418);
            backButton.Name = "backButton";
            backButton.Size = new Size(114, 31);
            backButton.TabIndex = 7;
            backButton.Text = "Вийти";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // mathApplicationButton
            // 
            mathApplicationButton.Anchor = AnchorStyles.None;
            mathApplicationButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mathApplicationButton.Location = new Point(123, 112);
            mathApplicationButton.Name = "mathApplicationButton";
            mathApplicationButton.Size = new Size(186, 80);
            mathApplicationButton.TabIndex = 1;
            mathApplicationButton.Text = "113 Прикладна математика";
            mathApplicationButton.UseVisualStyleBackColor = true;
            mathApplicationButton.Click += mathApplicationButton_Click;
            // 
            // piApplicationButton
            // 
            piApplicationButton.Anchor = AnchorStyles.None;
            piApplicationButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            piApplicationButton.Location = new Point(352, 112);
            piApplicationButton.Name = "piApplicationButton";
            piApplicationButton.Size = new Size(186, 80);
            piApplicationButton.TabIndex = 2;
            piApplicationButton.Text = "121 Програмна інженерія";
            piApplicationButton.UseVisualStyleBackColor = true;
            piApplicationButton.Click += piApplicationButton_Click;
            // 
            // infoApplicationButton
            // 
            infoApplicationButton.Anchor = AnchorStyles.None;
            infoApplicationButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            infoApplicationButton.Location = new Point(579, 112);
            infoApplicationButton.Name = "infoApplicationButton";
            infoApplicationButton.Size = new Size(186, 80);
            infoApplicationButton.TabIndex = 3;
            infoApplicationButton.Text = "122 Інформатика";
            infoApplicationButton.UseVisualStyleBackColor = true;
            infoApplicationButton.Click += infoApplicationButton_Click;
            // 
            // aiApplicationButton
            // 
            aiApplicationButton.Anchor = AnchorStyles.None;
            aiApplicationButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            aiApplicationButton.Location = new Point(123, 258);
            aiApplicationButton.Name = "aiApplicationButton";
            aiApplicationButton.Size = new Size(186, 80);
            aiApplicationButton.TabIndex = 4;
            aiApplicationButton.Text = "122 Штучний інтелект";
            aiApplicationButton.UseVisualStyleBackColor = true;
            aiApplicationButton.Click += aiApplicationButton_Click;
            // 
            // ciApplicationButton
            // 
            ciApplicationButton.Anchor = AnchorStyles.None;
            ciApplicationButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ciApplicationButton.Location = new Point(352, 258);
            ciApplicationButton.Name = "ciApplicationButton";
            ciApplicationButton.Size = new Size(186, 80);
            ciApplicationButton.TabIndex = 5;
            ciApplicationButton.Text = "123 Комп'ютерна інженерія";
            ciApplicationButton.UseVisualStyleBackColor = true;
            ciApplicationButton.Click += ciApplicationButton_Click;
            // 
            // safeApplicationButton
            // 
            safeApplicationButton.Anchor = AnchorStyles.None;
            safeApplicationButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            safeApplicationButton.Location = new Point(579, 258);
            safeApplicationButton.Name = "safeApplicationButton";
            safeApplicationButton.Size = new Size(186, 80);
            safeApplicationButton.TabIndex = 6;
            safeApplicationButton.Text = "125 Управління інформаційною безпекою";
            safeApplicationButton.UseVisualStyleBackColor = true;
            safeApplicationButton.Click += safeApplicationButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(263, 32);
            label1.Name = "label1";
            label1.Size = new Size(354, 24);
            label1.TabIndex = 37;
            label1.Text = "Оберіть, куди ви хочете подати заяву";
            // 
            // ApplicantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(label1);
            Controls.Add(safeApplicationButton);
            Controls.Add(ciApplicationButton);
            Controls.Add(aiApplicationButton);
            Controls.Add(infoApplicationButton);
            Controls.Add(piApplicationButton);
            Controls.Add(mathApplicationButton);
            Controls.Add(backButton);
            MinimumSize = new Size(672, 396);
            Name = "ApplicantForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню абітурієнта";
            FormClosing += ApplicantForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button mathApplicationButton;
        private Button piApplicationButton;
        private Button infoApplicationButton;
        private Button aiApplicationButton;
        private Button ciApplicationButton;
        private Button safeApplicationButton;
        private Label label1;
    }
}