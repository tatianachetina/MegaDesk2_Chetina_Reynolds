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
        const int MIN_DEPTH = 12;
        const int MAX_DEPTH = 48;
        const int MIN_WIDTH = 24;
        public int MAX_WIDTH = 96;

        public AddQuote()
        {
            InitializeComponent();
        }

        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void TextBoxDeskWidth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDeskWidth(textBoxDeskWidth.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxDeskWidth.Select(0, textBoxDeskWidth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.widthErrorProvider.SetError(textBoxDeskWidth, errorMsg);

            }
            
        }

        private void TextBoxDeskWidth_Validated(object sender, EventArgs e)
        {
            widthErrorProvider.SetError(textBoxDeskWidth, "");
        }

        public bool ValidDeskWidth(string deskWidth, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (deskWidth.Length == 0)
            {
                errorMessage = "Width is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (Convert.ToDecimal(textBoxDeskWidth) >= MIN_WIDTH &&
                Convert.ToDecimal(textBoxDeskWidth) <= MAX_WIDTH)
            {
                    errorMessage = "";
                    return true;

             }

                errorMessage = "Width must be between " + MIN_WIDTH +
                     " inches and " + MAX_WIDTH + " inches.";
                return false;
            }

        private void TextBoxDeskDepth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDeskDepth(textBoxDeskDepth.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxDeskDepth.Select(0, textBoxDeskDepth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.depthErrorProvider.SetError(textBoxDeskDepth, errorMsg);

            }
        }

        private void TextBoxDeskDepth_Validated(object sender, EventArgs e)
        {
            depthErrorProvider.SetError(textBoxDeskDepth, "");
        }

        public bool ValidDeskDepth(string deskDepth, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (deskDepth.Length == 0)
            {
                errorMessage = "Depth is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (Convert.ToDecimal(textBoxDeskWidth) >= MIN_DEPTH &&
                Convert.ToDecimal(textBoxDeskWidth) <= MAX_DEPTH)
            {
                errorMessage = "";
                return true;

            }

            errorMessage = "Depth must be between " + MIN_DEPTH +
                 " inches and " + MAX_DEPTH + " inches.";
            return false;
        }


        private void TextBoxDeskDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }
    }

}
}
