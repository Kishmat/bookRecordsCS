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
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            label5 = new Label();
            button4 = new Button();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            insert_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(34, 32);
            label1.Name = "label1";
            label1.Size = new Size(195, 38);
            label1.TabIndex = 0;
            label1.Text = "Book Records";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(34, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(499, 129);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += updateTitleName;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(39, 240);
            label2.Name = "label2";
            label2.Size = new Size(357, 25);
            label2.TabIndex = 2;
            label2.Text = "To show the list of books, click on Display.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(39, 279);
            label3.Name = "label3";
            label3.Size = new Size(254, 25);
            label3.TabIndex = 2;
            label3.Text = "To clear the list click on Clear.";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(45, 331);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Location = new Point(809, 645);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(45, 389);
            label4.Name = "label4";
            label4.Size = new Size(465, 63);
            label4.TabIndex = 2;
            label4.Text = "To edit a file, click on Display, and select a record. Enter the new title below and click on Edit Title.";
            label4.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 466);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 31);
            textBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Location = new Point(45, 516);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "Edit TItle";
            button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(45, 579);
            label5.Name = "label5";
            label5.Size = new Size(465, 63);
            label5.TabIndex = 2;
            label5.Text = "To delete a book, click on Display and select a record. Click on Delete.";
            label5.Click += label2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Location = new Point(45, 645);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 3;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(660, 43);
            label6.Name = "label6";
            label6.Size = new Size(465, 63);
            label6.TabIndex = 2;
            label6.Text = "To insert a new record, click on Display. Enter the details below and click on Insert.";
            label6.Click += label2_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(660, 116);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 2;
            label7.Text = "BookKey:";
            label7.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(758, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 31);
            textBox2.TabIndex = 4;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(660, 170);
            label8.Name = "label8";
            label8.Size = new Size(92, 28);
            label8.TabIndex = 2;
            label8.Text = "Title:";
            label8.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(758, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 31);
            textBox3.TabIndex = 4;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(660, 225);
            label9.Name = "label9";
            label9.Size = new Size(92, 28);
            label9.TabIndex = 2;
            label9.Text = "Pages:";
            label9.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(758, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(238, 31);
            textBox4.TabIndex = 4;
            // 
            // insert_btn
            // 
            insert_btn.BackColor = Color.LightSkyBlue;
            insert_btn.Location = new Point(660, 309);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(112, 34);
            insert_btn.TabIndex = 5;
            insert_btn.Text = "Insert";
            insert_btn.UseVisualStyleBackColor = false;
            insert_btn.Click += insert_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1160, 720);
            Controls.Add(insert_btn);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Insert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox textBox1;
        private Button button3;
        private Label label5;
        private Button button4;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox4;
        private Button insert_btn;
    }
}
