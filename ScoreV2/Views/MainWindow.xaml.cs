using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ScoreV2.Views;

namespace ScoreV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int fodScore1 = 0;
        public int fodSScore1 = 0;
        public int fodScore2 = 0;
        public int fodSScore2 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void loadT1()
        {
            int res1;
            res1 = fodScore1 + fodSScore1;
            team1Res.Content = res1;
        }

        public void loadST1()
        {
            int res1;
            res1 = fodScore1 + fodSScore1;
            team1Res.Content = res1;
        }
        public void loadT2()
        {
            int res2;
            res2 = fodScore2 + fodSScore2;
            team2Res.Content = res2;
        }


        private void team1FodP_Click(object sender, RoutedEventArgs e)
        {
            fodScore1++;
            team1Fod.Content = fodScore1;
            loadT1();
        }

        private void team1FodM_Click(object sender, RoutedEventArgs e)
        {
            fodScore1--;
            team1Fod.Content = fodScore1;
            loadT1();
        }

        private void team1FodSP_Click(object sender, RoutedEventArgs e)
        {
            fodSScore1++;
            team1FodS.Content = fodSScore1;
            loadT1();
        }

        private void team1FodSM_Click(object sender, RoutedEventArgs e)
        {
            fodSScore1--;
            team1FodS.Content = fodSScore1;
            loadT1();
        }

        private void team2FodP_Click(object sender, RoutedEventArgs e)
        {
            fodScore2++;
            team2Fod.Content = fodScore2;
            loadT2();
        }

        private void team2FodM_Click(object sender, RoutedEventArgs e)
        {
            fodScore2--;
            team2Fod.Content = fodScore2;
            loadT2();
        }

        private void team2FodSP_Click(object sender, RoutedEventArgs e)
        {
            fodSScore2++;
            team2Fods.Content = fodSScore2;
            loadT2();
        }

        private void team2FodSM_Click(object sender, RoutedEventArgs e)
        {
            fodSScore2--;
            team2Fods.Content = fodSScore2;
            loadT2();
        }

        private void lbControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Control c = new Control();
            c.Show();
        }

        private void team1Tyr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TyrScore ts = new TyrScore();
            ts.Show();
        }
    }
}
