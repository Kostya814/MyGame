using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MyGame
{
    /// <summary>
    /// Логика взаимодействия для Butns.xaml
    /// </summary>
    public partial class Butns : StackPanel
    {
        public MainWindow parent = (MyGame.MainWindow)App.Current.MainWindow;
        public Butns()
        {         
            InitializeComponent();
            if (parent == null) return;
            Category cat = this.DataContext as Category;
            //MessageBox.Show(cat.Name);    
            
        }
        private void Click100(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;
            int point = Convert.ToInt32(btn.Content);

            //DialogWindow dialog = new DialogWindow();
            //dialog.Owner = Application.Current.MainWindow;
            //dialog.Show();


        }
       
            
        
    }
}
