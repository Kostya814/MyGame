using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Player
    {
        private string _name;
        private int _points;
        private bool _active;
        public Player(string Name)
        { 
            _name = Name;
            _points = 0;
            _active = false;
        }
        public bool IsActive
        { 
            get => _active;
            set => _active = value;
        }
        public string Name
        {
            get => _name;
        }
        public int Points
        { 
            get => _points; 
            set => _points = value;
        }
    }
}
