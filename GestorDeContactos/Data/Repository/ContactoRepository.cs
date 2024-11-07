using GestorDeContactos.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestorDeContactos.Data.Repository
{
    public class ContactoRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public ContactoRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Contacto> ObtenerTodos()
        {
            return _dbContext.Contactos.ToList();
        }

        public void Agregar(string nombre, string? apellido, int? numero, int? numeroFijo, string tipoContacto)
        {

            var nuevoContacto = new Contacto()
            {
                NombreContacto = nombre,
                ApellidoContacto = apellido,
                NumeroTelefonoContacto = numero,
                NumeroFijoContacto = numeroFijo,
                TipoContacto = tipoContacto
            };

            _dbContext.Contactos.Add(nuevoContacto);
            _dbContext.SaveChanges();
        }

        public void Editar(int id, string nombre, string? apellido, int? numero, int? numeroFijo, string tipoContacto)
        {
            var verificarExistencia = _dbContext.Contactos.FirstOrDefault(x => x.IdContacto == id);
            if (verificarExistencia != null)
            {
                verificarExistencia.NombreContacto = nombre;
                verificarExistencia.ApellidoContacto = apellido;
                verificarExistencia.NumeroTelefonoContacto = numero;
                verificarExistencia.NumeroFijoContacto= numeroFijo;
                verificarExistencia.TipoContacto = tipoContacto;

                _dbContext.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            var verificarExistencia = _dbContext.Contactos.FirstOrDefault(x => x.IdContacto == id);
            if (verificarExistencia != null)
            {
                _dbContext.Contactos.Remove(verificarExistencia);
                _dbContext.SaveChanges();
            }
        }

    }
}
