namespace Kursass.Forms
{
    partial class WorkerForm
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
            workerExitButton = new Button();
            piApplications = new Button();
            mathApplications = new Button();
            infoApplications = new Button();
            aiApplication = new Button();
            engineeringApplication = new Button();
            safetyApplication = new Button();
            interviewListButton = new Button();
            makeBudgetedButton = new Button();
            makeContractedButton = new Button();
            generateOrderButton = new Button();
            SuspendLayout();
            // 
            // workerExitButton
            // 
            workerExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            workerExitButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            workerExitButton.Location = new Point(12, 391);
            workerExitButton.Name = "workerExitButton";
            workerExitButton.Size = new Size(114, 58);
            workerExitButton.TabIndex = 7;
            workerExitButton.Text = "Головне меню";
            workerExitButton.UseVisualStyleBackColor = true;
            workerExitButton.Click += workerExitButton_Click;
            // 
            // piApplications
            // 
            piApplications.Anchor = AnchorStyles.None;
            piApplications.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            piApplications.Location = new Point(351, 81);
            piApplications.Name = "piApplications";
            piApplications.Size = new Size(186, 80);
            piApplications.TabIndex = 2;
            piApplications.Text = "121 Програмна інженерія";
            piApplications.UseVisualStyleBackColor = true;
            piApplications.Click += piApplications_Click;
            // 
            // mathApplications
            // 
            mathApplications.Anchor = AnchorStyles.None;
            mathApplications.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mathApplications.Location = new Point(128, 81);
            mathApplications.Name = "mathApplications";
            mathApplications.Size = new Size(186, 80);
            mathApplications.TabIndex = 1;
            mathApplications.Text = "113 Прикладна математика";
            mathApplications.UseVisualStyleBackColor = true;
            mathApplications.Click += mathApplications_Click;
            // 
            // infoApplications
            // 
            infoApplications.Anchor = AnchorStyles.None;
            infoApplications.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            infoApplications.Location = new Point(577, 81);
            infoApplications.Name = "infoApplications";
            infoApplications.Size = new Size(186, 80);
            infoApplications.TabIndex = 3;
            infoApplications.Text = "122 Інформатика";
            infoApplications.UseVisualStyleBackColor = true;
            infoApplications.Click += infoApplications_Click;
            // 
            // aiApplication
            // 
            aiApplication.Anchor = AnchorStyles.None;
            aiApplication.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            aiApplication.Location = new Point(128, 223);
            aiApplication.Name = "aiApplication";
            aiApplication.Size = new Size(186, 80);
            aiApplication.TabIndex = 4;
            aiApplication.Text = "122 Штучний інтелект";
            aiApplication.UseVisualStyleBackColor = true;
            aiApplication.Click += aiApplication_Click;
            // 
            // engineeringApplication
            // 
            engineeringApplication.Anchor = AnchorStyles.None;
            engineeringApplication.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            engineeringApplication.Location = new Point(351, 223);
            engineeringApplication.Name = "engineeringApplication";
            engineeringApplication.Size = new Size(186, 80);
            engineeringApplication.TabIndex = 5;
            engineeringApplication.Text = "123 Комп'ютерна інженерія";
            engineeringApplication.UseVisualStyleBackColor = true;
            engineeringApplication.Click += engineeringApplication_Click;
            // 
            // safetyApplication
            // 
            safetyApplication.Anchor = AnchorStyles.None;
            safetyApplication.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            safetyApplication.Location = new Point(577, 223);
            safetyApplication.Name = "safetyApplication";
            safetyApplication.Size = new Size(186, 80);
            safetyApplication.TabIndex = 6;
            safetyApplication.Text = "125 Управління інформаційною безпекою";
            safetyApplication.UseVisualStyleBackColor = true;
            safetyApplication.Click += safetyApplication_Click;
            // 
            // interviewListButton
            // 
            interviewListButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            interviewListButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            interviewListButton.Location = new Point(758, 391);
            interviewListButton.Name = "interviewListButton";
            interviewListButton.Size = new Size(114, 58);
            interviewListButton.TabIndex = 11;
            interviewListButton.Text = "Списки для співбесід";
            interviewListButton.UseVisualStyleBackColor = true;
            interviewListButton.Click += interviewListButton_Click;
            // 
            // makeBudgetedButton
            // 
            makeBudgetedButton.Anchor = AnchorStyles.Bottom;
            makeBudgetedButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            makeBudgetedButton.Location = new Point(200, 391);
            makeBudgetedButton.Name = "makeBudgetedButton";
            makeBudgetedButton.Size = new Size(114, 58);
            makeBudgetedButton.TabIndex = 8;
            makeBudgetedButton.Text = "Завершити рекомендування (Бюджет)";
            makeBudgetedButton.UseVisualStyleBackColor = true;
            makeBudgetedButton.Click += makeBudgetedButton_Click;
            // 
            // makeContractedButton
            // 
            makeContractedButton.Anchor = AnchorStyles.Bottom;
            makeContractedButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            makeContractedButton.Location = new Point(391, 391);
            makeContractedButton.Name = "makeContractedButton";
            makeContractedButton.Size = new Size(114, 58);
            makeContractedButton.TabIndex = 9;
            makeContractedButton.Text = "Завершити рекомендування (Контракт)";
            makeContractedButton.UseVisualStyleBackColor = true;
            makeContractedButton.Click += makeContractedButton_Click;
            // 
            // generateOrderButton
            // 
            generateOrderButton.Anchor = AnchorStyles.Bottom;
            generateOrderButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            generateOrderButton.Location = new Point(577, 391);
            generateOrderButton.Name = "generateOrderButton";
            generateOrderButton.Size = new Size(114, 58);
            generateOrderButton.TabIndex = 10;
            generateOrderButton.Text = "Направити до наказу";
            generateOrderButton.UseVisualStyleBackColor = true;
            generateOrderButton.Click += generateOrderButton_Click;
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(generateOrderButton);
            Controls.Add(makeContractedButton);
            Controls.Add(makeBudgetedButton);
            Controls.Add(interviewListButton);
            Controls.Add(safetyApplication);
            Controls.Add(engineeringApplication);
            Controls.Add(aiApplication);
            Controls.Add(infoApplications);
            Controls.Add(mathApplications);
            Controls.Add(piApplications);
            Controls.Add(workerExitButton);
            MinimumSize = new Size(772, 353);
            Name = "WorkerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню робітника";
            FormClosing += WorkerForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private Button workerExitButton;
        private Button piApplications;
        private Button mathApplications;
        private Button infoApplications;
        private Button aiApplication;
        private Button engineeringApplication;
        private Button safetyApplication;
        private Button interviewListButton;
        private Button makeBudgetedButton;
        private Button makeContractedButton;
        private Button generateOrderButton;
    }
}