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

        int opcionJugador=0;
        public FrmPedraPaperTisora()
        {
            InitializeComponent();


        }

        private void FrmPedraPaperTisora_FormClosing(object sender, FormClosingEventArgs e)
        {
            emTanquen(this, EventArgs.Empty);
        }

        private void FrmPedraPaperTisora_Load(object sender, EventArgs e)
        {
            tituloppt.Location = new Point(this.Width / 2 - tituloppt.Width / 2, 10);
        }

        private void papel_Click(object sender, EventArgs e)
        {
            opcionJugador = 1;
            comprobarResultado(opcionJugador);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            opcionJugador = 2;
            comprobarResultado(opcionJugador);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            opcionJugador = 3;
            comprobarResultado(opcionJugador);
        }

        void comprobarResultado(int opcionjugador)
        {
            Random rnd = new Random();
            int opcionCPU;

            Bitmap imatge;
            System.Threading.Thread.Sleep(5);
            opcionCPU = rnd.Next(1,4);
            if(opcionCPU ==1)
            {
                imatge = FormMDI.Properties.Resources.Papel;
                aux.Image=imatge;
            }else if(opcionCPU == 2)
            {
                imatge = FormMDI.Properties.Resources.Piedra;
                aux.Image = imatge;
            }
            else if(opcionCPU == 3)
            {
                imatge = FormMDI.Properties.Resources.Tijera;
                aux.Image = imatge;
            }

            if (opcionCPU == opcionjugador)
            {
                res.Text = "Empate";
            }
            else if (opcionjugador == 1 && opcionCPU == 2) res.Text = "Gana jugador";
            else if (opcionjugador == 2 && opcionCPU == 1) res.Text = "Gana cpu";            
            else if (opcionjugador == 1 && opcionCPU == 3) res.Text = "Gana cpu";
            else if (opcionjugador == 3 && opcionCPU == 1) res.Text = "Gana jugador";
            else if (opcionjugador == 3 && opcionCPU == 1) res.Text = "Gana jugador";
            else if (opcionjugador == 1 && opcionCPU == 3) res.Text = "Gana cpu";
            else if (opcionjugador == 2 && opcionCPU == 3) res.Text = "gana jugador";
            else if (opcionjugador == 3 && opcionCPU == 2) res.Text = "gana cpu";
                


        }

    }
}
