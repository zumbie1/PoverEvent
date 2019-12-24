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

namespace ScoreV2
{
    /// <summary>
    /// Interaction logic for CreateTeam.xaml
    /// </summary>
    public partial class CreateTeam : Window
    {
        public CreateTeam()
        {
            InitializeComponent();
        }

        public List<string> membersList = new List<string>();

        private void cmdAdd_Click(object sender, RoutedEventArgs e)
        {
            membersList.Add ("txtName");
        }
    }
}
