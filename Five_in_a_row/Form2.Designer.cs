namespace TCP_Client
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
            this.Button3 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(540, 46);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(57, 23);
            this.Button3.TabIndex = 112;
            this.Button3.Text = "廣播";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label5.Location = new System.Drawing.Point(11, 366);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(65, 12);
            this.Label5.TabIndex = 111;
            this.Label5.Text = "發言內容：";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button1.Location = new System.Drawing.Point(442, 9);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(158, 31);
            this.Button1.TabIndex = 110;
            this.Button1.Text = "登入伺服器";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(316, 13);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(116, 22);
            this.TextBox2.TabIndex = 109;
            this.TextBox2.Text = "2023";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label2.Location = new System.Drawing.Point(233, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 12);
            this.Label2.TabIndex = 108;
            this.Label2.Text = "伺服器Port：";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(99, 13);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(116, 22);
            this.TextBox1.TabIndex = 107;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.Location = new System.Drawing.Point(16, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 12);
            this.Label1.TabIndex = 106;
            this.Label1.Text = "伺服器IP：";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(97, 48);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(115, 22);
            this.TextBox3.TabIndex = 105;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label4.Location = new System.Drawing.Point(13, 53);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 12);
            this.Label4.TabIndex = 104;
            this.Label4.Text = "玩家名稱：";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label3.Location = new System.Drawing.Point(454, 53);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 12);
            this.Label3.TabIndex = 103;
            this.Label3.Text = "線上使用者";
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 12;
            this.ListBox1.Location = new System.Drawing.Point(456, 75);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(141, 268);
            this.ListBox1.TabIndex = 102;
            // 
            // Button2
            // 
            this.Button2.Enabled = false;
            this.Button2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button2.Location = new System.Drawing.Point(512, 360);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(85, 23);
            this.Button2.TabIndex = 101;
            this.Button2.Text = "送出";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(13, 75);
            this.TextBox4.Multiline = true;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox4.Size = new System.Drawing.Size(419, 274);
            this.TextBox4.TabIndex = 100;
            this.TextBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // TextBox5
            // 
            this.TextBox5.BackColor = System.Drawing.SystemColors.Info;
            this.TextBox5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox5.Location = new System.Drawing.Point(82, 361);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(424, 22);
            this.TextBox5.TabIndex = 99;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 393);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox5);
            this.Name = "Form1";
            this.Text = "TCP聊天室客戶端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

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

