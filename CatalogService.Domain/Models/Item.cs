using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Domain.Models
{
    public class Item
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int CategoryId { get; set; }

    }
}
