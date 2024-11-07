using GestorDeContactos.Views; 
using GestorDeContactos.Data;
using GestorDeContactos.Data.Repository;
using Microsoft.VisualBasic;

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

        #region eventos click
        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            FormularioAgregarContacto formAgregar = new(_contactoRepository);
            formAgregar.Show();
        }

        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            if (cellClicked)
            {
                FormularioEditarContacto formEditar = new(_contactoRepository, valorPrimerColumna); // agarrar el id de la fila que el usuario selecciono y pasarselo al form de editar, utilizarlo tambien para rellenar campos automaticamente
                formEditar.Show();
            }
            else LblError.Text = "Clickea en una fila para editar el contacto!";
        }

        private void DgvContactos_CellClick(object sender, DataGridViewCellEventArgs e) // maneja el evento click en una celda
        {
            valorCelda = DgvContactos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); // obtiene el valor de la celda
            valorPrimerColumna = Convert.ToInt32(DgvContactos.Rows[e.RowIndex].Cells[0].Value); // obtiene el valor de la primera columna (id)
            cellClicked = true; // hay una celda clickeada
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


    }
}
