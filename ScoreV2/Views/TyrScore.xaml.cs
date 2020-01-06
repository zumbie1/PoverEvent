using ScoreV2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ScoreV2.Views
{
    /// <summary>
    /// Interaction logic for TyrScore.xaml
    /// </summary>
    public partial class TyrScore : Window
    {
        Team t;
        public TyrScore()
        {
            InitializeComponent();
            t = new Team();
            load();
        }

        public void load()
        {
            listPersoner.ItemsSource = Team.personer;
        }

        private void cmdSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void listPersoner_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbPName.Content = listPersoner.SelectedItem.ToString();
        }
    }
}
