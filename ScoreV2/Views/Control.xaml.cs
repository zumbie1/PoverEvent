using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ScoreV2.Views
{
    /// <summary>
    /// Interaction logic for Control.xaml
    /// </summary>
    public partial class Control : Window
    {

        MainWindow parent;
        public Control(MainWindow p)
        {
            InitializeComponent();
            parent = p;
            loadA();
        }
        
        public void loadA()
        {
            List<string> e = new List<string>();
            e.Add("Sumodragt");
            e.Add("Lokumsræs");
            e.Add("Bumper-ball");
            e.Add("Fodbold");
            e.Add("Gigant kuglespil");
            e.Add("racerbane");
            e.Add("Stafetpuslespil på specielle ski");
            e.Add("Rodeotyr");
            e.Add("Fire på stribe");
            e.Add("Hockey");
            e.Add("Fire på stribe med golf");
            e.Add("Fræk stafet");
            e.Add("Slå søm");
            e.Add("Lagkage med stødbånd eller promillebriller");
            e.Add("Fuglekast med promillebriller");
            e.Add("Sæbeboblestafet");
            e.Add("Human football");

            listEvent.ItemsSource = e;
        }

        public List<string> p = new List<string>();
        public List<string> emty = new List<string>();
  
        public void AddPlayer()
        {
 
            string name = txtName.Text; 
            int team = Int32.Parse(txtTeamNum.Text);
            string add = name + " " + team;

            p.Add(add);
            listPlayer.ItemsSource = emty;
            listPlayer.ItemsSource = p;

            if (team == 1)
            {
                
                lbTeam1.Content = "hold 1: " + team1;
            }
            else if (team == 2)
            {
                hold2++;
                lbTeam2.Content = "hold 2: " + hold2;
            }
            else if (team == 3)
            {
                hold3++;
                lbTeam3.Content = "hold 3: " + hold3;
            }
            else if (team == 4)
            {
                hold4++;
                lbTeam4.Content = "hold 4: " + hold4;
            }
            else if (team == 5)
            {
                hold5++;
                lbTeam5.Content = "hold 5: " + hold5;
            }
            else if (team == 6)
            {
                hold6++;
                lbTeam6.Content = "hold 6: " + hold6;
            }
            else if (team == 7)
            {
                hold7++;
                lbTeam7.Content = "hold 7: " + hold7;
            }
            else if (team == 8)
            {
                hold8++;
                lbTeam8.Content = "hold 8: " + hold8;
            }
            else if (team == 9)
            {
                hold9++;
                lbTeam9.Content = "hold 9: " + hold9;
            }
            else if (team == 10)
            {
                hold10++;
                lbTeam10.Content = "hold 10: " + hold10;
            }
            int alt = hold1 + hold2 + hold3 + hold4 + hold5 + hold6 + hold7 + hold8 + hold9 + hold10;
            string teams = "Hold " + team.ToString() + ": " + alt.ToString();
            lbResultat.Content = "spillere i alt: " + alt;
        }

        public void RemovePlayer()
        {
            p.Remove(listPlayer.SelectedItem.ToString());
            listPlayer.ItemsSource = emty;
            listPlayer.ItemsSource = p;

        }

        private void cmdAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer();
        }

        private void cmdDeletePlayer_Click(object sender, RoutedEventArgs e)
        {
            RemovePlayer();
        }

        private void cmdAddA_Click(object sender, RoutedEventArgs e)
        {
            string s = "test";
            parent.addEvent(s);
        }
    }
}
