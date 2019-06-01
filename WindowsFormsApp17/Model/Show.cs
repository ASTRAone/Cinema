using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17.Model
{
    public class Show
    {
        public int idShow { get; set; }
        public int idCinema { get; set; }
        public int idFoodRevenue { get; set; }
        public DateTime showStartTime { get; set; }
        public DateTime showEndTime { get; set; }
        public int occupiedPlaces { get; set; }
        public int profit { get; set; }
    }
}
