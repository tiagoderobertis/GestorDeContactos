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
            _contactoRepository = contactoRepository;
            InitializeComponent();
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            int numeroContacto = 0;
            if (TxtNumero.Text != string.Empty)
            {
                int.TryParse(TxtNumero.Text, out numeroContacto);
            }

            int fijoContacto = 0;
            if (TxtFijo.Text != string.Empty)
            {
                int.TryParse(TxtFijo.Text, out fijoContacto);
            }

            if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrEmpty(CmbTipoContacto.Text))
            {
                LblError.Text = "Rellena los campos faltantes: Nombre o Tipo de Contacto";
            } else { 
                _contactoRepository.Agregar(TxtNombre.Text, TxtApellido.Text, numeroContacto, fijoContacto, CmbTipoContacto.Text);
            }

        }
    }
}
