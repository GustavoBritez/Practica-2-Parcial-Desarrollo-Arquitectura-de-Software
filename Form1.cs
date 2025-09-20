using Microsoft.VisualBasic;
using System.Data;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        BindingSource bdEstudiante = new BindingSource();
        BindingSource bdLibros = new BindingSource();
        BindingSource bdReservas = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            Cargar_DataSet("D:\\Documents\\BASE_DAS\\LOPO.xml");
            Cargar_Grillas();
        }
        public void Cargar_DataSet(string linea)
        {
            try
            {

                ds.ReadXml(linea);

                DataRelation relation_Estudiante_Prestamo = new DataRelation(
                    "FK_EST_PRESTAMO",
                    ds.Tables["Estudiante"].Columns["Legajo"],
                    ds.Tables["Prestamo"].Columns["Legajo"]
                    );

                DataRelation relation_Libro_Prestamo = new DataRelation(
                    "FK_LIBRO_PRESTAMO",
                    ds.Tables["Libro"].Columns["ID"],
                    ds.Tables["Prestamo"].Columns["ID"]
                    );

                ds.Relations.Add(relation_Estudiante_Prestamo);
                ds.Relations.Add(relation_Libro_Prestamo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Cargar_Grillas()
        {
            try
            {

                bdEstudiante.DataSource = ds;
                bdEstudiante.DataMember = "Estudiante";

                Grilla_Estudiantes.DataSource = bdEstudiante;

                bdLibros.DataSource = ds;
                bdLibros.DataMember = "Libro";

                Grilla_Libros.DataSource = bdLibros;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grilla_Estudiantes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var inn = Grilla_Estudiantes.Rows[e.RowIndex].Cells["Legajo"].Value;
                    DataView dv = new DataView(ds.Tables["Prestamo"]);
                    dv.RowFilter = $"Legajo = {inn}";
                    Grilla_Reserva.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Grilla_Estudiantes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Ingrese nombre");
                int legajo = Convert.ToInt32(Interaction.InputBox("Ingrese legajo numerico"));

                ds.Tables["Estudiante"].Rows.Add(legajo, nombre);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.WriteXml("D:\\Documents\\BASE_DAS\\LOPO.xml");
            }
        }

        private void BTN_ASIGNAR_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo = Convert.ToInt32(Grilla_Estudiantes.SelectedRows[0].Cells["Legajo"].Value);
                int id = Convert.ToInt32(Grilla_Libros.SelectedRows[0].Cells["ID"].Value);


                ds.Tables["Prestamo"].Rows.Add(legajo, id, "Pendiente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.WriteXml("D:\\Documents\\BASE_DAS\\LOPO.xml");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = textBox1.Text.Trim();

                Lista_Tablas.DataSource = null;

                DataView dv = new DataView(ds.Tables["Libro"]);

                if (!string.IsNullOrEmpty(text))
                {
                    dv.RowFilter = $"Titulo LIKE '%{text}%'";
                }
                else
                {
                    dv.RowFilter = "";
                }

                Lista_Tablas.DataSource = dv;
                Lista_Tablas.DisplayMember = "Titulo";  
                Lista_Tablas.ValueMember = "ID";         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.WriteXml("D:\\Documents\\BASE_DAS\\LOPO.xml");
            }
        }

    }
}
