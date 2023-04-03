using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Question
    {
        private string _question;
        private string _answer;
        private Category _category;
        public Question(string question, string answer,Category category)
        { 
            _question = question;
            _answer = answer;
            _category = category;
        }
    }
}
