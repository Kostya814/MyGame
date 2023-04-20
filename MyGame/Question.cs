using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Question
    {
        private string _question;
        private string _answer;
        private bool _isAnswered;
        private int _skores;
        private Category _category;
        public Question(string question, string answer,Category category)
        { 
            _question = question;
            _answer = answer;
            _category = category;
            _skores = 100;
            _isAnswered = false;
        }
        public Category Category 
        { 
            get => _category;  
        }

        public string Vopros => _question;

        public Question Current => this;
        public bool IsAnswered 
        { 
            get => _isAnswered;
            set => _isAnswered = value; 
        }

        
        public int Scores
        { 
            get=> _skores;
            set => _skores = value;
        }
    }
}
