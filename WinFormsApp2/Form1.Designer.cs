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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 30);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Number of items:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 83);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 2;
            label2.Text = "Seed:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 136);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Capacity:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(44, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(44, 342);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(213, 84);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(317, 82);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(381, 344);
            listBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(153, 194);
            button1.Name = "button1";
            button1.Size = new Size(92, 36);
            button1.TabIndex = 12;
            button1.Text = "Pack";
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 274);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 9;
            label4.Text = "total value";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 305);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 10;
            label5.Text = "total weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 240);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 11;
            label6.Text = "Status";
            // 
            // button2
            // 
            button2.Location = new Point(44, 194);
            button2.Name = "button2";
            button2.Size = new Size(89, 36);
            button2.TabIndex = 0;
            button2.Text = "Generate";
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
    }
}
