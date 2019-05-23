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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();

            labelClientNameOutput.Text = deskQuote.CustomerName.ToString();
            labelWidthOutput.Text = deskQuote.Desk.Width.ToString();
            labelDepthOutput.Text = deskQuote.Desk.Depth.ToString();
            labelMaterialOutput.Text = deskQuote.Desk.SurfaceMaterial.ToString();
            labelRushDaysOutput.Text = deskQuote.ShippingType.ToString();
            labelDrawersOutput.Text = deskQuote.Desk.NumberOfDrawers.ToString();
            labelPriceOutput.Text = deskQuote.QuotePrice.ToString();
        }

    }
}
