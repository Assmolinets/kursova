namespace Kursova
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Bahnschrift", 16F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(238, 129);
            button1.Name = "button1";
            button1.Size = new Size(340, 52);
            button1.TabIndex = 0;
            button1.Text = "Додати члена сім'ї";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 40F);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(136, 32);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(549, 65);
            label1.TabIndex = 1;
            label1.Text = "Генеалогічне дерево";
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Bahnschrift", 16F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(238, 204);
            button2.Name = "button2";
            button2.Size = new Size(340, 52);
            button2.TabIndex = 2;
            button2.Text = "Список членів сім'ї";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.Font = new Font("Bahnschrift", 16F);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(238, 283);
            button3.Name = "button3";
            button3.Size = new Size(340, 52);
            button3.TabIndex = 3;
            button3.Text = "Генеалогічне дерево";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.Font = new Font("Bahnschrift", 16F);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(238, 361);
            button4.Name = "button4";
            button4.Size = new Size(340, 52);
            button4.TabIndex = 4;
            button4.Text = "Видалити члена сім'ї";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Генеалогічне дерево";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}
