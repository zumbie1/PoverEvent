using ScoreV2.Models;
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
        Team t;
        MainWindow parent;
        public Control(MainWindow p)
        {
            InitializeComponent();
            parent = p;
            t = new Team();
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
  
        public void AddPlayer()
        {
 
            string name = txtName.Text; 
            int team = Int32.Parse(txtTeamNum.Text);
            Person add = new Person() { Name = name, TeamNumb = team};
            Team.personer.Add(add);
            updateCount();
            listPlayer.ItemsSource = null;
            listPlayer.ItemsSource = Team.personer;
        }
         private void updateCount()
        {         
                lbTeam1.Content = Team.getCountTeam(1);
                lbTeam2.Content = Team.getCountTeam(2);
                lbTeam3.Content = Team.getCountTeam(3);
                lbTeam4.Content = Team.getCountTeam(4);
                lbTeam5.Content = Team.getCountTeam(5);
                lbTeam6.Content = Team.getCountTeam(6);
                lbTeam7.Content = Team.getCountTeam(7);
                lbTeam8.Content = Team.getCountTeam(8);
                lbTeam9.Content = Team.getCountTeam(9);
                lbTeam10.Content = Team.getCountTeam(10);
                lbResultat.Content = Team.personer.Count;
        }
        
        // metode sletter en spiller
        public void RemovePlayer()
        {
            Person p = listPlayer.SelectedItem as Person;
            int holdNummer = p.TeamNumb;
            Team.personer.Remove(p);
            updateCount();
            listPlayer.ItemsSource = null;
            listPlayer.ItemsSource = Team.personer;
        }
        //  KNAP  tilføjer en spiller
        private void cmdAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer();
        }
        //   KNAP  sletter en spiller
        private void cmdDeletePlayer_Click(object sender, RoutedEventArgs e)
        {
            RemovePlayer();
        }
        //tilføjer en aktivitet
        private void cmdAddA_Click(object sender, RoutedEventArgs e)
        {
            string s = listEvent.SelectedItems.ToString();
            Event ev = new Event()
            {
                Name = s, EventType = 1
            };
            parent.addEvent(ev);
        }
    }
}
