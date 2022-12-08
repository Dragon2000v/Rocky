using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Имя")]
        [Required]
        public string Name { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Порядок отображения должент быть больше 0")]
        [DisplayName("Отобразить заказ")]
        [Required]
        public int DisplayOrder { get; set; }
    }
}
