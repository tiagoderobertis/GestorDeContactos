namespace GestorDeContactos.Views
{
    partial class FormularioEditarContacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAceptar = new Button();
            TxtNombre = new TextBox();
            TxtApellido = new TextBox();
            TxtNumero = new TextBox();
            TxtFijo = new TextBox();
            CmbTipoContacto = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LblError = new Label();
            BtnVolver = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)BtnVolver).BeginInit();
            SuspendLayout();
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(85, 368);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(83, 24);
            BtnAceptar.TabIndex = 0;
            BtnAceptar.Text = "Guardar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(132, 179);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(121, 23);
            TxtNombre.TabIndex = 1;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(132, 213);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(121, 23);
            TxtApellido.TabIndex = 1;
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(132, 248);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(121, 23);
            TxtNumero.TabIndex = 1;
            // 
            // TxtFijo
            // 
            TxtFijo.Location = new Point(132, 283);
            TxtFijo.Name = "TxtFijo";
            TxtFijo.Size = new Size(120, 23);
            TxtFijo.TabIndex = 1;
            // 
            // CmbTipoContacto
            // 
            CmbTipoContacto.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTipoContacto.FormattingEnabled = true;
            CmbTipoContacto.Items.AddRange(new object[] { "Personal", "Empresa" });
            CmbTipoContacto.Location = new Point(132, 315);
            CmbTipoContacto.Name = "CmbTipoContacto";
            CmbTipoContacto.Size = new Size(121, 23);
            CmbTipoContacto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 182);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Nuevo Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 216);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Nuevo Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 251);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 3;
            label3.Text = "Nuevo Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 286);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Nuevo Fijo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 318);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 3;
            label5.Text = "Tipo de Contacto";
            // 
            // LblError
            // 
            LblError.AutoSize = true;
            LblError.BackColor = Color.White;
            LblError.ForeColor = Color.Red;
            LblError.Location = new Point(10, 494);
            LblError.Name = "LblError";
            LblError.Size = new Size(43, 15);
            LblError.TabIndex = 3;
            LblError.Text = "Errores";
            // 
            // BtnVolver
            // 
            BtnVolver.Image = Properties.Resources.pngwing_com;
            BtnVolver.Location = new Point(10, 12);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(40, 40);
            BtnVolver.SizeMode = PictureBoxSizeMode.Zoom;
            BtnVolver.TabIndex = 4;
            BtnVolver.TabStop = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(12, 163);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);
            panel3.Size = new Size(253, 10);
            panel3.TabIndex = 10;
            // 
            // FormularioEditarContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 518);
            Controls.Add(BtnVolver);
            Controls.Add(panel3);
            Controls.Add(LblError);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmbTipoContacto);
            Controls.Add(TxtFijo);
            Controls.Add(TxtNumero);
            Controls.Add(TxtApellido);
            Controls.Add(TxtNombre);
            Controls.Add(BtnAceptar);
            Name = "FormularioEditarContacto";
            Text = "FormularioEditarContacto";
            Load += FormularioEditarContacto_Load;
            ((System.ComponentModel.ISupportInitialize)BtnVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAceptar;
        private TextBox TxtNombre;
        private TextBox TxtApellido;
        private TextBox TxtNumero;
        private TextBox TxtFijo;
        private ComboBox CmbTipoContacto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label LblError;
        private PictureBox BtnVolver;
        private Panel panel3;
    }
}