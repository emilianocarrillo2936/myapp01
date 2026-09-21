using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador_1
{
    public partial class Form1 : Form
    {
        int contador = 0, minutos = 0;
        bool bandera = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            contador++;
            DateTime tiempo = DateTime.Now;
            lblReloj.Text = tiempo.ToString("HH:mm:ss");
            lblFecha.Text = tiempo.ToString("MM-dd-yyyy");
            if (contador == 60)
            {
                minutos++;
                contador = 0;
            }
            lblEjecuccion.Text = "Tiempo en Ejecucion: " + minutos.ToString();

        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                bandera = true;
                tmrReloj.Enabled = true;
                btnEncender.Text = "Apagar";
            }
            else
            {
                bandera = false;
                tmrReloj.Enabled = false;
                btnEncender.Text = "Encender";
            }
        }
    }
}
