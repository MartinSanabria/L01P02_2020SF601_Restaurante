using System.ComponentModel.DataAnnotations;

namespace L01P02_2020SF601_Restaurante.Models
{
    public class motoristas
    {
        [Key]
        public int motoristaId { get; set; }
        public string? nombreMotorista { get; set; }

    }
}
