namespace Kursass.Forms
{
    partial class RecommendMultipleForm
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
            numberTextBox = new TextBox();
            label2 = new Label();
            recommendTypeComboBox = new ComboBox();
            cancelButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(387, 21);
            label1.TabIndex = 0;
            label1.Text = "Вкажіть кількість абітурієнтів для рекомендації";
            // 
            // numberTextBox
            // 
            numberTextBox.Anchor = AnchorStyles.None;
            numberTextBox.Location = new Point(405, 19);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(100, 23);
            numberTextBox.TabIndex = 1;
            numberTextBox.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(215, 21);
            label2.TabIndex = 2;
            label2.Text = "Оберіть тип рекомендації";
            // 
            // recommendTypeComboBox
            // 
            recommendTypeComboBox.Anchor = AnchorStyles.None;
            recommendTypeComboBox.FormattingEnabled = true;
            recommendTypeComboBox.Location = new Point(233, 75);
            recommendTypeComboBox.Name = "recommendTypeComboBox";
            recommendTypeComboBox.Size = new Size(169, 23);
            recommendTypeComboBox.TabIndex = 3;
            recommendTypeComboBox.TabStop = false;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cancelButton.Location = new Point(12, 147);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(103, 34);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(420, 147);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(103, 34);
            saveButton.TabIndex = 1;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // RecommendMultipleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 193);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(recommendTypeComboBox);
            Controls.Add(label2);
            Controls.Add(numberTextBox);
            Controls.Add(label1);
            MinimumSize = new Size(551, 232);
            Name = "RecommendMultipleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecommendMultipleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numberTextBox;
        private Label label2;
        private ComboBox recommendTypeComboBox;
        private Button cancelButton;
        private Button saveButton;
    }
}