namespace WinFormsApp2
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(23, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(330, 392);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(446, 12);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(330, 392);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += FilterButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Генерация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GenerateButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(470, 413);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(184, 412);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Открыть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += LoadButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(659, 411);
            button3.Name = "button3";
            button3.Size = new Size(107, 29);
            button3.TabIndex = 5;
            button3.Text = "Фильтровать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += FilterButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(343, 411);
            button4.Name = "button4";
            button4.Size = new Size(109, 29);
            button4.TabIndex = 6;
            button4.Text = "Сортировать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += SortAlpButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "WORKER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
