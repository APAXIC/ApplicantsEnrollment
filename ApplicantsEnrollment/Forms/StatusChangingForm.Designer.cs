namespace Kursass.Forms
{
    partial class StatusChangingForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cancelButton = new Button();
            saveButton = new Button();
            statusComboBox = new ComboBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            label3 = new Label();
            contractBox1 = new TextBox();
            contractBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            priorityBox = new TextBox();
            averageGradeBox = new TextBox();
            label6 = new Label();
            ukrBox = new TextBox();
            label7 = new Label();
            mathBox = new TextBox();
            label8 = new Label();
            thirdGradeBox = new TextBox();
            thirdGradeLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 0;
            label1.Text = "ПІБ заявника(ці)";
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cancelButton.Location = new Point(12, 400);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(109, 38);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(679, 400);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(109, 38);
            saveButton.TabIndex = 1;
            saveButton.Text = "Зберегти зміни";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // statusComboBox
            // 
            statusComboBox.Anchor = AnchorStyles.None;
            statusComboBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(445, 334);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(231, 29);
            statusComboBox.TabIndex = 0;
            statusComboBox.TabStop = false;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.None;
            nameTextBox.Enabled = false;
            nameTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameTextBox.Location = new Point(28, 57);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(379, 29);
            nameTextBox.TabIndex = 0;
            nameTextBox.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(445, 304);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 5;
            label2.Text = "Статус заяви";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(28, 99);
            label3.Name = "label3";
            label3.Size = new Size(482, 21);
            label3.TabIndex = 6;
            label3.Text = "Заявник(-ця) згоден(-на) на навчання на договірній основі ";
            // 
            // contractBox1
            // 
            contractBox1.Anchor = AnchorStyles.None;
            contractBox1.Enabled = false;
            contractBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contractBox1.Location = new Point(516, 97);
            contractBox1.Name = "contractBox1";
            contractBox1.Size = new Size(38, 29);
            contractBox1.TabIndex = 0;
            contractBox1.TabStop = false;
            // 
            // contractBox2
            // 
            contractBox2.Anchor = AnchorStyles.None;
            contractBox2.Enabled = false;
            contractBox2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contractBox2.Location = new Point(574, 138);
            contractBox2.Name = "contractBox2";
            contractBox2.Size = new Size(38, 29);
            contractBox2.TabIndex = 0;
            contractBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(28, 140);
            label4.Name = "label4";
            label4.Size = new Size(540, 21);
            label4.TabIndex = 8;
            label4.Text = "Заявник(-ця) може дозволити собі навчання на договірній основі ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(28, 177);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 10;
            label5.Text = "Пріоритет заяви";
            // 
            // priorityBox
            // 
            priorityBox.Anchor = AnchorStyles.None;
            priorityBox.Enabled = false;
            priorityBox.Font = new Font("Times New Roman", 14.25F);
            priorityBox.Location = new Point(174, 175);
            priorityBox.Name = "priorityBox";
            priorityBox.Size = new Size(71, 29);
            priorityBox.TabIndex = 0;
            priorityBox.TabStop = false;
            // 
            // averageGradeBox
            // 
            averageGradeBox.Anchor = AnchorStyles.None;
            averageGradeBox.Enabled = false;
            averageGradeBox.Font = new Font("Times New Roman", 14.25F);
            averageGradeBox.Location = new Point(175, 214);
            averageGradeBox.Name = "averageGradeBox";
            averageGradeBox.Size = new Size(70, 29);
            averageGradeBox.TabIndex = 0;
            averageGradeBox.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(29, 216);
            label6.Name = "label6";
            label6.Size = new Size(141, 21);
            label6.TabIndex = 12;
            label6.Text = "Конкурсний бал";
            // 
            // ukrBox
            // 
            ukrBox.Anchor = AnchorStyles.None;
            ukrBox.Enabled = false;
            ukrBox.Font = new Font("Times New Roman", 14.25F);
            ukrBox.Location = new Point(175, 253);
            ukrBox.Name = "ukrBox";
            ukrBox.Size = new Size(70, 29);
            ukrBox.TabIndex = 0;
            ukrBox.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(29, 255);
            label7.Name = "label7";
            label7.Size = new Size(143, 21);
            label7.TabIndex = 14;
            label7.Text = "Українська мова";
            // 
            // mathBox
            // 
            mathBox.Anchor = AnchorStyles.None;
            mathBox.Enabled = false;
            mathBox.Font = new Font("Times New Roman", 14.25F);
            mathBox.Location = new Point(175, 292);
            mathBox.Name = "mathBox";
            mathBox.Size = new Size(70, 29);
            mathBox.TabIndex = 0;
            mathBox.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(29, 294);
            label8.Name = "label8";
            label8.Size = new Size(105, 21);
            label8.TabIndex = 16;
            label8.Text = "Математика";
            // 
            // thirdGradeBox
            // 
            thirdGradeBox.Anchor = AnchorStyles.None;
            thirdGradeBox.Enabled = false;
            thirdGradeBox.Font = new Font("Times New Roman", 14.25F);
            thirdGradeBox.Location = new Point(175, 334);
            thirdGradeBox.Name = "thirdGradeBox";
            thirdGradeBox.Size = new Size(70, 29);
            thirdGradeBox.TabIndex = 4;
            thirdGradeBox.TabStop = false;
            // 
            // thirdGradeLabel
            // 
            thirdGradeLabel.Anchor = AnchorStyles.None;
            thirdGradeLabel.AutoSize = true;
            thirdGradeLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            thirdGradeLabel.Location = new Point(29, 336);
            thirdGradeLabel.Name = "thirdGradeLabel";
            thirdGradeLabel.Size = new Size(75, 21);
            thirdGradeLabel.TabIndex = 17;
            thirdGradeLabel.Text = "Біологія";
            // 
            // StatusChangingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thirdGradeLabel);
            Controls.Add(thirdGradeBox);
            Controls.Add(mathBox);
            Controls.Add(label8);
            Controls.Add(ukrBox);
            Controls.Add(label7);
            Controls.Add(averageGradeBox);
            Controls.Add(label6);
            Controls.Add(priorityBox);
            Controls.Add(label5);
            Controls.Add(contractBox2);
            Controls.Add(label4);
            Controls.Add(contractBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(statusComboBox);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(label1);
            MinimumSize = new Size(816, 489);
            Name = "StatusChangingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplicationStatusChangingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button cancelButton;
        private Button saveButton;
        private ComboBox statusComboBox;
        private TextBox nameTextBox;
        private Label label2;
        private NotifyIcon notifyIcon1;
        private Label label3;
        private TextBox contractBox1;
        private TextBox contractBox2;
        private Label label4;
        private Label label5;
        private TextBox priorityBox;
        private TextBox averageGradeBox;
        private Label label6;
        private TextBox ukrBox;
        private Label label7;
        private TextBox mathBox;
        private Label label8;
        private TextBox thirdGradeBox;
        private Label thirdGradeLabel;
    }
}