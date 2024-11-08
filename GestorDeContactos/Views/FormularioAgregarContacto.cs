using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorDeContactos.Data;
using GestorDeContactos.Data.Repository;

namespace GestorDeContactos.Views
{
    public partial class FormularioAgregarContacto : Form
    {
        private ContactoRepository _contactoRepository;
        public FormularioAgregarContacto(ContactoRepository contactoRepository)
        {
            _contactoRepository = contactoRepository; // inyeccion de dependencia
            InitializeComponent();
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            int numeroContacto = 0; // es necesario inicializar la variable
            if (TxtNumero.Text != string.Empty)
            {
                try
                {
                    numeroContacto = int.Parse(TxtNumero.Text);
                }
                catch
                {
                        LblError.Text = "Ingresa un numero de telefono valido";
                }
            }

            int fijoContacto = 0;
            if (TxtFijo.Text != string.Empty)
            {
                try
                {
                    fijoContacto = int.Parse(TxtFijo.Text);
                }
                catch
                {
                    LblError.Text = "Ingresa un telefono fijo valido";
                }
            }

            if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrEmpty(TxtNumero.Text))
            {
                LblError.Text = "Rellena los campos faltantes"; // si los txt estan vacios error
            } else if(string.IsNullOrWhiteSpace(TxtFijo.Text))
            {
                _contactoRepository.Agregar(TxtNombre.Text, TxtApellido.Text, numeroContacto, null, CmbTipoContacto.Text); // se le pasa null al numero fijo al metodo editar
            }
            else
            {
                _contactoRepository.Agregar(TxtNombre.Text, TxtApellido.Text, numeroContacto, fijoContacto, CmbTipoContacto.Text); // si todo esta bien metodo add
            }

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
