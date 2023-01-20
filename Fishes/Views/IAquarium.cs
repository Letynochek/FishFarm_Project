using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishes.Views
{
    public interface IAquarium
    {
        public string Temperature1 { get; set; }
        public string Oxygen { get; set; }
        public string Ph { get; set; }
        public string TimeOfLight { get; set; }

        public string StageNumber { get; set; }
        public string TimeOfStage { get; set; }

        public string TempMode { get; set; }
        public string OxyMode { get; set; }
        public string PhMode { get; set; }
        public string LightMode { get; set; }
        //string LightStatus { get; set; }
        //string HeaterStatus { get; set; }
        //string FoodStatus { get; set; }
        //string FilterStatus { get; set; }
    }
}
