﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF
{
    /// <summary>
    /// Interaction logic for TicTacToe.xaml
    /// </summary>
    public partial class TicTacToe : Page
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
        private void NotionButton_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://mercantec.notion.site/tic-tac-toe";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Der opstod en fejl ved åbning af linket: " + ex.Message);
            }
        }
    }
}
