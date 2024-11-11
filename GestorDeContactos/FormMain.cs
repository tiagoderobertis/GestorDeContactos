using GestorDeContactos.Views; 
using GestorDeContactos.Data;
using GestorDeContactos.Data.Repository;
using Microsoft.VisualBasic;
using GestorDeContactos.Data.Models;

namespace GestorDeContactos
{
    public partial class FormMain : Form
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ContactoRepository _contactoRepository;

        string valorCelda = string.Empty;
        int valorPrimerColumna = 0;
        bool cellClicked = false;


        public FormMain(ApplicationDBContext context)
        {
            _dbContext = context;
            InitializeComponent();
            _contactoRepository = new(_dbContext);
        }

        public FormMain(ContactoRepository contactoRepository)
        {
            _contactoRepository = contactoRepository;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DgvContactos.DataSource = _contactoRepository.ObtenerTodos();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DgvContactos.DataSource = _contactoRepository.ObtenerTodos();
        }

        private Form formActivo = null;
        public void abrirFormHijo(Form formHijo)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;

            formHijo.FormClosed += (s, args) =>
            {
                DgvContactos.DataSource = _contactoRepository.ObtenerTodos();
                DgvContactos.Refresh(); // Refresca el DataGridView después de cerrar el formulario hijo
            };

            // Configura el formulario hijo
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // Añade el formulario hijo al panel padre
            this.PnlContainer.Controls.Add(formHijo);
            this.PnlContainer.Tag = formHijo;

            // Muestra el formulario hijo
            formHijo.BringToFront();
            formHijo.Show();
        }

        #region eventos click
        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            FormularioAgregarContacto formAgregar = new(_contactoRepository);
            abrirFormHijo(formAgregar);
        }

        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            if (cellClicked)
            {
                FormularioEditarContacto formEditar = new(_contactoRepository, valorPrimerColumna); // Se llama al form editar, se le pasa el id de la fila seleccionada
                abrirFormHijo(formEditar);
            }
            else LblError.Text = "Clickea en una fila para editar el contacto!";
        }

        private void DgvContactos_CellClick(object sender, DataGridViewCellEventArgs e) // maneja el evento click en una celda
        {
            try
            {
                valorCelda = DgvContactos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); // obtiene el valor de la celda
                valorPrimerColumna = Convert.ToInt32(DgvContactos.Rows[e.RowIndex].Cells[0].Value); // obtiene el valor de la primera columna (id)
                cellClicked = true; // hay una celda clickeada
            }
            catch
            {
                LblError.Text = "Haga click en la celda correcta";
            }
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            if (cellClicked)
            {

                DialogResult result = MessageBox.Show(
                    "Esta seguro que desea eliminar este contacto?", // texto
                    "Confirmar eliminacion", // titulo del msgbox
                    MessageBoxButtons.YesNo, // agrega botones si y no
                    MessageBoxIcon.Warning
                    );

                if (result == DialogResult.Yes)
                {
                    _contactoRepository.Eliminar(valorPrimerColumna); // metodo eliminar del repo

                    DgvContactos.DataSource = null;
                    DgvContactos.DataSource = _contactoRepository.ObtenerTodos();
                    DgvContactos.Refresh(); // reset dgv
                }
            }
            else LblError.Text = "Clickea una fila para eliminar el contacto";
        }

        #endregion


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panelBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BtnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            List<Contacto> listaPorNombres = _contactoRepository.ObtenerPorNombre(TxtBuscarPorNombre.Text);
            DgvContactos.DataSource = listaPorNombres;
        }
    }
}
