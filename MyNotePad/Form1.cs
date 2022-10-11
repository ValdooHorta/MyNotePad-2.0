using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //agregamos esta biblioteca

namespace MyNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Archivo
            Stream stm; 
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((stm = ofd.OpenFile())!=null)
                {
                    string str = ofd.FileName;
                    string ftxt = File.ReadAllText(str);
                    richTextBox1.Text = ftxt;
                }
           
            }

         
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Guardar Archivo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de texto(*.txt)|*.txt|Archivo de C#(*,cs)|*.cs";
            sfd.ShowDialog();
            File.WriteAllText(sfd.FileName, richTextBox1.Text);
            MessageBox.Show("Archivo de texto guardado exitosamente.");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fontName;
                float fontSize;
                fontName = dlg.Font.Name;
                fontSize = dlg.Font.Size;
                richTextBox1.Font = dlg.Font;
            }

        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void naranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Orange;
        }

        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Aqua;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void colorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blancoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.White;
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void negroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Black;
        }

        private void verdeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void azulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Blue;
        }

        private void blancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por Horta Mizuno");
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float CurrentSize;
            CurrentSize = richTextBox1.Font.Size;
            CurrentSize += 2.0F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name,
                CurrentSize, richTextBox1.Font.Style, richTextBox1
                .Font.Unit);
        }

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            float CurrentSize;
            CurrentSize = richTextBox1.Font.Size;
            CurrentSize -= 2.0F;
            if (CurrentSize<=2)
            {
                CurrentSize = 2;
            }
            else
            {
               richTextBox1.Font = new Font(richTextBox1.Font.Name,
                CurrentSize, richTextBox1.Font.Style, richTextBox1
                .Font.Unit);
            }
            
        }
    }
}
