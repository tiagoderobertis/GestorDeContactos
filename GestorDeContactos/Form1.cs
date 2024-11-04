using GestorDeContactos.Views; 
using GestorDeContactos.Data;
using GestorDeContactos.Data.Repository;

namespace GestorDeContactos
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDBContext _dbContext;
        public Form1(ApplicationDBContext context)
        {
            _dbContext = context;
            InitializeComponent();
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            FormularioAgregarContacto formAgregar = new(new ContactoRepository(_dbContext));
            formAgregar.Show();
        }

        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            FormularioEditarContacto formEditar = new();
            formEditar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContactoRepository contactoRepository = new ContactoRepository(_dbContext);
            DgvContactos.DataSource = contactoRepository.ObtenerTodos();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ContactoRepository contactoRepository = new ContactoRepository(_dbContext);
            DgvContactos.DataSource = contactoRepository.ObtenerTodos();
        }
    }
}
