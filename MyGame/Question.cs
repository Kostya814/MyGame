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
        private bool _isAnswered;

        private Category _category;
        public Question(string question, string answer,Category category)
        { 
            _question = question;
            _answer = answer;
            _category = category;
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

        public override string ToString()
        {
            return $"Вопрос: {_question} " + $"Ответ: {_answer}";
        }
    }
}
