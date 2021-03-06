﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TicTacToeFinalWPF
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }



        public bool bot_stop = false;
        string whichplayer = "X";
        int drawcounter = 0, has_someone_won = 0;
        public List<int> list = new List<int>(new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99 });
        int bot_field_choice;
        public List<int> bot_choice_list = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
        public Random r = new Random();


        //Method for Bot's turn (called after every turn of the player), determines random field that is not taken, sets that up for the Bot and checks if someone won.
        public void Bot_turn(int bot_field_choice)
        {
            this.Title = "Player X:";
            int index = r.Next(bot_choice_list.Count);
            bot_field_choice = bot_choice_list[index];

            if (bot_field_choice == 0) { bot_choice_list.Remove(0);  button1.Content = "O"; }
            if (bot_field_choice == 1) { bot_choice_list.Remove(1); button2.Content = "O"; }
            if (bot_field_choice == 2) { bot_choice_list.Remove(2); button3.Content = "O"; }
            if (bot_field_choice == 3) { bot_choice_list.Remove(3); button4.Content = "O"; }
            if (bot_field_choice == 4) { bot_choice_list.Remove(4); button5.Content = "O"; }
            if (bot_field_choice == 5) { bot_choice_list.Remove(5); button6.Content = "O"; }
            if (bot_field_choice == 6) { bot_choice_list.Remove(6); button7.Content = "O"; }
            if (bot_field_choice == 7) { bot_choice_list.Remove(7); button8.Content = "O"; }
            if (bot_field_choice == 8) { bot_choice_list.Remove(8); button9.Content = "O"; }

            list[bot_field_choice] = 2;
            has_someone_won = Has_someone_won(list);
            if (has_someone_won == 0)
            {
                drawcounter += 1;
                whichplayer = "X";
                Check_draw(drawcounter);

            }
            else { Winmsg(whichplayer); }
        }


        //Event handler for when button/field 1 is clicked, sets that field up for that player, checks if someone won and calls the Bot's turn.
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bot_choice_list.Remove(0);
            this.Title = "Player O:";
            if (button1.Content == "")
            {
                button1.Content = "X";
                list[0] = 1;
                has_someone_won = Has_someone_won(list);

                if (has_someone_won == 0)
                {
                    drawcounter += 1;
                    whichplayer = "O";
                    Check_draw(drawcounter);
                    
                }
                else { Winmsg(whichplayer);  }
            }
            else { MessageBox.Show("Field already taken !"); whichplayer = "X"; }
            if (bot_stop) { }
            else { Bot_turn(bot_field_choice); }
            
            

        }

        //Event handler for when button/field 2 is clicked, sets that field up for that player, checks if someone won and calls the Bot's turn.
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            bot_choice_list.Remove(1);
            this.Title = "Player O:";
            if (button2.Content == "")
            {
                button2.Content = "X";
                list[1] = 1;
                has_someone_won = Has_someone_won(list);

                if (has_someone_won == 0)
                {
                    drawcounter += 1;
                    whichplayer = "O";
                    Check_draw(drawcounter);
                    
                }
                else { Winmsg(whichplayer); }
            }
            else { MessageBox.Show("Field already taken !"); whichplayer = "X"; }
            if (bot_stop) { }
            else { Bot_turn(bot_field_choice); }
        }

        //Event handler for when button/field 3 is clicked, sets that field up for that player, checks if someone won and calls the Bot's turn.
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            bot_choice_list.Remove(2);
            this.Title = "Player O:";
            if (button3.Content == "")
            {
                button3.Content = "X";
                list[2] = 1;
                has_someone_won = Has_someone_won(list);
                if (has_someone_won == 0)
                {
                    drawcounter += 1;
                    whichplayer = "O";
                    Check_draw(drawcounter);
                    
                }
                else { Winmsg(whichplayer); }
            }
            else { MessageBox.Show("Field already taken !"); whichplayer = "X"; }
            if (bot_stop) { }
            else { Bot_turn(bot_field_choice); }
        }

        //Event handler for when button/field 4 is clicked, sets that field up for that player, checks if someone won and calls the Bot's turn.
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            bot_choice_list.Remove(3);
            this.Title = "Player O:";
            if (button4.Content == "")
            {
                button4.Content = "X";
                list[3] = 1;
                has_someone_won = Has_someone_won(list);
                if (has_someone_won == 0)
                {
                    drawcounter += 1;
                    whichplayer = "O";
                    Check_draw(drawcounter);
                    
                }
                else { Winmsg(whichplayer); }
            }
            else { MessageBox.Show("Field already taken !"); whichplayer = "X"; }
            if (bot_stop) { }
            else { Bot_turn(bot_field_choice); }
        }

        //Event handler for when button/field 5 is clicked, sets that field up for that player, checks if someone won and calls the Bot's turn.
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            bot_choice_list.Remove(4);
            this.Title = "Player O:";
            if (button5.Content == "")
            {
                button5.Content = "X";
                list[4] = 1;
                has_someone_won = Has_someone_won(list);
                if (has_someone_won == 0)
                {
                    drawcounter += 1;
                    whichplayer = "O";
                    Check_draw(drawcounter);
                    
                }
                else { Winmsg(whichplayer); }
            }
            else { MessageBox.Show("Field already taken !"); whichplayer = "X"; }
            if (bot_stop) { }
            else { Bot_turn(bot_field_choice); }
        }

        //Event handler for when button/field 6 is clicked, sets that field up for that player, checks if someone won and calls the Bot's turn.
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            bot_choice_list.Remove(5);
            this.Title = "Player O:";
            if (button6.Content == "")
            {
                button6.Content = "X";
                list[5] = 1;
                has_someone_won = Has_someone_won(list);
                if (has_someone_won == 0)
                {
                    drawcounter += 1;
                    whichplayer = "O";
                    Check_draw(drawcounter);
                    
                }
                else { Winmsg(whichplayer); }
            }
            else { MessageBox.Show("Field already taken !"); whichplayer = "X"; }
            if (bot_stop) { }
            else { Bot_turn(bot_field_choice); }
        }

        //Event handler for when button/field 7 is clicked, sets that field up for that player, checks if someone won and calls the Bot's turn.
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            bot_choice_list.Remove(6);
            this.Title = "Player O:";
            if (button7.Content == "")
            {
                button7.Content = "X";
                list[6] = 1;
                has_someone_won = Has_someone_won(list);
                if (has_someone_won == 0)
                {
                    drawcounter += 1;
                    whichplayer = "O";
                    Check_draw(drawcounter);
                    
                }
                else { Winmsg(whichplayer); }
            }
            else { MessageBox.Show("Field already taken !"); whichplayer = "X"; }
            if (bot_stop) { }
            else { Bot_turn(bot_field_choice); }
        }

        //Event handler for when button/field 8 is clicked, sets that field up for that player, checks if someone won and calls the Bot's turn.
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            bot_choice_list.Remove(7);
            this.Title = "Player O:";
            if (button8.Content == "")
            {
                button8.Content = "X";
                list[7] = 1;
                has_someone_won = Has_someone_won(list);
                if (has_someone_won == 0)
                {
                    drawcounter += 1;
                    whichplayer = "O";
                    Check_draw(drawcounter);
                    
                }
                else { Winmsg(whichplayer); }
            }
            else { MessageBox.Show("Field already taken !"); whichplayer = "X"; }
            if (bot_stop) { }
            else { Bot_turn(bot_field_choice); }
        }

        //Event handler for when button/field 9 is clicked, sets that field up for that player, checks if someone won and calls the Bot's turn.
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            bot_choice_list.Remove(8);
            this.Title = "Player O:";
            if (button9.Content == "")
            {
                button9.Content = "X";
                list[8] = 1;
                has_someone_won = Has_someone_won(list);
                if (has_someone_won == 0)
                {
                    drawcounter += 1;
                    whichplayer = "O";
                    Check_draw(drawcounter);
                    
                }
                else { Winmsg(whichplayer); }
            }
            else { MessageBox.Show("Field already taken !"); whichplayer = "X"; }
            if (bot_stop) {  }
            else { Bot_turn(bot_field_choice); }
        }


        //Method that checks if 9 turns were made and determines if the game ends as a draw.
        private void Check_draw(int drawcounter)
        {
            if (drawcounter >= 9)
            {
                bot_stop = true;
                MessageBox.Show("It's a draw !");
                this.Close();
            }
            else { }
        }


        //Method that checks if someone has won (compares status of the fields), called after every turn.
        public static int Has_someone_won(List<int> list)
        {
            if (list[0] == list[1] && list[1] == list[2]) { return 1; }
            else
            {
                if (list[3] == list[4] && list[4] == list[5]) { return 1; }
                else
                {
                    if (list[6] == list[7] && list[7] == list[8]) { return 1; }
                    else
                    {
                        if (list[0] == list[3] && list[3] == list[6]) { return 1; }
                        else
                        {
                            if (list[1] == list[4] && list[4] == list[7]) { return 1; }
                            else
                            {
                                if (list[2] == list[5] && list[5] == list[8]) { return 1; }
                                else
                                {
                                    if (list[0] == list[4] && list[4] == list[8]) { return 1; }
                                    else
                                    {
                                        if (list[2] == list[4] && list[4] == list[6]) { return 1; }
                                        else
                                        {
                                            return 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }



        //Method that outputs a winmessage for the player (or Bot) who won and closes the game window (while the menu window was left open), called whenever someone won the game.
        public void Winmsg(string whichplayer)
        {
            if (whichplayer == "X")
            {
                bot_stop = true;
                MessageBox.Show("Player X wins !");
                this.Close();
            }
            if (whichplayer == "O")
            {
                bot_stop = true;
                MessageBox.Show("Bot wins !");
                this.Close();
            }
        }
    }
}
