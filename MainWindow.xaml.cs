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

namespace TTTcs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        public MainWindow()
        {
            //string xPlayerName = xPlayerNameText.Text;
            //string oPlayerNmae = oPlayerNameText.Text;
           
            InitializeComponent();

            game.IsEnabled = false;
            game_1.IsEnabled = false;
            game_2.IsEnabled = false;
            game_3.IsEnabled = false;
            game_4.IsEnabled = false;
            game_5.IsEnabled = false;
            game_6.IsEnabled = false;
            game_7.IsEnabled = false;
            game_8.IsEnabled = false;


        }

        private void startGame_Click(object sender, RoutedEventArgs e)
        {

            game.IsEnabled = true;
            game_1.IsEnabled = true;
            game_2.IsEnabled = true;
            game_3.IsEnabled = true;
            game_4.IsEnabled = true;
            game_5.IsEnabled = true;
            game_6.IsEnabled = true;
            game_7.IsEnabled = true;
            game_8.IsEnabled = true;
        }
    }
}
