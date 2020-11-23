using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAccessDemo
{
    public partial class frmDataControls : Form
    {
        public frmDataControls()
        {
            InitializeComponent();
        }

        private void frmDataControls_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rPGCharacterDataSet.Characters' table. You can move, or remove it, as needed.
            this.charactersTableAdapter.Fill(this.rPGCharacterDataSet.Characters);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.charactersBindingSource.EndEdit();
            this.charactersTableAdapter.Update(this.rPGCharacterDataSet);

        }
    }
}
