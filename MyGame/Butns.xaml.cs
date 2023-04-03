using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для Butns.xaml
    /// </summary>
    public partial class Butns : StackPanel
    {
        private MainWindow parent;
        public Butns()
        {
            InitializeComponent();
        }

        public Butns(int points) : this()
        {

        }

        private void Click100(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
