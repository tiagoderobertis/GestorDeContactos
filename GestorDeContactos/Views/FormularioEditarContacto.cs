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
        private int _id;

        public FormularioEditarContacto(ContactoRepository contactoRepository, int id)
        {
            _id = id;
            InitializeComponent();
            _contactoRepository = contactoRepository;
        }

        private void FormularioEditarContacto_Load(object sender, EventArgs e) // rellena los campos segun el contenido de la tabla con el id de la fila seleccionada
        {
            TxtNombre.Text = _contactoRepository.SeleccionarColumnaPorId("NombreContacto", _id);
            TxtApellido.Text = _contactoRepository.SeleccionarColumnaPorId("ApellidoContacto", _id);
            TxtNumero.Text = _contactoRepository.SeleccionarColumnaPorId("NumeroTelefonoContacto", _id);
            TxtFijo.Text = _contactoRepository.SeleccionarColumnaPorId("NumeroFijoContacto", _id);
            CmbTipoContacto.Text = _contactoRepository.SeleccionarColumnaPorId("TipoContacto", _id);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
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
                } catch
                {
                    LblError.Text = "Ingresa un telefono fijo valido";
                }
            }

            if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrEmpty(TxtNumero.Text))
            {
                LblError.Text = "Rellena los campos faltantes";
            }
            else if (string.IsNullOrWhiteSpace(TxtFijo.Text))
            {
                _contactoRepository.Editar(_id, TxtNombre.Text, TxtApellido.Text, numeroContacto, null, CmbTipoContacto.Text);
            }
            else
            {
                _contactoRepository.Editar(_id, TxtNombre.Text, TxtApellido.Text, numeroContacto, fijoContacto, CmbTipoContacto.Text);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
