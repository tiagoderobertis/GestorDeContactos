using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestorDeContactos.Data.Models
{
    public class Contacto
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdContacto { get; set; }
        [Required] 
        [StringLength(50)]
        public string NombreContacto { get; set; } = string.Empty;
        //optional
        [StringLength(50)]
        public string? ApellidoContacto { get; set; } = string.Empty;
        //optional
        [StringLength(20)]
        public long? NumeroTelefonoContacto { get; set; }
        //optional
        public long? NumeroFijoContacto { get; set;}
        [Required]
        [StringLength(20)]
        public string TipoContacto { get;set; } = string.Empty;
        
    }
}
