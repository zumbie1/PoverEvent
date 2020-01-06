using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScoreV2.Models
{
    public class Team
    {
        public static List<Person> personer = new List<Person>();

        public static int getCountTeam(int team)
        {
            return personer.Where(s => s.TeamNumb == team).Count();
        }

        public static List<Person> getTeamPlayers(int team)
        {
            return personer.Where(s => s.TeamNumb == team).ToList();
        }
    }
}
