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
            login = new Button();
            label3 = new Label();
            system_text = new TextBox();
            Reset = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // Plate
            // 
            Plate.Location = new Point(9, 9);
            Plate.Name = "Plate";
            Plate.Size = new Size(500, 500);
            Plate.TabIndex = 2;
            Plate.Paint += Plate_Paint;
            Plate.MouseClick += Plate_MouseClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(592, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(592, 8);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 4;
            label1.Text = "伺服器IP：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(592, 61);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 5;
            label2.Text = "PORT：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(592, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // login
            // 
            login.BackColor = SystemColors.Menu;
            login.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(592, 169);
            login.Name = "login";
            login.Size = new Size(114, 26);
            login.TabIndex = 7;
            login.Text = "登入伺服器";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(592, 343);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 9;
            label3.Text = "系統訊息：";
            label3.Click += label3_Click;
            // 
            // system_text
            // 
            system_text.Location = new Point(592, 372);
            system_text.Name = "system_text";
            system_text.ReadOnly = true;
            system_text.Size = new Size(105, 23);
            system_text.TabIndex = 8;
            system_text.TextChanged += system_text_TextChanged;
            // 
            // Reset
            // 
            Reset.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Reset.Location = new Point(592, 399);
            Reset.Name = "Reset";
            Reset.Size = new Size(96, 36);
            Reset.TabIndex = 10;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(592, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 23);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(592, 114);
            label4.Name = "label4";
            label4.Size = new Size(105, 24);
            label4.TabIndex = 11;
            label4.Text = "玩家名稱：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(592, 199);
            label5.Name = "label5";
            label5.Size = new Size(124, 24);
            label5.TabIndex = 13;
            label5.Text = "線上使用者：";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(592, 224);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(114, 94);
            listBox1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 533);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(Reset);
            Controls.Add(label3);
            Controls.Add(system_text);
            Controls.Add(login);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Plate);
            Name = "Form1";
            Text = "Form1";
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
        private Button login;
        private Label label3;
        private TextBox system_text;
        private Button Reset;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
    }
}