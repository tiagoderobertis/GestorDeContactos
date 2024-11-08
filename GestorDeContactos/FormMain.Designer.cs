namespace GestorDeContactos
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnAgregarContacto = new PictureBox();
            btnEliminarContacto = new PictureBox();
            btnEditarContacto = new PictureBox();
            DgvContactos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            contactoBindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            panel2 = new Panel();
            LblError = new Label();
            PnlContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregarContacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminarContacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditarContacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvContactos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contactoBindingSource1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            PnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 0;
            label1.Text = "Gestor de Contactos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnAgregarContacto
            // 
            btnAgregarContacto.Image = (Image)resources.GetObject("btnAgregarContacto.Image");
            btnAgregarContacto.Location = new Point(57, 428);
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
            btnEliminarContacto.Location = new Point(169, 428);
            btnEliminarContacto.Name = "btnEliminarContacto";
            btnEliminarContacto.Size = new Size(44, 50);
            btnEliminarContacto.SizeMode = PictureBoxSizeMode.Zoom;
            btnEliminarContacto.TabIndex = 3;
            btnEliminarContacto.TabStop = false;
            btnEliminarContacto.Click += btnEliminarContacto_Click;
            // 
            // btnEditarContacto
            // 
            btnEditarContacto.Image = (Image)resources.GetObject("btnEditarContacto.Image");
            btnEditarContacto.Location = new Point(113, 428);
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
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            DgvContactos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DgvContactos.AutoGenerateColumns = false;
            DgvContactos.BorderStyle = BorderStyle.None;
            DgvContactos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvContactos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            DgvContactos.DataSource = contactoBindingSource1;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvContactos.DefaultCellStyle = dataGridViewCellStyle6;
            DgvContactos.EnableHeadersVisualStyles = false;
            DgvContactos.Location = new Point(12, 6);
            DgvContactos.Name = "DgvContactos";
            DgvContactos.ReadOnly = true;
            DgvContactos.RowHeadersVisible = false;
            DgvContactos.Size = new Size(253, 416);
            DgvContactos.TabIndex = 4;
            DgvContactos.CellClick += DgvContactos_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdContacto";
            dataGridViewTextBoxColumn1.HeaderText = "IdContacto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "NombreContacto";
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "ApellidoContacto";
            dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "NumeroTelefonoContacto";
            dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "NumeroFijoContacto";
            dataGridViewTextBoxColumn5.HeaderText = "Fijo";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "TipoContacto";
            dataGridViewTextBoxColumn6.HeaderText = "Tipo de Contacto";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // contactoBindingSource1
            // 
            contactoBindingSource1.DataSource = typeof(Data.Models.Contacto);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 49);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(LblError);
            panel2.Location = new Point(0, 484);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 25);
            panel2.TabIndex = 6;
            // 
            // LblError
            // 
            LblError.AutoSize = true;
            LblError.ForeColor = Color.Red;
            LblError.Location = new Point(3, 1);
            LblError.Name = "LblError";
            LblError.Size = new Size(43, 15);
            LblError.TabIndex = 0;
            LblError.Text = "Errores";
            // 
            // PnlContainer
            // 
            PnlContainer.Controls.Add(DgvContactos);
            PnlContainer.Controls.Add(panel2);
            PnlContainer.Controls.Add(btnAgregarContacto);
            PnlContainer.Controls.Add(btnEditarContacto);
            PnlContainer.Controls.Add(btnEliminarContacto);
            PnlContainer.Dock = DockStyle.Fill;
            PnlContainer.Location = new Point(0, 49);
            PnlContainer.Name = "PnlContainer";
            PnlContainer.Size = new Size(277, 509);
            PnlContainer.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 558);
            Controls.Add(PnlContainer);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Gestor de Contactos";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregarContacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminarContacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditarContacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvContactos).EndInit();
            ((System.ComponentModel.ISupportInitialize)contactoBindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PnlContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BindingSource contactoBindingSource1;
        private Panel panel1;
        private Panel panel2;
        private Label LblError;
        private Panel PnlContainer;
    }
}
