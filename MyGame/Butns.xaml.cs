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
        public MainWindow parent;
        public Butns()
        {         
            InitializeComponent();
            if (parent == null) return;
            var list = parent.ListView.ItemsSource.Cast<Question>().ToList();
            BtnsListView.ItemsSource = list;
        }
        private void Click100(object sender, RoutedEventArgs e)
        {
            
            var btn = sender as Button;
            if (btn == null) return;
            int point = Convert.ToInt32(btn.Content);
            MessageBox.Show(btn.DataContext.ToString());

            
        }
       
            
        
    }
}
