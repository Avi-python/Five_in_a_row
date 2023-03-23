using GobangLibrary;
using GobangLibrary.Extension;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Five_in_a_row
{
    //�Ѥl���ʤW�U���Z�����O
    public partial class Form1 : Form
    {
        private Image myImage;
        private int[,] plate = new int[10, 10]; //�x�s�ѽL�W���¥մѦ�m
        private int CurrentX; //�����bplate�x�}�̪�x�y��
        private int CurrentY; //�����bplate�x�}�̪�y�y��
        private bool IsWhite = true; //�����{�b�O�_�O�զ��
        private bool IsOver = false; //�����{�b�O�_����C��
        private bool IsConnected = false; //���U'�n�����A��'�o��button��A�|�ܦ�true
        private bool IsXok = false; //�P�_�ƹ��b�ѽL�W�I����X�y�ЬO�_�b�I�I�W
        private bool IsYok = false; //�P�_�ƹ��b�ѽL�W�I����Y�y�ЬO�_�b�I�I�W
        private bool setServerIp = false;
        private bool setPortNumber = false;
        private bool setPlayerName = false;

        Socket Client;//通訊物件
        Thread Thread;//網路監聽執行緒
        string User;//使用者

        private static GameManager GM;


        public Form1()
        {
            InitializeComponent();
            myImage = new Bitmap(Plate.Width, Plate.Height);
        }

        public string SetupPlayerName()
        {
            textBox3.Focus();
            system_text.Text = textBox3.Text;
            return textBox3.Text;
        }

        private void draw()
        {
            Graphics g = Graphics.FromImage(myImage);
            g.Clear(this.BackColor);
            g.FillRectangle(Brushes.PaleGoldenrod, new Rectangle(new Point(12, 12), new Size(450, 450)));
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    g.DrawRectangle(new Pen(Brushes.Black), i * 50 + 12, j * 50 + 12, 50, 50);
                }
            }
            Graphics gg = Plate.CreateGraphics();
            gg.DrawImage(myImage, 0, 0);
        }

        private void DrawChess(Graphics g, int x, int y, Pen p, Brush brush, int flag)
        {
            CurrentX = x;
            CurrentY = y;
            plate[x, y] = flag; //flag==1 �զ�ѡAflag==2 �¦��
            g.DrawEllipse(p, x * 50, y * 50, 25, 25);
            g.FillEllipse(brush, x * 50, y * 50, 25, 25);
        }

        private void Plate_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsConnected)
            {
                if (IsOver)
                {
                    return;
                }
                Graphics g = Plate.CreateGraphics();
                //�u�n�ƹ��U�b�I�I�y�Ъ����t10�H���A���i�H���\�U��
                int x = (e.X - 10) % 50;
                int y = (e.Y - 10) % 50;
                if (x > 40)
                {
                    x = (e.X - 10) / 50 + 1;
                    IsXok = true;
                }
                else if (x < 10)
                {
                    x = (e.X - 10) / 50;
                    IsXok = true;
                }
                if (y > 40)
                {
                    y = (e.Y - 10) / 50 + 1;
                    IsYok = true;
                }
                else if (y < 10)
                {
                    y = (e.Y - 10) / 50;
                    IsYok = true;
                }
                if (IsYok == true && IsXok == true)
                {
                    if (x >= 0 && x < 10 && y >= 0 && y < 10 && plate[x, y] == 0)
                    {
                        system_text.Text = "";
                        if (IsWhite)
                        {
                            DrawChess(g, x, y, new Pen(Brushes.White), Brushes.White, 1);
                            IsWhite = false;
                            //�o��n�[�P�_Ĺ�F�S��function�ӧP�_�n���n����
                        }
                        else
                        {
                            DrawChess(g, x, y, new Pen(Brushes.Black), Brushes.Black, 2);
                            IsWhite = true;
                            //�o��n�[�P�_Ĺ�F�S��function�ӧP�_�n���n����
                        }
                    }
                }
                else
                {
                    system_text.Text = "請點擊正確位置";
                }
                IsXok = false;
                IsYok = false;
            }
        }
        //private void login_Click(object sender, EventArgs e) // 交給Form2處理
        //{
        //    嘗試連接
        //    int tmpPort;
        //    IPAddress tmpServerIp;
        //    if (!textBox2.Text.ToPort(out tmpPort))
        //    {
        //        system_text.Text = "無效埠口";
        //    }
        //    else setPortNumber = false;
        //    if (!textBox1.Text.ToServerIP(out tmpServerIp))
        //    {
        //        system_text.Text = "無效IP";
        //    }
        //    else setServerIp = false;
        //    還有一個階段
        //    if (setPlayerName && setPortNumber && setServerIp)
        //    {
        //        if (GM.SetUp(tmpServerIp, tmpPort, textBox2.Text))
        //        {
        //            draw();
        //            IsConnected = true;
        //            Reset.Enabled = true; // true 打開 reset button，應該要在正式開始遊戲的時候才enable
        //            system_text.Text = "登入伺服器";
        //        }
        //    }
        //    else
        //    {
        //        system_text.Text = "尚未輸入完全";
        //    }
        //}
        private void Reset_Click(object sender, EventArgs e)
        {
            IsOver = false;
            IsWhite = true;
            draw();
            plate = new int[10, 10];
        }

        private void Plate_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //system_text.Text = textBox1.Text;
            // 可以設計更多，或許可以偵測IP格式對不對
            if (textBox1.Text != "") setServerIp = true;
            else setServerIp = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //system_text.Text = textBox2.Text;
            if (textBox2.Text != "") setPortNumber = true;
            else setPortNumber = false;

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //system_text.Text = textBox3.Text;
            // 可以設計更多，或許可以偵測名子對不對
            if (textBox3.Text != "") setPlayerName = true;
            else setPlayerName = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void system_text_TextChanged(object sender, EventArgs e)
        {

        }

        #region InterNet Component

        private void Listen()
        {
            EndPoint ServerEP = (EndPoint)Client.RemoteEndPoint; //Server 的 EndPoint
            byte[] Byte = new byte[1023]; //接收用的 Byte 陣列
            int ByteLength = 0; //接收的位元組數目
            string Msg; //接收到的完整訊息
            string Cmd; //命令碼
            string Str; //訊息內容(不含命令碼)
            while (true)//無限次監聽迴圈
            {
                try
                {
                    ByteLength = Client.ReceiveFrom(Byte, ref ServerEP);//收聽資訊並取得位元組數
                }
                catch (Exception)//產生錯誤時
                {
                    Client.Close();//關閉s通訊器
                    listBox1.Items.Clear();//清除線上名單
                    MessageBox.Show("伺服器斷線了！");//顯示斷線
                    button1.Enabled = true;//連線按鍵恢復可用

                    // 這邊要處理

                    Thread.Abort();//刪除執行緒，現在這個用不了
                    //Thread.Interrupt();
                }
                Msg = Encoding.Default.GetString(Byte, 0, ByteLength); //解讀完整訊息
                Cmd = Msg.Substring(0, 1); //取出命令碼 (第一個字)
                Str = Msg.Substring(1); //取出命令碼之後的訊息   
                switch (Cmd)//依命令碼執行功能
                {
                    case "L"://接收線上名單
                        listBox1.Items.Clear(); //清除名單
                        string[] M = Str.Split(','); //拆解名單成陣列
                        for (int i = 0; i < M.Length; i++)
                        {
                            listBox1.Items.Add(M[i]); //逐一加入名單
                        }
                        break;
                    case "1"://接收廣播訊息
                        TextBox4.Text += "(公開)" + Str + "\r\n";//顯示訊息並換行
                        TextBox4.SelectionStart = TextBox4.Text.Length; //游標移到最後
                        TextBox4.ScrollToCaret(); //捲動到游標位置
                        break;
                    case "2"://接收私密訊息
                        TextBox4.Text += "(私密)" + Str + "\r\n";//顯示訊息並換行
                        TextBox4.SelectionStart = TextBox4.Text.Length;//游標移到最後
                        TextBox4.ScrollToCaret();//捲動到游標位置
                        break;
                    case "3"://來自server
                        if (Str == "你是先手") 
                        TextBox4.Text += Str + "\r\n";//顯示訊息並換行
                        TextBox4.SelectionStart = TextBox4.Text.Length;//游標移到最後
                        TextBox4.ScrollToCaret();//捲動到游標位置
                        break;
                }
            }
        }
        private void Send(string Str)
        {
            byte[] B = Encoding.Default.GetBytes(Str); //翻譯文字為Byte陣列
            Client.Send(B, 0, B.Length, SocketFlags.None); //使用連線物件傳送資料
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; //忽略跨執行緒錯誤
            User = textBox3.Text;//使用者名稱
            string IP = textBox1.Text;//伺服器IP

            //這邊要做除錯
            int Port = int.Parse(textBox2.Text);//伺服器Port
            //建立通訊物件，參數代表可以雙向通訊的TCP連線
            try
            {
                IPEndPoint EP = new IPEndPoint(IPAddress.Parse(IP), Port);//伺服器的連線端點資訊
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Client.Connect(EP); //連上伺服器的端點EP(類似撥號給電話總機)
                Thread = new Thread(Listen); //建立監聽執行緒
                Thread.IsBackground = true; //設定為背景執行緒
                Thread.Start(); //開始監聽;
                TextBox4.Text = "已連線伺服器！" + "\r\n";
                //TextBox4.Text = "等待伺服器傳達訊息..." + "\r\n";
                Send("0" + User);  //連線後隨即傳送自己的名稱給伺服器
            }
            catch (Exception)
            {
                TextBox4.Text = "無法連上伺服器！" + "\r\n"; //連線失敗時顯示訊息
                return;
            }
            button1.Enabled = false; //讓連線按鍵失效，避免重複連線
            //Button2.Enabled = true;  //如連線成功可以開始發送訊息
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (button1.Enabled == false)
            {
                Send("9" + User); //傳送自己的離線訊息給伺服器
                Client.Close(); //關閉網路通訊器
            }
        }

        #endregion

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}