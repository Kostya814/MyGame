using System.Collections.Generic;
using System.Windows.Documents;

namespace MyGame
{
    public class Category
    {
        private string _name;
        public List <Question> qust { get; set; }
        public Category(string name)
        {
            _name = name;
            this.qust = new List<Question>();
        }
        public string Name 
        { 
            get 
            { 
                return _name; 
            } 
        }
    }
}
