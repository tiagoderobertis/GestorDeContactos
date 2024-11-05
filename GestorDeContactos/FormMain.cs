using GestorDeContactos.Views; 
using GestorDeContactos.Data;
using GestorDeContactos.Data.Repository;

namespace GestorDeContactos
{
    public partial class FormMain : Form
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ContactoRepository _contactoRepository;
        public FormMain(ApplicationDBContext context, ContactoRepository contactoRepository)
        {
            _dbContext = context;
            InitializeComponent();
            _contactoRepository = contactoRepository;
            _contactoRepository = new(_dbContext);
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            FormularioAgregarContacto formAgregar = new(_contactoRepository);
            formAgregar.Show();
        }

        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            FormularioEditarContacto formEditar = new(_contactoRepository); // agarrar el id de la fila que el usuario selecciono y pasarselo al form de editar, utilizarlo tambien para rellenar campos automaticamente
            formEditar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DgvContactos.DataSource = _contactoRepository.ObtenerTodos();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
            DgvContactos.DataSource = _contactoRepository.ObtenerTodos();
        }
    }
}
