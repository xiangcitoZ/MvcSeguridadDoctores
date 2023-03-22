﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcSeguridadDoctores.Models
{
    [Table("ENFERMO")]
    public class Enfermo
    {
        [Key]
        [Column("INSCRIPCION")]
        public int Inscripcion { get; set; }
        [Column("APELLIDO")]
        public string Apellido { get; set; }
        [Column("DIRECCION")]
        public string Direccion { get; set; }
        [Column("FECHA_NAC")]
        public DateTime FechaNacimiento { get; set; }
        [Column("S")]
        public string Sexo { get; set; }
        [Column("NSS")]
        public string SeguridadSocial { get; set; }
    }
}
