using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas
{
    public partial class Form1 : Form
    {
        int contador = 0;
        bool save = false;
        string path;

        public Form1()
        {
            InitializeComponent();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctTexto.Clear();
            rctTexto.Focus();
            path = "";
            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpAbrir.ShowDialog() == DialogResult.OK)
            {
                path = ofpAbrir.FileName;
                save = true;
                rctTexto.LoadFile(ofpAbrir.FileName, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = false;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                if (sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    path = sfdGuardar.FileName;
                    save = true;
                }

            }
            rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
            guardarToolStripMenuItem.Enabled = false;
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardadoGeneral();
        }

        private void guardadoGeneral()
        {

            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                path = sfdGuardar.FileName;
                rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = true;
                save = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrGuardar_Tick(object sender, EventArgs e)
        {
            if (save && !string.IsNullOrEmpty(path))
            {
                rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
                toolStripStatusLabel1.Text = "Autoguardado: " + DateTime.Now.ToString("HH:mm:ss") + " en " + path;
            }
            else
            {
                toolStripStatusLabel1.Text = "Documento no guardado aún (autoguardado en espera)";
            }
        }

    }
}

