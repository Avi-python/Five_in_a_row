using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GobangLibrary
{
    abstract public class Player
    {
        protected int? _id;
        private static int idCounter = 0;
        public int ID { get { return _id ?? 0; } } // 如果是Null應該由我們來處理
        protected string? _name;
        public string Name
        {
            get
            {
                if (ReferenceEquals(_name, null)) throw new NullReferenceException("Name");
                else return _name;
            }
            set
            {
                _name = value;
            }
        }

        protected Player() { _id = ++idCounter; }
        protected Player(string name) : this() { _name = name; }

        public abstract int input();


    }

}
