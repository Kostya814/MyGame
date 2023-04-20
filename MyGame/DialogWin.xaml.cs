using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyGame
{
    /// <summary>
    /// Логика взаимодействия для DialogWin.xaml
    /// </summary>
    public partial class DialogWin : Window
    {
        Question Question { get; set; }
        public DialogWin(Question question)
        {
            InitializeComponent();
            Question = question;
            QuestionText.Text = Question.Vopros;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
