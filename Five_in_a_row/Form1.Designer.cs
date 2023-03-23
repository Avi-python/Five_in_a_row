namespace Five_in_a_row
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
            Plate = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            system_text = new TextBox();
            Reset = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            TextBox4 = new TextBox();
            TextBox5 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // Plate
            // 
            Plate.BackColor = Color.AntiqueWhite;
            Plate.Location = new Point(12, 16);
            Plate.Name = "Plate";
            Plate.Size = new Size(500, 500);
            Plate.TabIndex = 2;
            Plate.Paint += Plate_Paint;
            Plate.MouseClick += Plate_MouseClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(552, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(552, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "Server IP：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(553, 73);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "PORT：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(552, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // system_text
            // 
            system_text.Cursor = Cursors.No;
            system_text.Location = new Point(12, 531);
            system_text.Multiline = true;
            system_text.Name = "system_text";
            system_text.ReadOnly = true;
            system_text.Size = new Size(500, 71);
            system_text.TabIndex = 8;
            system_text.TextChanged += system_text_TextChanged;
            // 
            // Reset
            // 
            Reset.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Reset.Location = new Point(585, 378);
            Reset.Name = "Reset";
            Reset.Size = new Size(83, 33);
            Reset.TabIndex = 10;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(552, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 23);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(553, 126);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 11;
            label4.Text = "UserName：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(553, 235);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 13;
            label5.Text = "Online User：";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(547, 268);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(121, 94);
            listBox1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(553, 193);
            button1.Name = "button1";
            button1.Size = new Size(115, 28);
            button1.TabIndex = 16;
            button1.Text = "Login\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TextBox4
            // 
            TextBox4.BackColor = SystemColors.Info;
            TextBox4.Location = new Point(547, 427);
            TextBox4.Margin = new Padding(4);
            TextBox4.Multiline = true;
            TextBox4.Name = "TextBox4";
            TextBox4.ReadOnly = true;
            TextBox4.ScrollBars = ScrollBars.Vertical;
            TextBox4.Size = new Size(121, 204);
            TextBox4.TabIndex = 101;
            TextBox4.TextChanged += TextBox4_TextChanged;
            // 
            // TextBox5
            // 
            TextBox5.BackColor = SystemColors.Info;
            TextBox5.Font = new Font("新細明體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox5.Location = new Point(68, 609);
            TextBox5.Margin = new Padding(4);
            TextBox5.Name = "TextBox5";
            TextBox5.Size = new Size(444, 22);
            TextBox5.TabIndex = 102;
            TextBox5.TextChanged += TextBox5_TextChanged;
            TextBox5.KeyDown += TextBox5_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 609);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 103;
            label3.Text = "(敵人)";
            label3.Click += label3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 641);
            Controls.Add(label3);
            Controls.Add(TextBox5);
            Controls.Add(Reset);
            Controls.Add(TextBox4);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(system_text);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Plate);
            Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        /*
private void Plate_Paint(object sender, PaintEventArgs e)
{

}*/

        #endregion
        private Panel Plate;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox system_text;
        private Button Reset;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private Button button1;
        internal TextBox TextBox4;
        internal TextBox TextBox5;
        private Label label3;
    }
}