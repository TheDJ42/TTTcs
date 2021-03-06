﻿using System;
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
        int gameTurn = 0;
        int gamesLost = 0;
        string gameWinner = "";
        bool gameStatus = false;
        public MainWindow()
        {


            InitializeComponent();

            // Set Button Backgrounds to white
            game.Background = Brushes.White;
            game_1.Background = Brushes.White;
            game_2.Background = Brushes.White;
            game_3.Background = Brushes.White;
            game_4.Background = Brushes.White;
            game_5.Background = Brushes.White;
            game_6.Background = Brushes.White;
            game_7.Background = Brushes.White;
            game_8.Background = Brushes.White;

            //game.IsEnabled = false;
            //game_1.IsEnabled = false;
            //game_2.IsEnabled = false;
            //game_3.IsEnabled = false;
            //game_4.IsEnabled = false;
            //game_5.IsEnabled = false;
            //game_6.IsEnabled = false;
            //game_7.IsEnabled = false;
            //game_8.IsEnabled = false;

        }

        private void startGame_Click(object sender, RoutedEventArgs e)
        {
            xPlayerName = xPlayerNameText.Text;
            oPlayerName = oPlayerNameText.Text;
            //game.IsEnabled = true;
            //game_1.IsEnabled = true;
            //game_2.IsEnabled = true;
            //game_3.IsEnabled = true;
            //game_4.IsEnabled = true;
            //game_5.IsEnabled = true;
            //game_6.IsEnabled = true;
            //game_7.IsEnabled = true;
            //game_8.IsEnabled = true;
            xPlayerNameText.IsEnabled = false;
            oPlayerNameText.IsEnabled = false;
            playerName.Text = xPlayerNameText.Text + "'s Turn";
            startGame.IsEnabled = false;
            game.Content = "";
            game_1.Content = "";
            game_2.Content = "";
            game_3.Content = "";
            game_4.Content = "";
            game_5.Content = "";
            game_6.Content = "";
            game_7.Content = "";
            game_8.Content = "";
            //Resets the game round and sets the status of the game to true.
            gameTurn = 1;
            playerTurn = 0;
            gameStatus = true;
            //Easter Egg
            if (oPlayerNameText.Text == "Dylan" || oPlayerNameText.Text == "DJ")
            {
                playerTurn = 1;
                playerName.Text = "Welcome Back, " + oPlayerNameText.Text;
            }
        }
        private void XO(Button btn)
        {
            if (gameStatus == true)
            {   if ((string)(btn.Content) == "")
                {
                    if (playerTurn == 0)
                    {
                        playerName.Text = oPlayerNameText.Text + "'s Turn";
                        btn.Content = "X";
                        playerTurn = 1;
                        gameTurn++;
                    }

                    else
                    {
                        playerName.Text = xPlayerNameText.Text + "'s Turn";
                        btn.Content = "O";
                        playerTurn = 0;
                        gameTurn++;
                    }
                }
            }
        }
     

        private void game_Click(object sender, RoutedEventArgs e)
        {
            XO(game);
            EndGame(game);
        }
        private void game_1_Click(object sender, RoutedEventArgs e)
        {
            XO(game_1);
            EndGame(game);
        }
        private void game_2_Click(object sender, RoutedEventArgs e)
        {
            XO(game_2);
            EndGame(game);
        }
        private void game_3_Click(object sender, RoutedEventArgs e)
        {
            XO(game_3);
            EndGame(game);
        }
        private void game_4_Click(object sender, RoutedEventArgs e)
        {
            XO(game_4);
            EndGame(game);
        }
        private void game_5_Click(object sender, RoutedEventArgs e)
        {
            XO(game_5);
            EndGame(game);
        }
        private void game_6_Click(object sender, RoutedEventArgs e)
        {
            XO(game_6);
            EndGame(game);
        }
        private void game_7_Click(object sender, RoutedEventArgs e)
        {
            XO(game_7);
            EndGame(game);
        }
        private void game_8_Click(object sender, RoutedEventArgs e)
        {
            XO(game_8);
            EndGame(game);
        }

        private void EndGame(Button btn)
        {
            if (gameTurn >= 5)
            {
                if (game_1.Content == game.Content && game_1.Content == game_2.Content && (string)game.Content != "")
                {
                    WhoAmI(game_1);
                    GameWin(game_1, game, game_2);
                }
                if (game_4.Content == game_3.Content && game_4.Content == game_5.Content && (string)game_4.Content != "")
                {
                    WhoAmI(game_4);
                    GameWin(game_4, game_3, game_5);
                }
                if (game_3.Content == game.Content && game_3.Content == game_6.Content && (string)game.Content != "")
                {
                    WhoAmI(game_3);
                    GameWin(game_3, game, game_6);
                }
                if (game_7.Content == game_6.Content && game_7.Content == game_8.Content && (string)game_6.Content != "")
                {
                    WhoAmI(game_7);
                    GameWin(game_7, game_6, game_8);
                }
                if (game_4.Content == game_1.Content && game_4.Content == game_7.Content && (string)game_1.Content != "")
                {
                    WhoAmI(game_4);
                    GameWin(game_4, game_1, game_7);
                }
                if (game_4.Content == game.Content && game_4.Content == game_8.Content && (string)game.Content != "")
                {
                    WhoAmI(game_4);
                    GameWin(game_4, game, game_8);
                }
                if (game_2.Content == game_4.Content && game_4.Content == game_6.Content && (string)game_4.Content != "")
                {
                    WhoAmI(game_4);
                    GameWin(game_4, game_2, game_6);
                }
                else if (gameTurn >= 9)
                {
                    gameStatus = false;
                    startGame.IsEnabled = true;
                    playerName.Text = "You have lost!";
                    xPlayerNameText.IsEnabled = true;
                    oPlayerNameText.IsEnabled = true;
                    gamesLost++;
                    
                }

            }

        }

        private void WhoAmI(Button btn)
        {
            if ((string)(btn.Content) == "X")
            {
                gameWinner = xPlayerNameText.Text + " is the Winner!";
                playerName.Text = gameWinner;

            }
            else
            {
                gameWinner = oPlayerNameText.Text + " is the Winner!";
                playerName.Text = gameWinner;
            }
                
        }

        private void GameWin(Button btn, Button btn1, Button btn2)
        {
            btn.Background = Brushes.Crimson;
            btn1.Background = Brushes.Crimson;
            btn2.Background = Brushes.Crimson;
            playerName.Text = gameWinner;
            startGame.IsEnabled = true;
            gameStatus = false;
            startGame.IsEnabled = true;
            xPlayerNameText.IsEnabled = true;
            oPlayerNameText.IsEnabled = true;
        }

        private void NameFocus(object sender, RoutedEventArgs e)
        {
            var theBox = (TextBox)sender;
            if (theBox.Text == "Enter your name" || theBox.Text != "")
            { theBox.Text = ""; }

        }
    }
}
