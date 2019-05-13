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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

       

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            this.Hide();
        }

        private void ButtonSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes newSearchQuoteForm = new SearchQuotes();
            newSearchQuoteForm.Tag = this;
            newSearchQuoteForm.Show(this);
            this.Hide();
        }

        private void ButtonViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes newViewAllQuoteForm = new ViewAllQuotes();
            newViewAllQuoteForm.Tag = this;
            newViewAllQuoteForm.Show(this);
            this.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
