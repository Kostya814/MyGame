using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace MyGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Question> Cat { get; set; }
        private List<Player> Players { get; set; }
        public MainWindow()
        {
            Players = new List<Player>()
            {
                new Player("Костя"),
                new Player("Витя"),
                new Player("Дима")
            };
            Players[0].Points = 100;
           

            Cat = new List<Question>()
            {
                new Question("ASDasd","asdasd",new Category("Вопросы для взрослых")),
                new Question("КАк дела ","asdasd",new Category("Вопросы для взрослых")),
                new Question("What","asdasd",new Category("Вопросы для взрослых")),
                new Question("Вопрос","asdasd",new Category("Вопросы для взрослых")),
                new Question("Дитя","asdasd",new Category("Вопросы для взрослых")),

                new Question("ASDasd","asdasd",new Category("О тебе")),
                new Question("КАк дела ","asdasd",new Category("О тебе")),
                new Question("What","asdasd",new Category("О тебе")),
                new Question("Вопрос","asdasd",new Category("О тебе")),
                new Question("Дитя","asdasd",new Category("О тебе")),

                new Question("ASDasd","asdasd",new Category("Название предмета")),
                new Question("КАк дела ","asdasd",new Category("Название предмета")),
                new Question("What","asdasd",new Category("Название предмета")),
                new Question("Вопрос","asdasd",new Category("Название предмета")),
                new Question("Дитя","asdasd",new Category("Название предмета")),

                new Question("ASDasd","asdasd",new Category("О детях")),
                new Question("КАк дела ","asdasd",new Category("О детях")),
                new Question("What","asdasd",new Category("О детях")),
                new Question("Вопрос","asdasd",new Category("О детях")),
                new Question("Дитя","asdasd",new Category("О детях")),

                new Question("ASDasd","asdasd",new Category("О Нарковтиках")),
                new Question("КАк дела ","asdasd",new Category("О Нарковтиках")),
                new Question("What","asdasd",new Category("О Нарковтиках")),
                new Question("Вопрос","asdasd",new Category("О Нарковтиках")),
                new Question("Дитя","asdasd",new Category("О Нарковтиках")),
            };
            Sort();
            InitializeComponent();


            
            ListView.ItemsSource = Cat;
        }
        private List<Question> list1 { get; set; }
        private List<Question> list2 { get; set; }
        private List<Question> list3 { get; set; }
        private List<Question> list4 { get; set; }
        private List<Question> list5 { get; set; }
        void Sort()
        {
            list1 = Cat.Where(u => u.Category.Name == "Вопросы для взрослых").ToList();
            list2 = Cat.Where(u => u.Category.Name == "О тебе").ToList();
            list3 = Cat.Where(u => u.Category.Name == "Название предмета").ToList();
            list4 = Cat.Where(u => u.Category.Name == "О детях").ToList();
            list5 = Cat.Where(u => u.Category.Name == "О Нарковтиках").ToList();
        }

    }
}
