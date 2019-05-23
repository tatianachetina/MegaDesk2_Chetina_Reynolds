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

        public AddQuote()

        {
            InitializeComponent();

            // creating a  List of enumerated desktop materials
            //convert an enum to a list
            List<Desk.DesktopMaterial> DesktopMaterialList = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList(); ;

            comboBoxMaterial.DataSource = DesktopMaterialList;

            comboBoxMaterial.SelectedIndex = -1;

            List<DeskQuote.RushOrder> RushOrderList = Enum.GetValues(typeof(DeskQuote.RushOrder)).Cast<DeskQuote.RushOrder>().ToList(); ;

            comboBoxRushDays.DataSource = RushOrderList;

            comboBoxRushDays.SelectedIndex = -1;



        }

        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        public void ButtonSaveQuotes_Click(object sender, EventArgs e)
        {
            var desk = new Desk()
            {
                Depth = numUpDownDeskDepth.Value,
                Width = numUpDownDeskWidth.Value,
                NumberOfDrawers = (int)comboBoxDrawers.SelectedValue,
                SurfaceMaterial = (Desk.DesktopMaterial)comboBoxMaterial.SelectedValue
            };

            var deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = textBoxClientName.Text,
                QuoteDate = DateTime.Now,
                ShippingType = (DeskQuote.RushOrder)comboBoxRushDays.SelectedValue
            };

            DisplayQuote DisplayQuote = new DisplayQuote(deskQuote);
            DisplayQuote.Show();
            Hide();


        }
    }

    
}
