using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LaboratorioNo4
{
    public partial class Form1 : Form
    {
        int veces ;
        List<url> datos = new List<url>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbBuscar.SelectedIndex = 0;
            webBrowser1.GoHome();
            string nombreArchivo = @"C:\ArchivoLab3.txt";

            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                string texto = reader.ReadLine();
                cmbBuscar.Items.Add(texto);
            }
            reader.Close();
        }

        private void navegarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            String uri = cmbBuscar.Text;
         
            //Angely Esmeralda Thomas Cortéz -  202108047 - Ingeniería en Sistemas 
            //Tercer Semestre Universidad Mesoamericana, Programación

            //busca si el texto ya existe dentro de datos
            int pos = datos.FindIndex(n => n.texto == uri);           
            //si no existe lo creamos y lo agregamos a la lista
            if (pos == -1)
            {
                veces = 0;
                url dato = new url();      
                veces++;
                textBox1.Text = veces.ToString();
                dato.texto = cmbBuscar.Text;              
                //condicion para url
                if (uri.Contains("."))
                {
                    if (uri.Contains("https://"))
                    {
                        //Buscar lo seleccionado en el combobox
                        webBrowser1.Navigate(new Uri(cmbBuscar.Text));
                    }
                    else
                    {
                        webBrowser1.Navigate(new Uri("https://" + cmbBuscar.Text));
                        cmbBuscar.Text = "https://" + cmbBuscar.Text;
                    }
                }
                else
                {
                    uri = "http://www.google.com/search?q=" + uri;
                    webBrowser1.Navigate(new Uri(uri));
                }


                datos.Add(dato);
                cmbBuscar.Items.Add(uri);
                Guardar(@"C:\ArchivoLab3.txt", uri);
            }
            else
            {
                veces = datos[pos].numero++;
                textBox1.Text = veces.ToString();
               
                //condicion para url
                if (uri.Contains("."))
                {
                    if (uri.Contains("https://"))
                    {
                        //Buscar lo seleccionado en el combobox
                        webBrowser1.Navigate(new Uri(cmbBuscar.Text));
                    }
                    else
                    {
                        webBrowser1.Navigate(new Uri("https://" + cmbBuscar.Text));
                        cmbBuscar.Text = "https://" + cmbBuscar.Text;
                    }
                }
                else
                {
                    uri = "http://www.google.com/search?q=" + uri;
                    webBrowser1.Navigate(new Uri(uri));
                }

            }

        }

        private void Guardar(string nombreArchivo, string texto)
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(texto);

            writer.Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void haciaAdelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void haciaAtrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void másVisitadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (url item in datos)
            {
                datos = datos.OrderBy(n => n.numero).ToList();
                cmbBuscar.Items.Add(datos.ToList());
                Guardar2A(@"C:\ArchivoLab3.txt", datos.ToString());
                Mostrar();
            }
            
        }


        private void Guardar2A(string nombreArchivo, string datos)
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(datos.ToString());

            writer.Close();
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }
    }
}
