using System;
using System.IO;
using ClosedXML.Excel;
using System.Data;
using System.Text;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using System.Windows.Forms;

namespace registro_dañados
{
    public partial class Form1 : Form
    {
        void Imprimir_lista(List<string> lista)
        {
            foreach (string valor in lista)
            {
                Console.WriteLine(valor);
            }
        }

        void Limpiar()
        {
            cb_tipo.SelectedIndex = 0;
            cb_marca.SelectedIndex = 0;
            txt_modelo.Text = "-";
            txt_numactivo.Text = "-";
            txt_numserie.Text = "-";

            lb_men.Text = "Campos limpiados correctamente";
        }

        void Cargar_csv_en_datagridview()
        {
            tabla_datos.Rows.Clear();
            tabla_datos.Columns.Clear();

            try
            {
                using (StreamReader archivo = new StreamReader("dañados.csv", Encoding.UTF8))
                {
                    string linea;

                    string[] columnas = archivo.ReadLine()!.Split(";");
                    foreach (string columna in columnas)
                    {
                        // tabla_datos.Columns.Add(columnas[columna]);
                        Console.WriteLine(columna);
                        tabla_datos.Columns.Add(columna, columna);
                    }

                    while ((linea = archivo.ReadLine()!) != null)
                    {

                        string[] fila = linea.Split(";");
                        string fecha = fila[0];
                        string tipo = fila[1];
                        string marca = fila[2];
                        string modelo = fila[3];
                        string num_serie = fila[4];
                        string num_activo = fila[5];

                        tabla_datos.Rows.Add(fecha, tipo, marca, modelo, num_serie, num_activo);
                    }
                    tabla_datos.Sort(new MultiColumnComparer());
                    // tabla_datos.AutoResizeColumn(5, DataGridViewAutoSizeColumnMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el archivo CSV: {ex.Message}", "Error");
            }
        }

        bool Convertir_csv_excel()
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al convertir el archivo: {e.Message}", "Error");
                return false;
            }
        }

        void Verificar_archivos()
        {
            if (!Directory.Exists("datos"))
            {
                MessageBox.Show("No se encontró el directorio datos, se creará uno nuevo.", "Aviso");
                DirectoryInfo directory = Directory.CreateDirectory("datos");
            }

            if (File.Exists("datos/tipos.txt") == false)
            {
                MessageBox.Show("No se encontró el archivo tipos.txt, se creará uno nuevo.", "Aviso");
                using (StreamWriter archivo = new StreamWriter("datos/tipos.txt", true, Encoding.UTF8))
                {
                    archivo.WriteLine("SELECCIONE TIPO");
                    archivo.WriteLine("MONITOR");
                    archivo.WriteLine("CPU");
                    archivo.WriteLine("UPS");
                    archivo.WriteLine("ROUTER");
                    archivo.WriteLine("SWITCH");
                    archivo.WriteLine("IMPRESORA");
                    archivo.WriteLine("TELEFONO");
                    archivo.WriteLine("UBIQUITI");
                    archivo.WriteLine("LECTOR BARRA");
                    archivo.WriteLine("BATERIA LECTOR");
                    archivo.WriteLine("SCANNER");
                    archivo.WriteLine("LAPTOP");

                }
            }

            if (File.Exists("datos/marcas.txt") == false)
            {
                MessageBox.Show("No se encontró el archivo marcas.txt, se creará uno nuevo.", "Aviso");
                using (StreamWriter archivo = new StreamWriter("datos/marcas.txt", true, Encoding.UTF8))
                {
                    archivo.WriteLine("SELECCIONE MARCA");
                    archivo.WriteLine("HP");
                    archivo.WriteLine("DELL");
                    archivo.WriteLine("LENOVO");
                    archivo.WriteLine("ACER");
                    archivo.WriteLine("AOC");
                    archivo.WriteLine("SAMSUNG");
                    archivo.WriteLine("LG");
                    archivo.WriteLine("CISCO");
                    archivo.WriteLine("MICRO TIK");
                    archivo.WriteLine("CISCO");
                    archivo.WriteLine("NANOSTATION M2");
                    archivo.WriteLine("PSION");
                    archivo.WriteLine("GRANDSTREAM");
                    archivo.WriteLine("APC");
                    archivo.WriteLine("TRIPP LITE");

                }
            }

            if (File.Exists("dañados.csv") == false)
            {
                MessageBox.Show("No se encontró el archivo dañados.csv, se creará uno nuevo.", "Aviso");
                using (StreamWriter archivo = new StreamWriter("dañados.csv", true, Encoding.UTF8))
                {
                    archivo.WriteLine("FECHA;TIPO;MARCA;MODELO;SERIE;ACTIVO");
                }
            }
        }

        (List<string> tipos, List<string> marcas) Cargar_tipos_marcas()
        {
            List<string> tipos = new List<string>();
            List<string> marcas = new List<string>();

            using (StreamReader archivo = new StreamReader("datos/tipos.txt", Encoding.UTF8))
            {
                string linea;
                while ((linea = archivo.ReadLine()!) != null)
                {
                    tipos.Add(linea);
                }
            }

            using (StreamReader archivo = new StreamReader("datos/marcas.txt", Encoding.UTF8))
            {
                string linea;
                while ((linea = archivo.ReadLine()!) != null)
                {
                    marcas.Add(linea);
                }
            }

            lb_men.Text = "Tipos y marcas cargados correctamente";

            return (tipos, marcas);
        }

        void Actualizar_cb()
        {
            cb_tipo.Items.Clear();
            cb_marca.Items.Clear();

            List<string> tipos = Cargar_tipos_marcas().tipos;
            List<string> marcas = Cargar_tipos_marcas().marcas;

            foreach (string tipo in tipos)
            {
                cb_tipo.Items.Add(tipo);
            }

            foreach (string marca in marcas)
            {
                cb_marca.Items.Add(marca);
            }

            cb_marca.SelectedIndex = 0;
            cb_tipo.SelectedIndex = 0;

            lb_men.Text = "Combobox's actualizados correctamente";

        }

        bool Guardar_datos(string fecha, string tipo, string marca, string modelo, string num_serie, string num_activo)
        {
            Verificar_archivos();
            try
            {
                using (StreamWriter archivo = new StreamWriter("dañados.csv", true, Encoding.UTF8))
                {
                    archivo.WriteLine($"{fecha};{tipo};{marca};{modelo};{num_serie};{num_activo}");
                }
                Cargar_csv_en_datagridview();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al guardar los datos: {e.Message}", "Error");
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Verificar_archivos();
            Cargar_tipos_marcas();
            Cargar_csv_en_datagridview();

            // aqui llamo al metodo que carga los combobox y los inicializo
            List<string> tipos = Cargar_tipos_marcas().tipos;
            List<string> marcas = Cargar_tipos_marcas().marcas;

            foreach (string tipo in tipos)
            {
                cb_tipo.Items.Add(tipo);
            }

            foreach (string marca in marcas)
            {
                cb_marca.Items.Add(marca);
            }

            cb_marca.SelectedIndex = 0;
            cb_tipo.SelectedIndex = 0;


            // esto es para mostrar la fecha actual en el label
            DateTime fecha = DateTime.Now;
            lb_fecha.Text = fecha.ToString("dd-MM-yyyy");

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string fecha = lb_fecha.Text;
            string tipo = cb_tipo.Text;
            string marca = cb_marca.Text;
            string modelo = txt_modelo.Text.ToUpper();
            string num_serie = txt_numserie.Text.ToUpper();
            string num_activo = $"80042000 {txt_numactivo.Text.ToUpper()}";

            if (cb_tipo.SelectedIndex == 0 || cb_marca.SelectedIndex == 0)
            {
                MessageBox.Show("Selecciona al menos la marca y tipo del hardware.", "Aviso");
                return;
            }

            if (Guardar_datos(fecha, tipo, marca, modelo, num_serie, num_activo))
            {
                lb_men.Text = "Datos guardados correctamente";
            }
            else
            {
                lb_men.Text = "Error al guardar los datos";
            }

            Console.WriteLine($"{fecha} - {tipo} - {marca} - {modelo} - {num_serie} - {num_activo}");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Actualizar_cb();
        }

        private void btn_conv_excel_Click(object sender, EventArgs e)
        {
            if (Convertir_csv_excel())
            {
                MessageBox.Show("Archivo convertido correctamente", "Aviso");
            }
        }
    }
}
