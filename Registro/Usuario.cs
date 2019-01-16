//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Usuario
    {

        [Required(ErrorMessage = "Introduzca un correo")]
        [DisplayName("Correo")]
        public string correo { get; set; }
        [Required(ErrorMessage = "Introduzca una contraseña")]
        [DataType(DataType.Password)]
        [DisplayName("Contraseña")]

        public string contraseña { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("Confirmar contraseña")]
        [Compare("contraseña")]
        public string confirmedPassword { get; set; }
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        [DisplayName("Marcar esta opción si desea una cuenta de Guía")]
        public bool tipo { get; set; }
    }
}
