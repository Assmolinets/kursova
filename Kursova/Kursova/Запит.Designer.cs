namespace Kursova
{
    partial class Input
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
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button_close = new Button();
            comboBoxSex = new ComboBox();
            numericAge = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericAge).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(63, 47);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(261, 23);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 15F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 24);
            label1.TabIndex = 3;
            label1.Text = "Введіть дані нового родича";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 10F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(19, 49);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 4;
            label2.Text = "ПІБ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 10F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 5;
            label3.Text = "Стать";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 10F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(180, 78);
            label4.Name = "label4";
            label4.Size = new Size(28, 17);
            label4.TabIndex = 6;
            label4.Text = "Вік";
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Bahnschrift", 13F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(217, 108);
            button2.Name = "button2";
            button2.Size = new Size(107, 32);
            button2.TabIndex = 7;
            button2.Text = "Створити";
            button2.UseVisualStyleBackColor = false;
            // 
            // button_close
            // 
            button_close.BackColor = Color.MidnightBlue;
            button_close.Font = new Font("Bahnschrift", 13F);
            button_close.ForeColor = SystemColors.ButtonFace;
            button_close.Location = new Point(12, 108);
            button_close.Name = "button_close";
            button_close.Size = new Size(107, 32);
            button_close.TabIndex = 8;
            button_close.Text = "Назад";
            button_close.UseVisualStyleBackColor = false;
            button_close.Click += button_close_Click;
            // 
            // comboBoxSex
            // 
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(63, 76);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Items.AddRange(new object[] { "Чоловік", "Жінка" });
            comboBoxSex.Size = new Size(100, 23);
            comboBoxSex.TabIndex = 9;
            // 
            // numericAge
            // 
            numericAge.Location = new Point(224, 76);
            numericAge.Name = "numericAge";
            numericAge.Size = new Size(100, 23);
            numericAge.TabIndex = 10;
            numericAge.Minimum = 0;
            numericAge.Maximum = 150;
            // 
            // Input
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(336, 152);
            Controls.Add(numericAge);
            Controls.Add(comboBoxSex);
            Controls.Add(button_close);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Input";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Запит";
            ((System.ComponentModel.ISupportInitialize)numericAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button_close;
        private ComboBox comboBoxSex;
        private NumericUpDown numericAge;
    }
}