using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BolotinTour
{
    class AppData
    {
        public static Frame MainFrame;
        public static BolotinTourEntities Context = new BolotinTourEntities();
        public static int minPrice = -1;
        public static int maxPrice = -1;
    }
}
