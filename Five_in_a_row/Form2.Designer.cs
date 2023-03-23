namespace Five_in_a_row
{
    partial class Form2
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            Button3 = new Button();
            Label5 = new Label();
            Button1 = new Button();
            TextBox2 = new TextBox();
            Label2 = new Label();
            TextBox1 = new TextBox();
            Label1 = new Label();
            TextBox3 = new TextBox();
            Label4 = new Label();
            Label3 = new Label();
            ListBox1 = new ListBox();
            Button2 = new Button();
            TextBox4 = new TextBox();
            TextBox5 = new TextBox();
            SuspendLayout();
            // 
            // Button3
            // 
            Button3.Location = new Point(630, 58);
            Button3.Margin = new Padding(4);
            Button3.Name = "Button3";
            Button3.Size = new Size(66, 29);
            Button3.TabIndex = 112;
            Button3.Text = "廣播";
            Button3.UseVisualStyleBackColor = true;
            Button3.Click += Button3_Click;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("新細明體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.Location = new Point(13, 458);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(65, 12);
            Label5.TabIndex = 111;
            Label5.Text = "發言內容：";
            // 
            // Button1
            // 
            Button1.Font = new Font("新細明體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button1.Location = new Point(516, 11);
            Button1.Margin = new Padding(4);
            Button1.Name = "Button1";
            Button1.Size = new Size(184, 39);
            Button1.TabIndex = 110;
            Button1.Text = "登入伺服器";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(369, 16);
            TextBox2.Margin = new Padding(4);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(135, 23);
            TextBox2.TabIndex = 109;
            TextBox2.Text = "2023";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("新細明體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.Location = new Point(272, 22);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(72, 12);
            Label2.TabIndex = 108;
            Label2.Text = "伺服器Port：";
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(115, 16);
            TextBox1.Margin = new Padding(4);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(135, 23);
            TextBox1.TabIndex = 107;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("新細明體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(19, 22);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(63, 12);
            Label1.TabIndex = 106;
            Label1.Text = "伺服器IP：";
            // 
            // TextBox3
            // 
            TextBox3.Location = new Point(113, 60);
            TextBox3.Margin = new Padding(4);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(134, 23);
            TextBox3.TabIndex = 105;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("新細明體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.Location = new Point(15, 66);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(65, 12);
            Label4.TabIndex = 104;
            Label4.Text = "玩家名稱：";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("新細明體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.Location = new Point(530, 66);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(65, 12);
            Label3.TabIndex = 103;
            Label3.Text = "線上使用者";
            // 
            // ListBox1
            // 
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 15;
            ListBox1.Location = new Point(532, 94);
            ListBox1.Margin = new Padding(4);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(164, 334);
            ListBox1.TabIndex = 102;
            // 
            // Button2
            // 
            Button2.Enabled = false;
            Button2.Font = new Font("新細明體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button2.Location = new Point(597, 450);
            Button2.Margin = new Padding(4);
            Button2.Name = "Button2";
            Button2.Size = new Size(99, 29);
            Button2.TabIndex = 101;
            Button2.Text = "送出";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // TextBox4
            // 
            TextBox4.Location = new Point(15, 94);
            TextBox4.Margin = new Padding(4);
            TextBox4.Multiline = true;
            TextBox4.Name = "TextBox4";
            TextBox4.ScrollBars = ScrollBars.Vertical;
            TextBox4.Size = new Size(488, 342);
            TextBox4.TabIndex = 100;
            TextBox4.TextChanged += TextBox4_TextChanged;
            // 
            // TextBox5
            // 
            TextBox5.BackColor = SystemColors.Info;
            TextBox5.Font = new Font("新細明體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox5.Location = new Point(96, 451);
            TextBox5.Margin = new Padding(4);
            TextBox5.Name = "TextBox5";
            TextBox5.Size = new Size(494, 22);
            TextBox5.TabIndex = 99;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 491);
            Controls.Add(Button3);
            Controls.Add(Label5);
            Controls.Add(Button1);
            Controls.Add(TextBox2);
            Controls.Add(Label2);
            Controls.Add(TextBox1);
            Controls.Add(Label1);
            Controls.Add(TextBox3);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(ListBox1);
            Controls.Add(Button2);
            Controls.Add(TextBox4);
            Controls.Add(TextBox5);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "TCP聊天室客戶端";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.TextBox TextBox5;
    }
}

