namespace registro_dañados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_modelo = new TextBox();
            txt_numserie = new TextBox();
            txt_numactivo = new TextBox();
            cb_tipo = new ComboBox();
            cb_marca = new ComboBox();
            btn_guardar = new Button();
            btn_conv_excel = new Button();
            btn_actualizar = new Button();
            btn_limpiar = new Button();
            lb_men = new Label();
            lb_fecha = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 111);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 162);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 210);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 3;
            label4.Text = "Numero de serie:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 261);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 4;
            label5.Text = "Numero de activo:";
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(214, 162);
            txt_modelo.Margin = new Padding(2);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(146, 27);
            txt_modelo.TabIndex = 5;
            txt_modelo.Text = "-";
            // 
            // txt_numserie
            // 
            txt_numserie.Location = new Point(214, 210);
            txt_numserie.Margin = new Padding(2);
            txt_numserie.Name = "txt_numserie";
            txt_numserie.Size = new Size(146, 27);
            txt_numserie.TabIndex = 6;
            txt_numserie.Text = "-";
            // 
            // txt_numactivo
            // 
            txt_numactivo.Location = new Point(214, 261);
            txt_numactivo.Margin = new Padding(2);
            txt_numactivo.Name = "txt_numactivo";
            txt_numactivo.Size = new Size(146, 27);
            txt_numactivo.TabIndex = 7;
            txt_numactivo.Text = "-";
            // 
            // cb_tipo
            // 
            cb_tipo.FormattingEnabled = true;
            cb_tipo.Items.AddRange(new object[] { "- SELECCIONE TIPO -", "MONITOR", "CPU", "UPS", "ROUTER", "TELEFONO", "UBIQUITI", "SWITCH", "LECTOR BARRA", "LAPTOP" });
            cb_tipo.Location = new Point(214, 67);
            cb_tipo.Margin = new Padding(2);
            cb_tipo.Name = "cb_tipo";
            cb_tipo.Size = new Size(146, 28);
            cb_tipo.TabIndex = 8;
            // 
            // cb_marca
            // 
            cb_marca.FormattingEnabled = true;
            cb_marca.Items.AddRange(new object[] { "- SELECCIONE MARCA -", "HP", "DELL", "ACER", "AOC", "CISCO", "SAMSUNG", "LG", "PSION", "MICRO TIK", "NANOSTATION M2", "GRANDSTREAM", "APC", "TRIPP LITE" });
            cb_marca.Location = new Point(214, 111);
            cb_marca.Margin = new Padding(2);
            cb_marca.Name = "cb_marca";
            cb_marca.Size = new Size(146, 28);
            cb_marca.TabIndex = 9;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(41, 354);
            btn_guardar.Margin = new Padding(2);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(90, 27);
            btn_guardar.TabIndex = 10;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_conv_excel
            // 
            btn_conv_excel.Location = new Point(148, 354);
            btn_conv_excel.Margin = new Padding(2);
            btn_conv_excel.Name = "btn_conv_excel";
            btn_conv_excel.Size = new Size(112, 27);
            btn_conv_excel.TabIndex = 11;
            btn_conv_excel.Text = "Convertir Excel";
            btn_conv_excel.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(277, 354);
            btn_actualizar.Margin = new Padding(2);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(90, 27);
            btn_actualizar.TabIndex = 12;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(148, 406);
            btn_limpiar.Margin = new Padding(2);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(112, 27);
            btn_limpiar.TabIndex = 13;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // lb_men
            // 
            lb_men.Location = new Point(41, 303);
            lb_men.Name = "lb_men";
            lb_men.Size = new Size(319, 27);
            lb_men.TabIndex = 14;
            lb_men.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_fecha
            // 
            lb_fecha.Location = new Point(41, 21);
            lb_fecha.Name = "lb_fecha";
            lb_fecha.Size = new Size(319, 27);
            lb_fecha.TabIndex = 15;
            lb_fecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 467);
            Controls.Add(lb_fecha);
            Controls.Add(lb_men);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_actualizar);
            Controls.Add(btn_conv_excel);
            Controls.Add(btn_guardar);
            Controls.Add(cb_marca);
            Controls.Add(cb_tipo);
            Controls.Add(txt_numactivo);
            Controls.Add(txt_numserie);
            Controls.Add(txt_modelo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_modelo;
        private TextBox txt_numserie;
        private TextBox txt_numactivo;
        private ComboBox cb_tipo;
        private ComboBox cb_marca;
        private Button btn_guardar;
        private Button btn_conv_excel;
        private Button btn_actualizar;
        private Button btn_limpiar;
        private Label lb_men;
        private Label lb_fecha;
    }
}
