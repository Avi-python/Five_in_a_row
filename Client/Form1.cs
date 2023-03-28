using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Five_in_a_row
{
    public partial class Form1 : Form
    {
        private Image myImage;
        private int[,] plate = new int[10, 10];
        private int CurrentX;
        private int CurrentY;
        private bool IsOver = false;
        private bool PlayChessEnable = false;
        private bool IsXok = false; // 協助監測滑鼠點擊位置
        private bool IsYok = false;
        private bool setServerIp = false;
        private bool setPortNumber = false;
        private bool setPlayerName = false;
        public int _plateXStart = 30;
        public int _plateYStart = 30;
        Graphics gme;

        Socket Client = null;//通訊物件
        Thread Thread = null;//網路監聽執行緒
        string User = null;//使用者
        string EnemyName = null;

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

        #region 畫畫
        private void draw(int alpha = 100)
        {
            Graphics g = Graphics.FromImage(myImage);
            g.Clear(this.BackColor);
            g.FillRectangle(new SolidBrush(Color.FromArgb(alpha, Color.PaleGoldenrod)), new Rectangle(new Point(_plateXStart, _plateYStart), new Size(450, 450)));
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    g.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(alpha, Color.Black))), i * 50 + _plateXStart, j * 50 + _plateYStart, 50, 50);
                }
            }
            Graphics gg = Plate.CreateGraphics();
            gg.DrawImage(myImage, 0, 0);
            gme = gg;
        }
        private void DrawChess(Graphics g, int x, int y, Pen p, Brush brush, int flag)
        {
            CurrentX = x;
            CurrentY = y;
            plate[x, y] = flag; //flag==1 �զ�ѡAflag==2 �¦��
            g.DrawEllipse(p, x * 50 + _plateXStart / 2, y * 50 + _plateYStart / 2, 30, 30);
            g.FillEllipse(brush, x * 50 + _plateXStart / 2, y * 50 + _plateYStart / 2, 30, 30);
        }
        private void DrawChess(int x, int y, Pen p, Brush brush, int flag)
        {
            CurrentX = x;
            CurrentY = y;
            plate[x, y] = flag;
            gme.DrawEllipse(p, x * 50 + _plateXStart / 2, y * 50 + _plateYStart / 2, 30, 30);
            gme.FillEllipse(brush, x * 50 + _plateXStart / 2, y * 50 + _plateYStart / 2, 30, 30);
        }
        private void DrawAllChess()
        {
            for (int i = 0; i < plate.GetLength(0); i++)
            {
                for (int j = 0; j < plate.GetLength(1); j++)
                {
                    if (plate[i, j] == 1) DrawChess(i, j, new Pen(Brushes.White), Brushes.White, 1);
                    else if (plate[i, j] == 2) DrawChess(i, j, new Pen(Brushes.Black), Brushes.Black, 2);
                }
            }
        }

        private void DrawPlate()
        {
            gme.FillRectangle(new SolidBrush(Color.FromArgb(255, Color.PaleGoldenrod)), new Rectangle(new Point(0, 0), new Size(510, 510)));
        }

        #endregion
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
        private void textBox4Controller(string type, string message)
        {
            TextBox4.Text += type + message + "\r\n";//顯示訊息並換行
            TextBox4.SelectionStart = TextBox4.Text.Length; //游標移到最後
            TextBox4.ScrollToCaret(); //捲動到游標位置
        }

        private void systemTextController(string type, string message)
        {
            system_text.Text += type + message + "\r\n";//顯示訊息並換行
            system_text.SelectionStart = system_text.Text.Length; //游標移到最後
            system_text.ScrollToCaret(); //捲動到游標位置
        }

        #region 遊戲內容
        private void Plate_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox5.ReadOnly = true; // 玩家要下棋的時候禁止
            if (PlayChessEnable)
            {
                if (IsOver)
                {
                    return;
                }
                //Graphics g = Plate.CreateGraphics();
                //�u�n�ƹ��U�b�I�I�y�Ъ����t10�H���A���i�H���\�U��
                int x = (e.X - _plateXStart) % 50;
                int y = (e.Y - _plateYStart) % 50;

                if (x > 40)
                {
                    x = (e.X - _plateXStart) / 50 + 1; // index : 6 325 index 7 375
                    IsXok = true;
                }
                else if (x < 10)
                {
                    x = (e.X - _plateXStart) / 50;
                    IsXok = true;
                }

                if (y > 40)
                {
                    y = (e.Y - _plateYStart) / 50 + 1;
                    IsYok = true;
                }
                else if (y < 10)
                {
                    y = (e.Y - _plateYStart) / 50;
                    IsYok = true;
                }
                if (IsYok == true && IsXok == true) //點擊位置有沒有正確
                {
                    if (x >= 0 && x < 10 && y >= 0 && y < 10 && plate[x, y] == 0)
                    {

                        DrawChess(x, y, new Pen(Brushes.White), Brushes.White, 1);
                        // 我現在改成，我方就是使用白色

                        if (WinOrNot(x, y))
                        {
                            Send(User, "8");
                            // 可以設計跳出式視窗
                            MessageBox.Show("You win !!!\nPlease Click \"Reset\" Button to Rematch.");
                            Reset.Enabled = true;
                            ResetBoard();
                        }
                        else
                        {
                            Send(User + "|" + $"{x},{y}", "4");
                            TextBox5.ReadOnly = false; //可以傳訊息
                        }
                        PlayChessEnable = false;
                    }
                }
                else
                {
                    textBox4Controller("(無效)", "請點擊正確位置");
                }
                IsXok = false;
                IsYok = false;
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            Send(User, "7");
            ResetBoard();
            DrawPlate();
            Reset.Enabled = false;
        }
        private void ResetBoard()
        {
            for (int i = 0; i < plate.GetLength(0); i++)
            {
                for (int j = 0; j < plate.GetLength(1); j++)
                {
                    plate[i, j] = 0;
                }
            }
        }
        private bool WinOrNot(int x, int y) // 簡稱WON
        {
            return SubWON(x, y, 0, 1, 0) || SubWON(x, y, 1, 1, 0) || SubWON(x, y, 1, 0, 0)
                  || SubWON(x, y, 1, -1, 0) || SubWON(x, y, -1, -1, 0) || SubWON(x, y, 0, -1, 0)
                  || SubWON(x, y, -1, 1, 0) || SubWON(x, y, -1, 0, 0);
        }
        private bool SubWON(int x, int y, int xDir, int yDir, int cnt)
        {
            if (cnt == 5) return true;

            if (x < 0 || x >= 10 || y < 0 || y >= 10) return false;

            if (plate[x, y] == 1) return SubWON(x + xDir, y + yDir, xDir, yDir, cnt + 1);
            else return false;

            ////throw new Exception("SubWON");
        }

        #endregion

        #region InterNet Component

        private void Listen()
        {
            EndPoint ServerEP = (EndPoint)Client.RemoteEndPoint; //Server 的 EndPoint
            byte[] Byte = new byte[1023]; //接收用的 Byte 陣列
            int ByteLength = 0; //接收的位元組數目
            string Msg; //接收到的完整訊息
            string Cmd; //命令碼
            string Str; //訊息內容(不含命令碼)
            string[] splitter;
            bool endTrigger = true;
            while (endTrigger)//無限次監聽迴圈
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

                    system_text.Text = "";
                    TextBox4.Text = "";

                    button1.Enabled = true;//連線按鍵恢復可用
                    textBox1.Enabled = true;//可以改伺服器ip、port
                    textBox2.Enabled = true;
                    TextBox5.Enabled = false;
                    Reset.Enabled = false;

                    ResetBoard();
                    DrawPlate();

                    endTrigger = false;
                    break;
                    //Thread.Abort();//刪除執行緒，現在這個用不了
                }
                Msg = Encoding.Unicode.GetString(Byte, 0, ByteLength); //解讀完整訊息'
                //textBox4Controller("", Msg);
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
                        splitter = Str.Split("|");
                        systemTextController("(public)", splitter[0] + " by: " + splitter[1]);
                        break;
                    case "2"://接收私密訊息
                        systemTextController("(private)", Str);
                        break;
                    case "3"://來自server
                        String[] msg = Str.Split("|");
                        string prior = msg[0];
                        EnemyName = msg[1];
                        systemTextController("(News)", "Your enemy: " + EnemyName);
                        if (prior == "001")
                        {
                            draw(100);
                            textBox4Controller("(Process)", "You are First, It's Your Turn.");
                            PlayChessEnable = true;
                        }
                        else
                        {
                            draw(100);
                            textBox4Controller("(Process)", "You are Second, Wait");
                        }

                        break;
                    case "4": // 接收來自對方的訊息
                        String[] Coordinate = Str.Split(",");
                        int enX = int.Parse(Coordinate[0]);
                        int enY = int.Parse(Coordinate[1]);

                        DrawChess(enX, enY, new Pen(Brushes.Black), Brushes.Black, 2);
                        plate[enX, enY] = 2;

                        textBox4Controller("(Process)", "It's Your Turn.");
                        PlayChessEnable = true;
                        break;

                    case "5": // Server說等待
                        //Graphics g = Plate.CreateGraphics();
                        //DrawAllChess(g);
                        textBox4Controller("(Process)", Str);
                        PlayChessEnable = false;
                        break;

                    case "6":
                        systemTextController("(Enemy):", Str);
                        break;

                    case "7":
                        textBox4Controller("", Str);
                        PlayChessEnable = false;
                        break;

                    case "8":
                        textBox4Controller("(News)", "Enemy Win!!!");
                        MessageBox.Show("You loss !!!\nPlease Click \"Reset\" Button to Go Next Game");
                        Reset.Enabled = true;
                        PlayChessEnable = false;
                        // 要做一點事情

                        break;

                    case "9":
                        textBox4Controller("(News)", "Your Enemy has leave，Already push you to the waiting Queue.");
                        PlayChessEnable = false;
                        ResetBoard();
                        DrawPlate();
                        break;

                }
            }
        }
        private void Send(string Str, string type = "")
        {
            byte[] B = Encoding.Unicode.GetBytes(type + Str); //翻譯文字為Byte陣列
            Client.Send(B, 0, B.Length, SocketFlags.None); //使用連線物件傳送資料
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; //忽略跨執行緒錯誤
            if (ReferenceEquals(User, null)) User = textBox3.Text;//使用者名稱, 代表打上去按下按鍵後就沒有辦法改名了
            if (setPlayerName && setPortNumber && setServerIp)
            {
                //這邊要做除錯
                string IP = textBox1.Text;//伺服器IP
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

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false; //禁止再改名
                    button1.Enabled = false;
                    TextBox5.Enabled = true; // 開放對話

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
            else
            {
                textBox4Controller("(系統)", "無效輸入，填寫完整!!!");
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (button1.Enabled == false)
            {
                try
                {
                    Send(User, "9"); //傳送自己的離線訊息給伺服器
                }
                catch (Exception ex)
                {
                    throw;
                }

                Client.Close(); //關閉網路通訊器
            }
        }

        #endregion

        private void TextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TextBox5.Text != "")
            {
                if (TextBox5.Text[0] == '/')
                {
                    try
                    {
                        string[] splitter = TextBox5.Text.Split(" ");
                        string another = splitter[0].Substring(1);
                        string msg = TextBox5.Text.Substring(splitter[0].Length + 1);
                        if (another == "1") // 廣播
                        {
                            Send(msg + "|" + User, "1");
                        }
                        else
                        {
                            Send(TextBox5.Text + "|" + User);
                            systemTextController($"to:{another} ", msg);
                        }
                        TextBox5.Clear();
                    }
                    catch
                    {
                        systemTextController("(System)", "Wrong Format，cannot Send!!!");
                    }
                }
                else
                {
                    systemTextController($"to:敵人 ", TextBox5.Text);
                    Send(User + "|" + TextBox5.Text, "6");
                    TextBox5.Clear();
                }
            }
        }
    }
}