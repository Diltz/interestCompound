namespace compound
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.CloseApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputAmount = new System.Windows.Forms.TextBox();
            this.inputTerm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputPercent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.createGraphTick = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.CloseApp);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 29);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.title.Location = new System.Drawing.Point(3, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(248, 17);
            this.title.TabIndex = 1;
            this.title.Text = "Сложный процентщик [Калькулятор]";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // CloseApp
            // 
            this.CloseApp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.CloseApp.ForeColor = System.Drawing.Color.Red;
            this.CloseApp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseApp.Location = new System.Drawing.Point(432, 3);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(25, 25);
            this.CloseApp.TabIndex = 0;
            this.CloseApp.Text = "X";
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите данные, чтобы получить расчёты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сумма вклада";
            // 
            // inputAmount
            // 
            this.inputAmount.Location = new System.Drawing.Point(156, 79);
            this.inputAmount.Name = "inputAmount";
            this.inputAmount.Size = new System.Drawing.Size(292, 20);
            this.inputAmount.TabIndex = 5;
            // 
            // inputTerm
            // 
            this.inputTerm.Location = new System.Drawing.Point(156, 105);
            this.inputTerm.Name = "inputTerm";
            this.inputTerm.Size = new System.Drawing.Size(292, 20);
            this.inputTerm.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Срок вклада (лет)";
            // 
            // inputPercent
            // 
            this.inputPercent.Location = new System.Drawing.Point(156, 131);
            this.inputPercent.Name = "inputPercent";
            this.inputPercent.Size = new System.Drawing.Size(292, 20);
            this.inputPercent.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "% годовых";
            // 
            // calculate
            // 
            this.calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.calculate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.calculate.Location = new System.Drawing.Point(12, 280);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(436, 35);
            this.calculate.TabIndex = 10;
            this.calculate.Text = "Высчитать";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // createGraphTick
            // 
            this.createGraphTick.AutoSize = true;
            this.createGraphTick.Location = new System.Drawing.Point(16, 190);
            this.createGraphTick.Name = "createGraphTick";
            this.createGraphTick.Size = new System.Drawing.Size(120, 17);
            this.createGraphTick.TabIndex = 11;
            this.createGraphTick.Text = "Построить график";
            this.createGraphTick.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Параметры";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressTextBox
            // 
            this.progressTextBox.Location = new System.Drawing.Point(12, 213);
            this.progressTextBox.Name = "progressTextBox";
            this.progressTextBox.ReadOnly = true;
            this.progressTextBox.Size = new System.Drawing.Size(436, 63);
            this.progressTextBox.TabIndex = 13;
            this.progressTextBox.Text = "Результат: N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 327);
            this.Controls.Add(this.progressTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createGraphTick);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.inputPercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputTerm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputAmount;
        private System.Windows.Forms.TextBox inputTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.CheckBox createGraphTick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox progressTextBox;
    }
}