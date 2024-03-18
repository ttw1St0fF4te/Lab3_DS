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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Lab3_DS.MakdoknekDataSetTableAdapters;

namespace Lab3_DS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BookingTableAdapter booking = new BookingTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            ClientGrd.ItemsSource = booking.GetDataBy();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ClientGrd.Columns[0].Visibility = Visibility.Collapsed;
            ClientGrd.Columns[2].Visibility = Visibility.Collapsed;
            ClientGrd.Columns[3].Visibility = Visibility.Collapsed;
        }
    }
}
