namespace Darts
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
            label1 = new Label();
            label2 = new Label();
            labelRed = new Label();
            labelGreen = new Label();
            textBox1Red = new TextBox();
            textBox2Red = new TextBox();
            textBox3Red = new TextBox();
            buttonRed = new Button();
            labelRedClicks = new Label();
            labelGreenClicks = new Label();
            buttonGreen = new Button();
            textBox3Green = new TextBox();
            textBox2Green = new TextBox();
            textBox1Green = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(110, 95);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 22);
            label1.TabIndex = 0;
            label1.Text = "000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(395, 95);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 22);
            label2.TabIndex = 1;
            label2.Text = "000";
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Location = new Point(110, 53);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(88, 22);
            labelRed.TabIndex = 2;
            labelRed.Text = "Красные";
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Location = new Point(395, 53);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(84, 22);
            labelGreen.TabIndex = 3;
            labelGreen.Text = "Зеленые";
            // 
            // textBox1Red
            // 
            textBox1Red.Location = new Point(98, 149);
            textBox1Red.Name = "textBox1Red";
            textBox1Red.Size = new Size(70, 29);
            textBox1Red.TabIndex = 4;
            // 
            // textBox2Red
            // 
            textBox2Red.Location = new Point(98, 224);
            textBox2Red.Name = "textBox2Red";
            textBox2Red.Size = new Size(70, 29);
            textBox2Red.TabIndex = 5;
            // 
            // textBox3Red
            // 
            textBox3Red.Location = new Point(98, 310);
            textBox3Red.Name = "textBox3Red";
            textBox3Red.Size = new Size(70, 29);
            textBox3Red.TabIndex = 6;
            // 
            // buttonRed
            // 
            buttonRed.Location = new Point(81, 381);
            buttonRed.Name = "buttonRed";
            buttonRed.Size = new Size(117, 43);
            buttonRed.TabIndex = 7;
            buttonRed.Text = "Счет";
            buttonRed.UseVisualStyleBackColor = true;
            buttonRed.Click += buttonRed_Click;
            // 
            // labelRedClicks
            // 
            labelRedClicks.AutoSize = true;
            labelRedClicks.Location = new Point(110, 468);
            labelRedClicks.Name = "labelRedClicks";
            labelRedClicks.Size = new Size(59, 22);
            labelRedClicks.TabIndex = 8;
            labelRedClicks.Text = "label3";
            // 
            // labelGreenClicks
            // 
            labelGreenClicks.AutoSize = true;
            labelGreenClicks.Location = new Point(396, 468);
            labelGreenClicks.Name = "labelGreenClicks";
            labelGreenClicks.Size = new Size(59, 22);
            labelGreenClicks.TabIndex = 13;
            labelGreenClicks.Text = "label3";
            // 
            // buttonGreen
            // 
            buttonGreen.Location = new Point(362, 381);
            buttonGreen.Name = "buttonGreen";
            buttonGreen.Size = new Size(117, 43);
            buttonGreen.TabIndex = 12;
            buttonGreen.Text = "Счет";
            buttonGreen.UseVisualStyleBackColor = true;
            buttonGreen.Click += buttonGreen_Click;
            // 
            // textBox3Green
            // 
            textBox3Green.Location = new Point(384, 310);
            textBox3Green.Name = "textBox3Green";
            textBox3Green.Size = new Size(70, 29);
            textBox3Green.TabIndex = 11;
            // 
            // textBox2Green
            // 
            textBox2Green.Location = new Point(384, 224);
            textBox2Green.Name = "textBox2Green";
            textBox2Green.Size = new Size(70, 29);
            textBox2Green.TabIndex = 10;
            // 
            // textBox1Green
            // 
            textBox1Green.Location = new Point(384, 149);
            textBox1Green.Name = "textBox1Green";
            textBox1Green.Size = new Size(70, 29);
            textBox1Green.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 541);
            Controls.Add(labelGreenClicks);
            Controls.Add(buttonGreen);
            Controls.Add(textBox3Green);
            Controls.Add(textBox2Green);
            Controls.Add(textBox1Green);
            Controls.Add(labelRedClicks);
            Controls.Add(buttonRed);
            Controls.Add(textBox3Red);
            Controls.Add(textBox2Red);
            Controls.Add(textBox1Red);
            Controls.Add(labelGreen);
            Controls.Add(labelRed);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Darts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelRed;
        private Label labelGreen;
        private TextBox textBox1Red;
        private TextBox textBox2Red;
        private TextBox textBox3Red;
        private Button buttonRed;
        private Label labelRedClicks;
        private Label labelGreenClicks;
        private Button buttonGreen;
        private TextBox textBox3Green;
        private TextBox textBox2Green;
        private TextBox textBox1Green;
    }
}
