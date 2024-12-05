using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MiPrimerFormulario : Form
    {
        public MiPrimerFormulario()
        {
            InitializeComponent();
        }

        private void AniadirBoton_Click(object sender, EventArgs e)
        {
            if ((TbCodigo.Text != "") || (TbDescripcion.Text != ""))
            {
                if (!ListaCaja.Items.Contains(TbCodigo.Text))
                {
                    ListaCaja.Items.Add(TbCodigo.Text);
                    ListaCajaDescrip.Items.Add(TbDescripcion.Text);
                    MessageBox.Show("Datos guardados.");
                    Console.WriteLine("Index:" + ListaCajaDescrip.Items.IndexOf(TbDescripcion.Text));
                }
                else
                {
                    MessageBox.Show("El codigo asignado ya existe.");
                }
            }
            else
            {
                MessageBox.Show("Los valores seleccionados son invalidos o estan vacios.");
            }


            TbCodigo.Text = string.Empty;
            TbDescripcion.Text = string.Empty;
            TbCodigo.Select();
        }


        private void ListaCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCaja.SelectedIndex >= 0)
            {
                int indexSeleccionado = ListaCaja.SelectedIndex;
                ListaCajaDescrip.SelectedIndex = indexSeleccionado;
                TbCodigo.Text = ListaCaja.Items[indexSeleccionado].ToString();
                TbDescripcion.Text = ListaCajaDescrip.Items[indexSeleccionado].ToString();
            }
            else
            {
                Console.WriteLine("Ya no tenemos seleccionado nada.");
            }


        }



        private void ActualizarBoton_Click(object sender, EventArgs e)
        {
            if (ListaCaja.Items.Contains(TbCodigo.Text))
            {
                int idItem = ListaCaja.Items.IndexOf(TbCodigo.Text);

                if (TbDescripcion.Text != string.Empty)
                {
                    ListaCajaDescrip.Items[idItem] = TbDescripcion.Text;

                    MessageBox.Show("Se han actualizado los datos de '" + TbCodigo.Text + "'.");
                }
                else
                {
                    MessageBox.Show("No podemos dejar la descripcion vacia.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un codigo válido.");
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            if (ListaCaja.Items.Contains(TbCodigo.Text) && TbCodigo.Text != string.Empty)
            {
                int idItem = ListaCaja.Items.IndexOf(TbCodigo.Text);

                ListaCaja.Items.RemoveAt(idItem);
                ListaCajaDescrip.Items.RemoveAt(idItem);

                MessageBox.Show("El elemento se borró correctamente.");
            }
            else
            {
                MessageBox.Show("Ingrese un codigo valido.");
            }
        }


        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            if (TbBusca.Text != string.Empty)
            {
                List<int> indices = BuscarEnListaParcial(ListaCaja, TbBusca.Text);

                if (indices.Count > 0)
                {
                    int idItem = indices[0];
                    ListaCaja.SelectedIndex = idItem;
                    ListaCajaDescrip.SelectedIndex = idItem;

                    TbCodigo.Text = ListaCaja.Items[idItem].ToString();
                    TbDescripcion.Text = ListaCajaDescrip.Items[idItem].ToString();

                    label6.Text = indices.Count.ToString();
                }
                else
                {
                    indices = BuscarEnListaParcial(ListaCajaDescrip, TbBusca.Text);

                    if (indices.Count > 0)
                    {
                        int idItem = indices[0];
                        ListaCaja.SelectedIndex = idItem;
                        ListaCajaDescrip.SelectedIndex = idItem;

                        TbCodigo.Text = ListaCaja.Items[idItem].ToString();
                        TbDescripcion.Text = ListaCajaDescrip.Items[idItem].ToString();

                        label6.Text = indices.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado ningún resultado.");
                        label6.Text = "0";
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un código o una descripción");
                label6.Text = "0";
            }
        }

        private List<int> BuscarEnListaParcial(ListBox lista, string texto)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < lista.Items.Count; i++)
            {
                if (lista.Items[i].ToString().IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        private void ReporteBoton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Guardar lista como CSV";
                saveFileDialog.FileName = "lista.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Ruta del archivo seleccionada por el usuario
                    string rutaArchivo = saveFileDialog.FileName;

                    // Crear un StreamWriter para escribir en el archivo
                    using (StreamWriter escritor = new StreamWriter(rutaArchivo))
                    {
                        // Escribir la cabecera del archivo CSV
                        escritor.WriteLine("Codigo,Descripcion");

                        // Escribir los datos de las listas
                        for (int i = 0; i < ListaCaja.Items.Count; i++)
                        {
                            string codigo = ListaCaja.Items[i].ToString();
                            string descripcion = ListaCajaDescrip.Items[i].ToString();
                            escritor.WriteLine($"{codigo},{descripcion}");
                        }
                    }

                    MessageBox.Show("Lista guardada como CSV.");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
