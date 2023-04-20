using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private Player CurrentPlayer { get; set; }
        public MainWindow()
        {
            Players = new List<Player>()
            {
                new Player("Костя"),
                new Player("Дима"),
                new Player("Слава")
            };
           
            Players[0].IsActive = true;
            

            Category Cat1 = new Category("НАДЕЖДА");
            Cat1.qust = new List<Question>()
            {
                new Question("Эти две сестры – неизменные спутницы надежды.","Вера и Любовь",Cat1,100),
                new Question("Именно он командовал парусником «Надежда» в первой русской кругосветной экспедиции.","Крузенштерн",Cat1,200),
                new Question("Она написала музыку к песне Надежда.","Александра Пахмутова",Cat1,300),
                new Question("В этом ящике Надежда оставалась на самом дне."," В ящике Пандоры.",Cat1, 400),
                new Question("Эта Надежда была женой вождя мирового пролетариата.",".",Cat1, 500)
            };
            Category Cat2 = new Category("ЧЕРЕПАХИ");
            Cat2.qust = new List<Question>()
            {
                new Question("Эту черепаху воплотила на экране Рина Зеленая.","Черепаху Тартилу.",Cat2,100),
                new Question("С этими травоядными млекопитающими сравнивают самых больших черепах.","со слонами",Cat2, 200),
                new Question("При помощи этого римские легионеры легко превращались в «черепах».","при помощи щитов.",Cat2, 300),
                new Question("Так называется однорядная гармонь, названная в честь города Череповец.","черепашка",Cat2, 400),
                new Question("Так звали черепашек-ниндзя.","Леонардо, Рафаэль, Донателло, Микеланджело.",Cat2, 500)
            };
            Category Cat3 = new Category("УТРО, ВЕЧЕР, ДЕНЬ, НОЧЬ.");
            Cat3.qust = new List<Question>()
            {
                new Question("Утро + вечер + день + ночь = ?","сутки",Cat3, 100),
                new Question("Закончите русскую пословицу, которая начинается словами: «Трава соломы зеленее»…","утро вечере мудренее.",Cat3, 100),
                new Question("Когда высота солнца над горизонтом максимальна, то это день…","летнего солнцестояния.",Cat3, 100),
                new Question("Именно этот итальянец изваял скульптурную композицию «Утро. Вечер. День. Ночь»","Микеланджело.",Cat3, 100),
                new Question("Именно так В. Суворов назвал день когда, по его мнению, должен был начаться Великий «освободительный» поход на Запад?","«День «М»»",Cat3, 100)
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
            Check();
            categoriesList.ItemsSource = Cat;
            Update();
        }
        void Check()
        {
            CurrentPlayer = Players.Find(u => u.IsActive == true);
            ListPlayers.SelectedItem = CurrentPlayer;



        }
        void Update()//Длжно данные обновлять но что- то не так
        {
            ListPlayers.DataContext = Players;
            ListPlayers.Items.Refresh();
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

            
            if (dialogWin.ShowDialog() == true)
            {
                CurrentPlayer.Points += question.Scores;//Добавляю Диме баллов за ответ
            }
            else
            {
                CurrentPlayer.Points -= question.Scores;//Отнимаю Диме баллов за ответ
            }
            Update();
            Move();






        }
        void Move()
        {
            int i = Players.FindIndex(a => a.IsActive == true);
            if (i + 1 == Players.Count) Players[0].IsActive = true;
            else Players[i + 1].IsActive = true;
            CurrentPlayer.IsActive = false;
            Check();
        }

        private void AddPlay(object sender, RoutedEventArgs e)
        {
           AddPlayer add = new AddPlayer(new Player(""));
           add.ShowDialog();
           Players.Add(add.Player);
           Update();
        }
    }
}
