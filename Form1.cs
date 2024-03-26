using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace registro_dañados
{
    public partial class Form1 : Form
    {
        
        void Limpiar()
        {
            cb_tipo.SelectedIndex = 0;
            cb_marca.SelectedIndex = 0;
            txt_modelo.Text = "-";
            txt_numactivo.Text = "-";
            txt_numserie.Text = "-";
        }

        bool Guardar_datos(string fecha, string tipo, string marca, string modelo, string num_serie, string num_activo)
        {
            try
            {
                using (StreamWriter archivo = new StreamWriter("dañados.csv", true, Encoding.UTF8))
                {
                    archivo.WriteLine($"{fecha};{tipo};{marca};{modelo};{num_serie};{num_activo}");
                }
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
            cb_marca.SelectedIndex = 0;
            cb_tipo.SelectedIndex = 0;

            DateTime fecha = DateTime.Now;

            lb_fecha.Text = fecha.ToString("dd-MM-yyyy");

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            String fecha = lb_fecha.Text;
            String tipo = cb_tipo.Text;
            String marca = cb_marca.Text;
            String modelo = txt_modelo.Text.ToUpper();
            String num_serie = txt_numserie.Text.ToUpper();
            String num_activo = $"80042000 {txt_numactivo.Text.ToUpper()}";

            if (cb_tipo.SelectedIndex == 0 || cb_marca.SelectedIndex == 0)
            {
                MessageBox.Show("Selecciona al menos la marca y tipo del hardware.","Aviso");
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

            Console.WriteLine($"{tipo} - {marca} - {modelo} - {num_serie} - {num_activo}");
        }
    }
}
