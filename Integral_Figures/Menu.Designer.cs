namespace Integral_Figures
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(208, 140);
            button1.Name = "button1";
            button1.Size = new Size(126, 48);
            button1.TabIndex = 0;
            button1.Text = "Начать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(208, 220);
            button2.Name = "button2";
            button2.Size = new Size(126, 48);
            button2.TabIndex = 1;
            button2.Text = "Правила использования";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(461, 56);
            label1.TabIndex = 2;
            label1.Text = "Вычисление площади криволинейной трапеции\r\nи фигуры определенной двумя функциями\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 324);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вичисление площади плоских фигур с помощью интеграла";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}