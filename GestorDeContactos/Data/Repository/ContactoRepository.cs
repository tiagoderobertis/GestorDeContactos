﻿using GestorDeContactos.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

        public List<Contacto> ObtenerPorId(int id)
        {
            return _dbContext.Contactos.Where(x => x.IdContacto == id).ToList();
        }

        public List<Contacto> ObtenerPorNombre(string nombre)
        {
            string toLowerName = nombre.ToLower();
            var verificacion = _dbContext.Contactos.Any(x => x.NombreContacto.ToLower().Contains(toLowerName));

            if (verificacion)
            {
                var resultado = _dbContext.Contactos.Where(x => x.NombreContacto.ToLower().Contains(toLowerName)).ToList();
                return resultado;
            }
            else return new List<Contacto>();
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
                verificarExistencia.NumeroFijoContacto = numeroFijo;
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

        public string SeleccionarColumnaPorId(string Columna, int id)
        {

            switch (Columna)
            {
                case "NombreContacto":
                    return _dbContext.Contactos
                                .Where(x => x.IdContacto == id)
                                .Select(x => x.NombreContacto).FirstOrDefault();
                case "ApellidoContacto":
                    return _dbContext.Contactos
                                .Where(x => x.IdContacto == id)
                                .Select(x => x.ApellidoContacto).FirstOrDefault();
                    
                case "NumeroTelefonoContacto":
                    return _dbContext.Contactos
                                .Where(x => x.IdContacto == id)
                                .Select(x => x.NumeroTelefonoContacto).FirstOrDefault().ToString();
                    
                case "NumeroFijoContacto":
                    return _dbContext.Contactos
                                .Where(x => x.IdContacto == id)
                                .Select(x => x.NumeroFijoContacto).FirstOrDefault().ToString();
                    
                case "TipoContacto":
                    return _dbContext.Contactos
                                .Where(x => x.IdContacto == id)
                                .Select(x => x.TipoContacto).FirstOrDefault();
                    
                default: return ""; 
                    
            }

        }
    }
}
