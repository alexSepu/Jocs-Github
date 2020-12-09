using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMDI
{
    public partial class FrmMain : Form
    {
        FrmPenjat penjat = null;
        FrmPedraPaperTisora ppt = null;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "Qüestió",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes) {
                this.Close();
            }
        }

        private void elPenjatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (penjat == null)
            {
                penjat = new FrmPenjat();
                penjat.MdiParent = this;
                penjat.emTanquen += new EventHandler(tanquemPenjat);
            }
            penjat.Show();
        }

        private void tanquemPenjat(object sender, EventArgs e)
        {
            if (sender.GetType().ToString().Contains("FrmPenjat"))
            {
                penjat = null;
            } else
            {
                ppt = null;
            }
        }

        private void pedraPaperTisoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ppt == null)
            {
                ppt = new FrmPedraPaperTisora();
                ppt.MdiParent = this;
                ppt.emTanquen += new EventHandler(tanquemPenjat);
            }
            ppt.Show();
        }


#region ------------------------- OPCIONS DEL MENÚ FINESTRES ---------------------------
        private void horitzontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        #endregion

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void organitzarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }

}
