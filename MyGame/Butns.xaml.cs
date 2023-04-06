using System;
using System.Windows;
using System.Windows.Controls;

namespace MyGame
{
    /// <summary>
    /// Логика взаимодействия для Butns.xaml
    /// </summary>
    public partial class Butns : StackPanel
    {
        public MainWindow parent { get; set; };
        public Butns()
        {
            
            InitializeComponent();
        }
        private void Click100(object sender, RoutedEventArgs e)
        {
           
            var btn = sender as Button;
            if (btn == null) return;
            int point = Convert.ToInt32(btn.Content);
            MessageBox.Show(btn.DataContext.ToString());

            BtnsListView.ItemsSource = твой_Список;
                 
        }
       
            
        
    }
}
