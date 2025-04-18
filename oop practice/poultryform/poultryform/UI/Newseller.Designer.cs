namespace poultryform.UI
{
    partial class Newseller
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(505, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(458, 34);
            label1.Name = "label1";
            label1.Size = new Size(367, 47);
            label1.TabIndex = 1;
            label1.Text = "Register a new buyer";
            // 
            // button1
            // 
            button1.Location = new Point(505, 522);
            button1.Name = "button1";
            button1.Size = new Size(241, 44);
            button1.TabIndex = 2;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(505, 144);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter the name:";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(505, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(505, 312);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(241, 23);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 215);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 8;
            label3.Text = "Enter the phone number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 353);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 9;
            label4.Text = "Enter the address:";
            label4.Click += label4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(505, 371);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(241, 96);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 294);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 13;
            label5.Text = "Enter the CNIC:";
            // 
            // Newseller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 620);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Newseller";
            Text = "Newseller";
            Load += Newseller_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label5;
    }
}