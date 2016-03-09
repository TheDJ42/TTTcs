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
        string oPlayerName;
        int playerTurn = 0;
        string xPlayerName;   

        public MainWindow()
        {


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
            xPlayerName = xPlayerNameText.Text;
            oPlayerName = oPlayerNameText.Text;
            game.IsEnabled = true;
            game_1.IsEnabled = true;
            game_2.IsEnabled = true;
            game_3.IsEnabled = true;
            game_4.IsEnabled = true;
            game_5.IsEnabled = true;
            game_6.IsEnabled = true;
            game_7.IsEnabled = true;
            game_8.IsEnabled = true;
            xPlayerNameText.IsEnabled = false;
            oPlayerNameText.IsEnabled = false;
            playerName.Text = xPlayerNameText.Text + "'s Turn";

        }
        private void XO(Button btn)
        {
            if ((string)(btn.Content) == "") 
            {
                if (playerTurn == 0) 
                {
                    playerName.Text = oPlayerNameText.Text + "'s Turn";
                    btn.Content = "X";
                    playerTurn = 1;
                 }
      
                else 
                {
                    playerName.Text = xPlayerNameText.Text + "'s Turn";
                    btn.Content = "O";
                    playerTurn = 0;
                }
            }
        }
     

        private void game_Click(object sender, RoutedEventArgs e)
        {
            XO(game);
        }
        private void game_1_Click(object sender, RoutedEventArgs e)
        {
            XO(game_1);
        }
        private void game_2_Click(object sender, RoutedEventArgs e)
        {
            XO(game_2);
        }
        private void game_3_Click(object sender, RoutedEventArgs e)
        {
            XO(game_3);
        }
        private void game_4_Click(object sender, RoutedEventArgs e)
        {
            XO(game_4);
        }
        private void game_5_Click(object sender, RoutedEventArgs e)
        {
            XO(game_5);
        }
        private void game_6_Click(object sender, RoutedEventArgs e)
        {
            XO(game_6);
        }
        private void game_7_Click(object sender, RoutedEventArgs e)
        {
            XO(game_7);
        }
        private void game_8_Click(object sender, RoutedEventArgs e)
        {
            XO(game_8);
        }

     

        private void NameFocus(object sender, RoutedEventArgs e)
        {
            var theBox = (TextBox)sender;
            if (theBox.Text == "Enter your name")
            { theBox.Text = " "; }

        }
    }
}
