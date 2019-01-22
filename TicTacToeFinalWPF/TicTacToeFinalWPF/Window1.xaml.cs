using System;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }


        string whichplayer = "X";
        int drawcounter = 0, has_someone_won = 0;
        public List<int> list = new List<int>(new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99 });

        


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            switch (whichplayer)
            {
                case "X":
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
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "X"; break; }
                case "O":
                    this.Title = "Player X:";
                    if (button1.Content == "")
                    {
                        button1.Content = "O";
                        list[0] = 2;
                        has_someone_won = Has_someone_won(list);

                        if (has_someone_won == 0)
                        {
                            drawcounter += 1;
                            whichplayer = "X";
                            Check_draw(drawcounter);
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "O"; break; }
            }
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            switch (whichplayer)
            {
                case "X":
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
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "X"; break; }
                case "O":
                    this.Title = "Player X:";
                    if (button2.Content == "")
                    {
                        button2.Content = "O";
                        list[1] = 2;
                        has_someone_won = Has_someone_won(list);

                        if (has_someone_won == 0)
                        {
                            drawcounter += 1;
                            whichplayer = "X";
                            Check_draw(drawcounter);
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "O"; break; }
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            switch (whichplayer)
            {
                case "X":
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
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "X"; break; }
                case "O":
                    this.Title = "Player X:";
                    if (button3.Content == "")
                    {
                        button3.Content = "O";
                        list[2] = 2;
                        has_someone_won = Has_someone_won(list);
                        if (has_someone_won == 0)
                        {
                            drawcounter += 1;
                            whichplayer = "X";
                            Check_draw(drawcounter);
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "O"; break; }
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            switch (whichplayer)
            {
                case "X":
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
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "X"; break; }
                case "O":
                    this.Title = "Player X:";
                    if (button4.Content == "")
                    {
                        button4.Content = "O";
                        list[3] = 2;
                        has_someone_won = Has_someone_won(list);
                        if (has_someone_won == 0)
                        {
                            drawcounter += 1;
                            whichplayer = "X";
                            Check_draw(drawcounter);
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "O"; break; }
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            switch (whichplayer)
            {
                case "X":
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
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "X"; break; }
                case "O":
                    this.Title = "Player X:";
                    if (button5.Content == "")
                    {
                        button5.Content = "O";
                        list[4] = 2;
                        has_someone_won = Has_someone_won(list);
                        if (has_someone_won == 0)
                        {
                            drawcounter += 1;
                            whichplayer = "X";
                            Check_draw(drawcounter);
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "O"; break; }
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            switch (whichplayer)
            {
                case "X":
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
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "X"; break; }
                case "O":
                    this.Title = "Player X:";
                    if (button6.Content == "")
                    {
                        button6.Content = "O";
                        list[5] = 2;
                        has_someone_won = Has_someone_won(list);
                        if (has_someone_won == 0)
                        {
                            drawcounter += 1;
                            whichplayer = "X";
                            Check_draw(drawcounter);
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "O"; break; }
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            switch (whichplayer)
            {
                case "X":
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
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "X"; break; }
                case "O":
                    this.Title = "Player X:";
                    if (button7.Content == "")
                    {
                        button7.Content = "O";
                        list[6] = 2;
                        has_someone_won = Has_someone_won(list);
                        if (has_someone_won == 0)
                        {
                            drawcounter += 1;
                            whichplayer = "X";
                            Check_draw(drawcounter);
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "O"; break; }
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            switch (whichplayer)
            {
                case "X":
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
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "X"; break; }
                case "O":
                    this.Title = "Player X:";
                    if (button8.Content == "")
                    {
                        button8.Content = "O";
                        list[7] = 2;
                        has_someone_won = Has_someone_won(list);
                        if (has_someone_won == 0)
                        {
                            drawcounter += 1;
                            whichplayer = "X";
                            Check_draw(drawcounter);
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "O"; break; }
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            switch (whichplayer)
            {
                case "X":
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
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "X"; break; }
                case "O":
                    this.Title = "Player X:";
                    if (button9.Content == "")
                    {
                        button9.Content = "O";
                        list[8] = 2;
                        has_someone_won = Has_someone_won(list);
                        if (has_someone_won == 0)
                        {
                            drawcounter += 1;
                            whichplayer = "X";
                            Check_draw(drawcounter);
                            break;
                        }
                        else { Winmsg(whichplayer); break; }
                    }
                    else { MessageBox.Show("Field already taken !"); whichplayer = "O"; break; }
            }
        }


        private void Check_draw(int drawcounter)
        {
            if (drawcounter >= 9)
            {
                MessageBox.Show("It's a draw !");
                this.Close();
            }
            else {  }
        }



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




        public void Winmsg(string whichplayer)
        {
            if (whichplayer == "X")
            {
                MessageBox.Show("Player X wins !");
                this.Close();
            }
            if (whichplayer == "O")
            {
                MessageBox.Show("Player O wins !");
                this.Close();
            }
        }



    }
}
