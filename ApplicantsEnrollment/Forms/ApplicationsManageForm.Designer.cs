namespace Kursass.Forms
{
    partial class ApplicationsManageForm
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
            backButton = new Button();
            applicationBindingSource = new BindingSource(components);
            panel1 = new Panel();
            bioCoefBox = new TextBox();
            chemCoefBox = new TextBox();
            physCoefBox = new TextBox();
            engCoefBox = new TextBox();
            histCoefBox = new TextBox();
            mathCoefBox = new TextBox();
            ukrCoefBox = new TextBox();
            contractLimitBox = new TextBox();
            budgetLimitBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            closeSelectionButton = new Button();
            panel2 = new Panel();
            searchTextBox = new TextBox();
            label12 = new Label();
            recommendMultipleButton = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)applicationBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backButton.Location = new Point(12, 846);
            backButton.Name = "backButton";
            backButton.Size = new Size(114, 38);
            backButton.TabIndex = 1;
            backButton.Text = "Повернутися";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // applicationBindingSource
            // 
            applicationBindingSource.DataSource = typeof(Models.Application);
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(bioCoefBox);
            panel1.Controls.Add(chemCoefBox);
            panel1.Controls.Add(physCoefBox);
            panel1.Controls.Add(engCoefBox);
            panel1.Controls.Add(histCoefBox);
            panel1.Controls.Add(mathCoefBox);
            panel1.Controls.Add(ukrCoefBox);
            panel1.Controls.Add(contractLimitBox);
            panel1.Controls.Add(budgetLimitBox);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(145, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 230);
            panel1.TabIndex = 2;
            // 
            // bioCoefBox
            // 
            bioCoefBox.Enabled = false;
            bioCoefBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bioCoefBox.Location = new Point(550, 191);
            bioCoefBox.Name = "bioCoefBox";
            bioCoefBox.Size = new Size(35, 26);
            bioCoefBox.TabIndex = 19;
            bioCoefBox.TabStop = false;
            // 
            // chemCoefBox
            // 
            chemCoefBox.Enabled = false;
            chemCoefBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chemCoefBox.Location = new Point(550, 161);
            chemCoefBox.Name = "chemCoefBox";
            chemCoefBox.Size = new Size(35, 26);
            chemCoefBox.TabIndex = 18;
            chemCoefBox.TabStop = false;
            // 
            // physCoefBox
            // 
            physCoefBox.Enabled = false;
            physCoefBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            physCoefBox.Location = new Point(550, 131);
            physCoefBox.Name = "physCoefBox";
            physCoefBox.Size = new Size(35, 26);
            physCoefBox.TabIndex = 17;
            physCoefBox.TabStop = false;
            // 
            // engCoefBox
            // 
            engCoefBox.Enabled = false;
            engCoefBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            engCoefBox.Location = new Point(550, 74);
            engCoefBox.Name = "engCoefBox";
            engCoefBox.Size = new Size(35, 26);
            engCoefBox.TabIndex = 16;
            engCoefBox.TabStop = false;
            // 
            // histCoefBox
            // 
            histCoefBox.Enabled = false;
            histCoefBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            histCoefBox.Location = new Point(550, 103);
            histCoefBox.Name = "histCoefBox";
            histCoefBox.Size = new Size(35, 26);
            histCoefBox.TabIndex = 15;
            histCoefBox.TabStop = false;
            // 
            // mathCoefBox
            // 
            mathCoefBox.Enabled = false;
            mathCoefBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mathCoefBox.Location = new Point(392, 161);
            mathCoefBox.Name = "mathCoefBox";
            mathCoefBox.Size = new Size(35, 26);
            mathCoefBox.TabIndex = 14;
            mathCoefBox.TabStop = false;
            // 
            // ukrCoefBox
            // 
            ukrCoefBox.Enabled = false;
            ukrCoefBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ukrCoefBox.Location = new Point(392, 103);
            ukrCoefBox.Name = "ukrCoefBox";
            ukrCoefBox.Size = new Size(35, 26);
            ukrCoefBox.TabIndex = 13;
            ukrCoefBox.TabStop = false;
            // 
            // contractLimitBox
            // 
            contractLimitBox.Enabled = false;
            contractLimitBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contractLimitBox.Location = new Point(213, 93);
            contractLimitBox.Name = "contractLimitBox";
            contractLimitBox.Size = new Size(35, 26);
            contractLimitBox.TabIndex = 12;
            contractLimitBox.TabStop = false;
            // 
            // budgetLimitBox
            // 
            budgetLimitBox.Enabled = false;
            budgetLimitBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            budgetLimitBox.Location = new Point(213, 46);
            budgetLimitBox.Name = "budgetLimitBox";
            budgetLimitBox.Size = new Size(35, 26);
            budgetLimitBox.TabIndex = 11;
            budgetLimitBox.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(268, 165);
            label11.Name = "label11";
            label11.Size = new Size(91, 19);
            label11.TabIndex = 10;
            label11.Text = "Математика";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(268, 106);
            label10.Name = "label10";
            label10.Size = new Size(118, 19);
            label10.TabIndex = 9;
            label10.Text = "Українська мова";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(433, 195);
            label9.Name = "label9";
            label9.Size = new Size(61, 19);
            label9.TabIndex = 8;
            label9.Text = "Біологія";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(433, 165);
            label8.Name = "label8";
            label8.Size = new Size(43, 19);
            label8.TabIndex = 7;
            label8.Text = "Хімія";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(433, 135);
            label7.Name = "label7";
            label7.Size = new Size(54, 19);
            label7.TabIndex = 6;
            label7.Text = "Фізика";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(433, 107);
            label6.Name = "label6";
            label6.Size = new Size(111, 19);
            label6.TabIndex = 5;
            label6.Text = "Історія України";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(433, 78);
            label5.Name = "label5";
            label5.Size = new Size(107, 19);
            label5.TabIndex = 4;
            label5.Text = "Іноземна мова";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(377, 46);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 3;
            label4.Text = "Коефіцієнти";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(14, 93);
            label3.Name = "label3";
            label3.Size = new Size(195, 19);
            label3.TabIndex = 2;
            label3.Text = "Кількість місць на контракт:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(14, 46);
            label2.Name = "label2";
            label2.Size = new Size(193, 19);
            label2.TabIndex = 1;
            label2.Text = "Кількість бюджетних місць:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(201, 12);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // closeSelectionButton
            // 
            closeSelectionButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            closeSelectionButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeSelectionButton.Location = new Point(758, 846);
            closeSelectionButton.Name = "closeSelectionButton";
            closeSelectionButton.Size = new Size(114, 38);
            closeSelectionButton.TabIndex = 3;
            closeSelectionButton.Text = "Закрити набір";
            closeSelectionButton.UseVisualStyleBackColor = true;
            closeSelectionButton.Click += closeSelectionButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(searchTextBox);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(145, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 40);
            panel2.TabIndex = 5;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchTextBox.Location = new Point(168, 7);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(417, 26);
            searchTextBox.TabIndex = 4;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(14, 10);
            label12.Name = "label12";
            label12.Size = new Size(148, 19);
            label12.TabIndex = 0;
            label12.Text = "Пошук за прізвищем:";
            // 
            // recommendMultipleButton
            // 
            recommendMultipleButton.Anchor = AnchorStyles.Bottom;
            recommendMultipleButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recommendMultipleButton.Location = new Point(381, 846);
            recommendMultipleButton.Name = "recommendMultipleButton";
            recommendMultipleButton.Size = new Size(141, 38);
            recommendMultipleButton.TabIndex = 2;
            recommendMultipleButton.Text = "Рекомендувати визначену кількість";
            recommendMultipleButton.UseVisualStyleBackColor = true;
            recommendMultipleButton.Click += recommendMultipleButton_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.Location = new Point(145, 317);
            label13.Name = "label13";
            label13.Size = new Size(24, 19);
            label13.TabIndex = 2;
            label13.Text = "№";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label14.Location = new Point(184, 317);
            label14.Name = "label14";
            label14.Size = new Size(72, 19);
            label14.TabIndex = 7;
            label14.Text = "Прізвище";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label15.Location = new Point(293, 317);
            label15.Name = "label15";
            label15.Size = new Size(96, 19);
            label15.TabIndex = 8;
            label15.Text = "Статус заяви";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label16.Location = new Point(492, 317);
            label16.Name = "label16";
            label16.Size = new Size(77, 19);
            label16.TabIndex = 9;
            label16.Text = "Пріоритет";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label17.Location = new Point(604, 317);
            label17.Name = "label17";
            label17.Size = new Size(29, 19);
            label17.TabIndex = 10;
            label17.Text = "КБ";
            toolTip1.SetToolTip(label17, "Конкурсний бал вступника");
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label18.Location = new Point(688, 317);
            label18.Name = "label18";
            label18.Size = new Size(44, 19);
            label18.TabIndex = 11;
            label18.Text = "ПВМ";
            toolTip1.SetToolTip(label18, "Підтверджено вибір місця здобуття освіти");
            // 
            // ApplicationsManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 896);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(recommendMultipleButton);
            Controls.Add(panel2);
            Controls.Add(closeSelectionButton);
            Controls.Add(panel1);
            Controls.Add(backButton);
            MinimumSize = new Size(900, 935);
            Name = "ApplicationsManageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Розгляд заяв";
            ((System.ComponentModel.ISupportInitialize)applicationBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private BindingSource applicationBindingSource;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox bioCoefBox;
        private TextBox chemCoefBox;
        private TextBox physCoefBox;
        private TextBox engCoefBox;
        private TextBox histCoefBox;
        private TextBox mathCoefBox;
        private TextBox ukrCoefBox;
        private TextBox contractLimitBox;
        private TextBox budgetLimitBox;
        private Label label11;
        private Label label10;
        private Button closeSelectionButton;
        private Panel panel2;
        private TextBox searchTextBox;
        private Label label12;
        private Button recommendMultipleButton;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private ToolTip toolTip1;
    }
}