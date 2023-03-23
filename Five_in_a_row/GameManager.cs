using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GobangLibrary;
using System.Net;
using TCP_Client;

namespace Five_in_a_row
{
    public class GameManager
    {
        private Table? _table; // 自己處理，Server只負責傳遞指令
        private Player? _playerMe;
        private List<Player> _playerOther;
        private Mark MyMark = Mark.None; // 我預設先放None, 會在Server端表示匹配之後，決定先後所發的訊息決定
        private string ServerIP; 
        private int PortNumber;
        private int[] PlayerSet = new int[2]; // {xRow, yCol}
        public GameManager(Form1 form1, Form2 form2) // 流程上，會在本地端建立一個GameManager，由他控制流程
        {
            // 先登入
            Application.Run(form1); 
            //InitLocalPlayer(); // 建立本地端玩家
            //InitTable(); // 建立一個table
        }

        public bool SetUp(IPAddress serverIp, int portNumber, string userName)
        {


            // Server發回開始的尋息後

            // 循環
            // 如果得到結束資訊就跳出。
            // 下棋，回傳資訊給Server。
            // 贏了要傳結束資訊。
            //
            return false;
        }

        private void loop()
        {

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

            if (Table.OutOfBound(x, y)) return false;

            if (_table[x, y] == MyMark) SubWON(x + xDir, y + yDir, xDir, yDir, cnt + 1);
            else return false;

            throw new Exception("SubWON");
        }

        private void InitTable()
        {
            _table = new Table();
        }
        public void InitLocalPlayer(string name)
        {
            // 會從介面那邊獲得輸入name的資訊
            // _playerMe = new Human(name);
            // _form1.textBox3.Focus();
            _playerMe = new Human(name);

        }

        private bool setTable(int x, int y) // 外面需要有流程說明Player下的正不正確，我的邊回傳的bool說明有沒有下成功
        {
            if (Table.OutOfBound(x, y)) throw new Exception("setTable: x, y");
            if (_table[x, y] != Mark.None) return false;
            else
            {
                _table[x, y] = MyMark;
                return true;
            }
        }



    }

}
