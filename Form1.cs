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
        int veces;
        List<url> datos = new List<url>();
        url dato = new url();
        //veces = 0;
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


            int pos = datos.FindIndex(n => n.texto1 == uri);
            //si no existe lo creamos y lo agregamos a la lista
            if (pos == -1)
            {

                url dato = new url();
                veces = 0;
                textBox1.Text = veces.ToString();
                dato.texto1 = cmbBuscar.Text;
                dato.fecha = DateTime.Now;
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
            Guardar2A(@"C:\ArchivoLab3.txt");
        }


        private void Guardar2A(string nombreArchivo)
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);
            foreach (var dato in datos)
            {
                datos = datos.OrderByDescending(n => n.numero).ToList();
                writer.WriteLine(dato.texto1);
            }

            writer.Close();
        }

        private void Guardar3A(string nombreArchivo)
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);
            foreach (var dato in datos)
            {
                datos = datos.OrderByDescending(m => m.fecha).ToList();
                writer.WriteLine(dato.texto1);
            }

            writer.Close();
        }


        private void másRecientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar3A(@"C:\ArchivoLab3.txt");
        }

        private void eliminarSeleccionadoEnComboboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar1(@"C:\ArchivoLab3.txt");
        }

        private void Eliminar1(string nombreArchivo)
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);
            if (cmbBuscar.Text == dato.texto1)
            {
                foreach (var dato in datos)
                {
                    if (cmbBuscar.Text == dato.texto1)
                    {
                        dato.texto1 = "";
                        writer.WriteLine(dato.texto1);
                    }
                }

                writer.Close();
            }
        }
    }
}

    

