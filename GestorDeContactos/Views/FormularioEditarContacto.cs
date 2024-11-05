using GestorDeContactos.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeContactos.Views
{
    public partial class FormularioEditarContacto : Form
    {

        private readonly ContactoRepository _contactoRepository;

        public FormularioEditarContacto(ContactoRepository contactoRepository, int id)
        {
            InitializeComponent();
            _contactoRepository = contactoRepository;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
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
            }
            else
            {
                //_contactoRepository.Editar(, TxtNombre.Text, TxtApellido.Text, numeroContacto, fijoContacto, CmbTipoContacto.Text);
            }
        }
    }
}
