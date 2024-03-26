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

        bool Guardar_datos(string tipo, string marca, string modelo, string num_activo, string num_serie)
        {
            try
            {
                using (StreamWriter archivo = new StreamWriter("dañados.csv", true, Encoding.UTF8))
                {
                    archivo.WriteLine($"{tipo};{marca};{modelo};{num_serie};{num_activo}");
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

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            String tipo = cb_tipo.Text;
            String marca = cb_marca.Text;
            String modelo = txt_modelo.Text;
            String num_serie = txt_numserie.Text;
            String num_activo = $"80042000 {txt_numactivo.Text}";

            if (cb_tipo.SelectedIndex == 0 || cb_marca.SelectedIndex == 0)
            {
                MessageBox.Show("Selecciona al menos la marca y tipo del hardware.","Aviso");
                return;
            }

            if (Guardar_datos(tipo, marca, modelo, num_serie, num_activo))
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
