namespace MyGame
{
    class Category
    {
        private string _name;
        public Category(string name)
        {
            _name = name;
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
