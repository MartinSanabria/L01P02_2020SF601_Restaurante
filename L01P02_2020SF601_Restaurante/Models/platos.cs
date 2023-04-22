using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2020SF601_Restaurante.Models
{
    public class platos
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int platoId { get; set; }
        public string? nombrePlato { get; set; }
        public decimal precio { get; set; }

    }
}
