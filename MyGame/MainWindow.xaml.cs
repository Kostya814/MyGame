using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MyGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Category> Cat { get; set; }
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


            Category Cat1 = new Category("Вопросы для взрослых");
            Cat1.qust = new List<Question>()
            {
                new Question("ASDasd","asdasd",Cat1,100),
                new Question("КАк дела ","asdasd",Cat1,200),
                new Question("What","asdasd",Cat1,300),
                new Question("Вопрос","asdasd",Cat1, 400),
                new Question("Дитя","asdasd",Cat1, 500)
            };
            Category Cat2 = new Category("Название предмета");
            Cat2.qust = new List<Question>()
            {
                new Question("ASDasd","asdasd",Cat2,100),
                new Question("КАк дела ","asdasd",Cat2, 100),
                new Question("What","asdasd",Cat2, 100),
                new Question("Вопрос","asdasd",Cat2, 100),
                new Question("Дитя","asdasd",Cat2, 100)
            };
            Category Cat3 = new Category("О детях");
            Cat3.qust = new List<Question>()
            {
                new Question("ASDasd","asdasd",Cat3, 100),
                new Question("КАк дела ","asdasd",Cat3, 100),
                new Question("What","asdasd",Cat3, 100),
                new Question("Вопрос","asdasd",Cat3, 100),
                new Question("Дитя","asdasd",Cat3, 100)
            };
            Category Cat4 = new Category("О Наркотиках");
            Cat4.qust = new List<Question>()
            {
                new Question("ASDasd","asdasd",Cat4, 100),
                new Question("КАк дела ","asdasd",Cat4, 100),
                new Question("What","asdasd",Cat4, 100),
                new Question("Вопрос","asdasd",Cat4, 100),
                new Question("Дитя","asdasd",Cat4, 100)
            };
            Category Cat5 = new Category("О тебе");
            Cat5.qust = new List<Question>()
            {
                new Question("ASDasd","asdasd",Cat5,100),
                new Question("КАк дела ","asdasd",Cat5, 100),
                new Question("What","asdasd",Cat5, 100),
                new Question("Вопрос","asdasd",Cat5, 100),
                new Question("Дитя","asdasd",Cat5, 100)
            };
            Cat = new List<Category>()
            {
                Cat1,Cat2,Cat3,Cat4,Cat5



            };

            InitializeComponent();


            ListPlayers.ItemsSource = Players;
            categoriesList.ItemsSource = Cat;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) return;

            Question question = button.DataContext as Question;
            if (question == null) return;
            DialogWin dialogWin = new DialogWin(question);
            question.IsAnswered = true;
            dialogWin.Owner = this;

            button.IsEnabled = false;
            //button.Background = new SolidColorBrush(Color.FromRgb(119, 161, 181));
            if (dialogWin.ShowDialog() == true)
            {

            }
            else
            {

            }

        }


    }
}
