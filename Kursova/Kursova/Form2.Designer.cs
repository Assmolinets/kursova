namespace Kursova
{
    partial class Form2
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
            buttonAdd = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(26, 26, 51);
            buttonAdd.Font = new Font("Bahnschrift", 16F);
            buttonAdd.ForeColor = SystemColors.ButtonFace;
            buttonAdd.Location = new Point(32, 59);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(340, 52);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Додати члена сім'ї";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Bahnschrift", 13F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(72, 41);
            button2.TabIndex = 2;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додати члена сім'ї";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private Button button2;
    }
}