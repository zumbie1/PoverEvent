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
using ScoreV2.Models;
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



        private void lbControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Views.Control c = new Views.Control(this);
            c.Show();
        }

        private void team1Tyr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TyrScore ts = new TyrScore();
            ts.Show();
        }

        public void addEvent(Event ev)
        {
            Label l = new Label();
            l.Content = ev.Name;
            col1.Children.Add(l);
            if(ev.EventType == 1)
            {
                Label lb = new Label();
                lb.Content = 0;
                lb.MouseLeftButtonUp += team1Tyr_MouseLeftButtonUp;
                col2.Children.Add(lb);
            }
            
        }
    }
}
