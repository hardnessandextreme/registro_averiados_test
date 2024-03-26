namespace registro_dañados
{
    public partial class Form1 : Form
    {
        public void Limpiar()
        {
            cb_tipo.SelectedIndex = 0;
            cb_marca.SelectedIndex = 0;
            txt_modelo.Text = "-";
            txt_numactivo.Text = "-";
            txt_numserie.Text = "-";
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

            MessageBox.Show($"{tipo} - {marca} - {modelo} - {num_serie} - {num_activo}");
        }
    }
}
