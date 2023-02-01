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
using masha;

namespace RoomExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room1 = new Room();
        Room room2 = new Room();
        Room rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpen1_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpen2.IsEnabled = true;
            room1.RoomLength = rnd.Next(2, 11);
            room1.RoomWidth = rnd.Next(2, 11);
            int numP = rnd.Next(1, 9);

            LabelLength1.Content = room1.RoomLength;
            LabelWindth1.Content = room1.RoomWidth;
            LabelNumPerson1.Content = numP;

            LabelPerimeter1.Content = room1.RoomPerimeter;
            LabelArea1.Content = room1.RoomArea;
            LabelPersonArea1.Content = room1.PersonArea(numP);
        }
    }
}
