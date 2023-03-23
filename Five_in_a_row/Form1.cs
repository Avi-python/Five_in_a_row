using GobangLibrary;
using GobangLibrary.Extension;
using System.Net;

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
        private void login_Click(object sender, EventArgs e)
        {
            if (setPlayerName && setPortNumber && setServerIp)
            {
                // 嘗試連接
                int tmpPort;
                IPAddress tmpServerIp;
                if (!textBox2.Text.ToPort(out tmpPort))
                {
                    system_text.Text = "無效埠口";
                }
                if(!textBox1.Text.ToServerIP(out tmpServerIp))
                {
                    system_text.Text = "無效IP";
                }

                if (GM.setUp(tmpServerIp, tmpPort, textBox2.Text))
                {
                    draw();
                    IsConnected = true;
                    Reset.Enabled = true; // true 打開 reset button，應該要在正式開始遊戲的時候才enable
                    system_text.Text = "登入伺服器";
                }
            }
            else
            {
                system_text.Text = "尚未輸入完全";
            }
        }
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
            else                     setServerIp = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //system_text.Text = textBox2.Text;
            if(textBox2.Text != "") setPortNumber = true;
            else                    setPortNumber = false; 
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //system_text.Text = textBox3.Text;
            // 可以設計更多，或許可以偵測名子對不對
            if (textBox3.Text != "") setPlayerName = true;
            else                     setPlayerName = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void system_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}