namespace compound
{
    partial class Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputAmount = new System.Windows.Forms.NumericUpDown();
            this.inputTerm = new System.Windows.Forms.NumericUpDown();
            this.selectTypeTerm = new System.Windows.Forms.ComboBox();
            this.inputPercent = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReturnToMenu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.addTypeSelector = new System.Windows.Forms.ComboBox();
            this.addEveryTerm = new System.Windows.Forms.NumericUpDown();
            this.exportData = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPercent)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEveryTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите данные";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(11, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Параметры";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputAmount
            // 
            this.inputAmount.Location = new System.Drawing.Point(130, 72);
            this.inputAmount.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.inputAmount.Name = "inputAmount";
            this.inputAmount.Size = new System.Drawing.Size(158, 20);
            this.inputAmount.TabIndex = 15;
            this.inputAmount.ThousandsSeparator = true;
            // 
            // inputTerm
            // 
            this.inputTerm.Location = new System.Drawing.Point(130, 98);
            this.inputTerm.Name = "inputTerm";
            this.inputTerm.Size = new System.Drawing.Size(101, 20);
            this.inputTerm.TabIndex = 16;
            // 
            // selectTypeTerm
            // 
            this.selectTypeTerm.FormattingEnabled = true;
            this.selectTypeTerm.Items.AddRange(new object[] {
            "лет",
            "мес."});
            this.selectTypeTerm.Location = new System.Drawing.Point(237, 98);
            this.selectTypeTerm.Name = "selectTypeTerm";
            this.selectTypeTerm.Size = new System.Drawing.Size(51, 21);
            this.selectTypeTerm.TabIndex = 17;
            this.selectTypeTerm.SelectedIndexChanged += new System.EventHandler(this.selectTypeTerm_SelectedIndexChanged);
            // 
            // inputPercent
            // 
            this.inputPercent.Location = new System.Drawing.Point(130, 125);
            this.inputPercent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputPercent.Name = "inputPercent";
            this.inputPercent.Size = new System.Drawing.Size(158, 20);
            this.inputPercent.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ReturnToMenu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CloseApplication);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 29);
            this.panel1.TabIndex = 20;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // ReturnToMenu
            // 
            this.ReturnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnToMenu.ForeColor = System.Drawing.Color.Black;
            this.ReturnToMenu.Location = new System.Drawing.Point(252, 3);
            this.ReturnToMenu.Name = "ReturnToMenu";
            this.ReturnToMenu.Size = new System.Drawing.Size(22, 22);
            this.ReturnToMenu.TabIndex = 30;
            this.ReturnToMenu.Text = "<";
            this.ReturnToMenu.UseVisualStyleBackColor = true;
            this.ReturnToMenu.Click += new System.EventHandler(this.ReturnToMenu_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Калькулятор";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CloseApplication
            // 
            this.CloseApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseApplication.ForeColor = System.Drawing.Color.Red;
            this.CloseApplication.Location = new System.Drawing.Point(280, 3);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(22, 22);
            this.CloseApplication.TabIndex = 29;
            this.CloseApplication.Text = "X";
            this.CloseApplication.UseVisualStyleBackColor = true;
            this.CloseApplication.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Сумма";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Срок";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Годовая ставка";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Calculate.ForeColor = System.Drawing.Color.Black;
            this.Calculate.Location = new System.Drawing.Point(15, 241);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(273, 32);
            this.Calculate.TabIndex = 24;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Пополнение";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // addTypeSelector
            // 
            this.addTypeSelector.DropDownWidth = 120;
            this.addTypeSelector.Items.AddRange(new object[] {
            "ежемесячно",
            "ежеквартально",
            "раз в полгода",
            "раз в год"});
            this.addTypeSelector.Location = new System.Drawing.Point(237, 154);
            this.addTypeSelector.Name = "addTypeSelector";
            this.addTypeSelector.Size = new System.Drawing.Size(51, 21);
            this.addTypeSelector.TabIndex = 28;
            // 
            // addEveryTerm
            // 
            this.addEveryTerm.Location = new System.Drawing.Point(130, 154);
            this.addEveryTerm.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.addEveryTerm.Name = "addEveryTerm";
            this.addEveryTerm.Size = new System.Drawing.Size(101, 20);
            this.addEveryTerm.TabIndex = 27;
            this.addEveryTerm.ThousandsSeparator = true;
            // 
            // exportData
            // 
            this.exportData.AutoSize = true;
            this.exportData.Location = new System.Drawing.Point(15, 206);
            this.exportData.Name = "exportData";
            this.exportData.Size = new System.Drawing.Size(188, 17);
            this.exportData.TabIndex = 29;
            this.exportData.Text = "Экспортировать данные в Excel";
            this.exportData.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(303, 296);
            this.Controls.Add(this.exportData);
            this.Controls.Add(this.addTypeSelector);
            this.Controls.Add(this.addEveryTerm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputPercent);
            this.Controls.Add(this.selectTypeTerm);
            this.Controls.Add(this.inputTerm);
            this.Controls.Add(this.inputAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPercent)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addEveryTerm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown inputAmount;
        private System.Windows.Forms.NumericUpDown inputTerm;
        private System.Windows.Forms.ComboBox selectTypeTerm;
        private System.Windows.Forms.NumericUpDown inputPercent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addTypeSelector;
        private System.Windows.Forms.NumericUpDown addEveryTerm;
        private System.Windows.Forms.Button CloseApplication;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ReturnToMenu;
        private System.Windows.Forms.CheckBox exportData;
    }
}
