namespace GestorDeContactos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            contactoBindingSource = new BindingSource(components);
            btnAgregarContacto = new PictureBox();
            btnEliminarContacto = new PictureBox();
            btnEditarContacto = new PictureBox();
            DgvContactos = new DataGridView();
            idContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroTelefonoContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroFijoContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contactoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregarContacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminarContacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditarContacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvContactos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(75, 22);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 0;
            label1.Text = "Gestor de Contactos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // contactoBindingSource
            // 
            contactoBindingSource.DataSource = typeof(Data.Models.Contacto);
            // 
            // btnAgregarContacto
            // 
            btnAgregarContacto.Image = (Image)resources.GetObject("btnAgregarContacto.Image");
            btnAgregarContacto.Location = new Point(12, 456);
            btnAgregarContacto.Name = "btnAgregarContacto";
            btnAgregarContacto.Size = new Size(50, 50);
            btnAgregarContacto.SizeMode = PictureBoxSizeMode.Zoom;
            btnAgregarContacto.TabIndex = 3;
            btnAgregarContacto.TabStop = false;
            btnAgregarContacto.Click += btnAgregarContacto_Click;
            // 
            // btnEliminarContacto
            // 
            btnEliminarContacto.Image = (Image)resources.GetObject("btnEliminarContacto.Image");
            btnEliminarContacto.Location = new Point(228, 456);
            btnEliminarContacto.Name = "btnEliminarContacto";
            btnEliminarContacto.Size = new Size(37, 35);
            btnEliminarContacto.SizeMode = PictureBoxSizeMode.Zoom;
            btnEliminarContacto.TabIndex = 3;
            btnEliminarContacto.TabStop = false;
            // 
            // btnEditarContacto
            // 
            btnEditarContacto.Image = (Image)resources.GetObject("btnEditarContacto.Image");
            btnEditarContacto.Location = new Point(68, 456);
            btnEditarContacto.Name = "btnEditarContacto";
            btnEditarContacto.Size = new Size(50, 50);
            btnEditarContacto.SizeMode = PictureBoxSizeMode.Zoom;
            btnEditarContacto.TabIndex = 3;
            btnEditarContacto.TabStop = false;
            btnEditarContacto.Click += btnEditarContacto_Click;
            // 
            // DgvContactos
            // 
            DgvContactos.AllowUserToAddRows = false;
            DgvContactos.AllowUserToDeleteRows = false;
            DgvContactos.AutoGenerateColumns = false;
            DgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvContactos.Columns.AddRange(new DataGridViewColumn[] { idContactoDataGridViewTextBoxColumn, nombreContactoDataGridViewTextBoxColumn, apellidoContactoDataGridViewTextBoxColumn, numeroTelefonoContactoDataGridViewTextBoxColumn, numeroFijoContactoDataGridViewTextBoxColumn, tipoContactoDataGridViewTextBoxColumn });
            DgvContactos.DataSource = contactoBindingSource;
            DgvContactos.Location = new Point(12, 78);
            DgvContactos.Name = "DgvContactos";
            DgvContactos.ReadOnly = true;
            DgvContactos.Size = new Size(253, 372);
            DgvContactos.TabIndex = 4;
            // 
            // idContactoDataGridViewTextBoxColumn
            // 
            idContactoDataGridViewTextBoxColumn.DataPropertyName = "IdContacto";
            idContactoDataGridViewTextBoxColumn.HeaderText = "IdContacto";
            idContactoDataGridViewTextBoxColumn.Name = "idContactoDataGridViewTextBoxColumn";
            idContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreContacto";
            nombreContactoDataGridViewTextBoxColumn.HeaderText = "NombreContacto";
            nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoContactoDataGridViewTextBoxColumn
            // 
            apellidoContactoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoContacto";
            apellidoContactoDataGridViewTextBoxColumn.HeaderText = "ApellidoContacto";
            apellidoContactoDataGridViewTextBoxColumn.Name = "apellidoContactoDataGridViewTextBoxColumn";
            apellidoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroTelefonoContactoDataGridViewTextBoxColumn
            // 
            numeroTelefonoContactoDataGridViewTextBoxColumn.DataPropertyName = "NumeroTelefonoContacto";
            numeroTelefonoContactoDataGridViewTextBoxColumn.HeaderText = "NumeroTelefonoContacto";
            numeroTelefonoContactoDataGridViewTextBoxColumn.Name = "numeroTelefonoContactoDataGridViewTextBoxColumn";
            numeroTelefonoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroFijoContactoDataGridViewTextBoxColumn
            // 
            numeroFijoContactoDataGridViewTextBoxColumn.DataPropertyName = "NumeroFijoContacto";
            numeroFijoContactoDataGridViewTextBoxColumn.HeaderText = "NumeroFijoContacto";
            numeroFijoContactoDataGridViewTextBoxColumn.Name = "numeroFijoContactoDataGridViewTextBoxColumn";
            numeroFijoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoContactoDataGridViewTextBoxColumn
            // 
            tipoContactoDataGridViewTextBoxColumn.DataPropertyName = "TipoContacto";
            tipoContactoDataGridViewTextBoxColumn.HeaderText = "TipoContacto";
            tipoContactoDataGridViewTextBoxColumn.Name = "tipoContactoDataGridViewTextBoxColumn";
            tipoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 518);
            Controls.Add(DgvContactos);
            Controls.Add(btnEditarContacto);
            Controls.Add(btnEliminarContacto);
            Controls.Add(btnAgregarContacto);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)contactoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregarContacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminarContacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditarContacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private BindingSource contactoBindingSource;
        private PictureBox btnAgregarContacto;
        private PictureBox btnEliminarContacto;
        private PictureBox btnEditarContacto;
        private DataGridView DgvContactos;
        private DataGridViewTextBoxColumn idContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroTelefonoContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroFijoContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoContactoDataGridViewTextBoxColumn;
    }
}
