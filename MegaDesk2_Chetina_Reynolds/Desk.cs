using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Chetina
{
    public class Desk
    {
        public enum DesktopMaterial
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        };

        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public int NumberOfDrawers { get; set; }

        public DesktopMaterial SurfaceMaterial { get; set; }
    }
}
