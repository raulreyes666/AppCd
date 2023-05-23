using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCd.Shared.Modelo
{
    public class Stock
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre no puede estar vacio"), MaxLength(100)]
        public string? NombreBotella { get; set; }

        [Required(ErrorMessage = "El nombre del proovedor no puede estar vacio"), MaxLength(100)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Introduzca un numero valido"), MaxLength(100)]
        public int CantidadBotellas { get; set; }

    }
}
