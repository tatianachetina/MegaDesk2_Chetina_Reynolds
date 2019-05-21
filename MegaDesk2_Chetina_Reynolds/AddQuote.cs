using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Chetina
{
    public partial class AddQuote : Form

    {
        DesktopMaterial DesktopMaterial;

        public AddQuote()
        {
            // creating a  List of enumerated desktop materials
            //convert an enum to a list
            List<DesktopMaterial> DesktopMaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList(); ;

            comboBoxMaterial.DataSource = DesktopMaterialList;
        }

        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

    }

    
}
