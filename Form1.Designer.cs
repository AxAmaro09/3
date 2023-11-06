namespace _3
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(392, 711);
            button1.Name = "button1";
            button1.Size = new Size(197, 63);
            button1.TabIndex = 0;
            button1.Text = "Sumar números";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1036, 311);
            button2.Name = "button2";
            button2.Size = new Size(255, 42);
            button2.TabIndex = 1;
            button2.Text = "Agregar números";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(704, 313);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(704, 585);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 39);
            textBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(1086, 453);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(359, 388);
            listBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(704, 711);
            button3.Name = "button3";
            button3.Size = new Size(235, 63);
            button3.TabIndex = 5;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(690, 174);
            label1.Name = "label1";
            label1.Size = new Size(299, 32);
            label1.TabIndex = 6;
            label1.Text = "Suma números capturados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 321);
            label2.Name = "label2";
            label2.Size = new Size(254, 32);
            label2.TabIndex = 7;
            label2.Text = "Introduce los números";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 588);
            label3.Name = "label3";
            label3.Size = new Size(118, 32);
            label3.TabIndex = 8;
            label3.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 880);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}