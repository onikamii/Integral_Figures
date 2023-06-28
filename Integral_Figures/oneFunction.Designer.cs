namespace Integral_Figures
{
    partial class oneFunction
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
            textBoxA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxB = new TextBox();
            label4 = new Label();
            textBoxC = new TextBox();
            label5 = new Label();
            textBoxBorderA = new TextBox();
            label6 = new Label();
            textBoxBorderB = new TextBox();
            button1 = new Button();
            label7 = new Label();
            button3 = new Button();
            ExpWord = new Button();
            ExpExcel = new Button();
            ImpWord = new Button();
            ImpExcel = new Button();
            button7 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(67, 89);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(38, 27);
            textBoxA.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 3;
            label1.Text = "Введите коэфициенты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 90);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 4;
            label2.Text = "a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 90);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 5;
            label3.Text = "b:";
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(156, 89);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(38, 27);
            textBoxB.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 90);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 7;
            label4.Text = "c:";
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(245, 89);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(38, 27);
            textBoxC.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 140);
            label5.Name = "label5";
            label5.Size = new Size(176, 20);
            label5.TabIndex = 9;
            label5.Text = "Введите левую границу:";
            // 
            // textBoxBorderA
            // 
            textBoxBorderA.Location = new Point(245, 139);
            textBoxBorderA.Name = "textBoxBorderA";
            textBoxBorderA.Size = new Size(38, 27);
            textBoxBorderA.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 190);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 11;
            label6.Text = "Введите правую границу:";
            // 
            // textBoxBorderB
            // 
            textBoxBorderB.Location = new Point(245, 189);
            textBoxBorderB.Name = "textBoxBorderB";
            textBoxBorderB.Size = new Size(38, 27);
            textBoxBorderB.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(67, 251);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 290);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 14;
            label7.Click += label7_Click;
            // 
            // button3
            // 
            button3.Location = new Point(360, 40);
            button3.Name = "button3";
            button3.Size = new Size(167, 29);
            button3.TabIndex = 16;
            button3.Text = "Подробное решение";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ExpWord
            // 
            ExpWord.Location = new Point(360, 90);
            ExpWord.Name = "ExpWord";
            ExpWord.Size = new Size(167, 29);
            ExpWord.TabIndex = 17;
            ExpWord.Text = "Экспорт в Word";
            ExpWord.UseVisualStyleBackColor = true;
            ExpWord.Click += ExpWord_Click;
            // 
            // ExpExcel
            // 
            ExpExcel.Location = new Point(360, 140);
            ExpExcel.Name = "ExpExcel";
            ExpExcel.Size = new Size(167, 29);
            ExpExcel.TabIndex = 18;
            ExpExcel.Text = "Экспорт в Excel";
            ExpExcel.UseVisualStyleBackColor = true;
            ExpExcel.Click += ExpExcel_Click;
            // 
            // ImpWord
            // 
            ImpWord.Location = new Point(360, 190);
            ImpWord.Name = "ImpWord";
            ImpWord.Size = new Size(167, 29);
            ImpWord.TabIndex = 19;
            ImpWord.Text = "Импорт в Word";
            ImpWord.UseVisualStyleBackColor = true;
            ImpWord.Click += button5_Click;
            // 
            // ImpExcel
            // 
            ImpExcel.Location = new Point(360, 240);
            ImpExcel.Name = "ImpExcel";
            ImpExcel.Size = new Size(167, 29);
            ImpExcel.TabIndex = 20;
            ImpExcel.Text = "Импорт в Excel";
            ImpExcel.UseVisualStyleBackColor = true;
            ImpExcel.Click += ImpExcel_Click;
            // 
            // button7
            // 
            button7.Location = new Point(396, 290);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 21;
            button7.Text = "Назад";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 50);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 23;
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 85);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 24;
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 120);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 25;
            label11.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(40, 155);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 27;
            label12.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(40, 190);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 28;
            label13.Visible = false;
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(40, 225);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 29;
            label14.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(40, 260);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 30;
            label15.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(40, 295);
            label16.Name = "label16";
            label16.Size = new Size(0, 20);
            label16.TabIndex = 31;
            label16.Visible = false;
            // 
            // oneFunction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 368);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button7);
            Controls.Add(ImpExcel);
            Controls.Add(ImpWord);
            Controls.Add(ExpExcel);
            Controls.Add(ExpWord);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(textBoxBorderB);
            Controls.Add(label6);
            Controls.Add(textBoxBorderA);
            Controls.Add(label5);
            Controls.Add(textBoxC);
            Controls.Add(label4);
            Controls.Add(textBoxB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxA);
            Name = "oneFunction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Криволинейная трапеция";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxB;
        private Label label4;
        private TextBox textBoxC;
        private Label label5;
        private TextBox textBoxBorderA;
        private Label label6;
        private TextBox textBoxBorderB;
        private Button button1;
        private Label label7;
        private Button button3;
        private Button ExpWord;
        private Button ExpExcel;
        private Button ImpWord;
        private Button ImpExcel;
        private Button button7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}