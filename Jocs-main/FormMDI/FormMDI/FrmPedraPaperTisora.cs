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
    public partial class FrmPedraPaperTisora : Form
    {
        public event EventHandler emTanquen;
        public FrmPedraPaperTisora()
        {
            InitializeComponent();
        }

        private void FrmPedraPaperTisora_FormClosing(object sender, FormClosingEventArgs e)
        {
            emTanquen(this, EventArgs.Empty);
        }
    }
}
