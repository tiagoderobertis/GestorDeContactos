namespace GestorDeContactos.Views
{
    partial class FormularioAgregarContacto
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
            CmbTipoContacto = new ComboBox();
            TxtFijo = new TextBox();
            TxtNumero = new TextBox();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            btnAgregarContacto = new Button();
            Nombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LblError = new Label();
            SuspendLayout();
            // 
            // CmbTipoContacto
            // 
            CmbTipoContacto.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTipoContacto.FormattingEnabled = true;
            CmbTipoContacto.Items.AddRange(new object[] { "Personal", "Empresa" });
            CmbTipoContacto.Location = new Point(11, 279);
            CmbTipoContacto.Name = "CmbTipoContacto";
            CmbTipoContacto.Size = new Size(121, 23);
            CmbTipoContacto.TabIndex = 8;
            // 
            // TxtFijo
            // 
            TxtFijo.Location = new Point(12, 222);
            TxtFijo.Name = "TxtFijo";
            TxtFijo.Size = new Size(120, 23);
            TxtFijo.TabIndex = 4;
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(12, 167);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(121, 23);
            TxtNumero.TabIndex = 5;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(12, 102);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(121, 23);
            TxtApellido.TabIndex = 6;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(11, 48);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(121, 23);
            TxtNombre.TabIndex = 7;
            // 
            // btnAgregarContacto
            // 
            btnAgregarContacto.Location = new Point(93, 395);
            btnAgregarContacto.Name = "btnAgregarContacto";
            btnAgregarContacto.Size = new Size(83, 24);
            btnAgregarContacto.TabIndex = 3;
            btnAgregarContacto.Text = "Agregar";
            btnAgregarContacto.UseVisualStyleBackColor = true;
            btnAgregarContacto.Click += btnAgregarContacto_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(11, 30);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 9;
            Nombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 204);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 9;
            label4.Text = "Fijo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 261);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 9;
            label5.Text = "Tipo de contacto";
            // 
            // LblError
            // 
            LblError.AutoSize = true;
            LblError.ForeColor = Color.Red;
            LblError.Location = new Point(12, 494);
            LblError.Name = "LblError";
            LblError.Size = new Size(43, 15);
            LblError.TabIndex = 9;
            LblError.Text = "Errores";
            // 
            // FormularioAgregarContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 518);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LblError);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(CmbTipoContacto);
            Controls.Add(TxtFijo);
            Controls.Add(TxtNumero);
            Controls.Add(TxtApellido);
            Controls.Add(TxtNombre);
            Controls.Add(btnAgregarContacto);
            Name = "FormularioAgregarContacto";
            Text = "FormularioAgregarContacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbTipoContacto;
        private TextBox TxtFijo;
        private TextBox TxtNumero;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private Button btnAgregarContacto;
        private Label Nombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label LblError;
    }
}