using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalog.Application.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is requeried")]
        public Guid CategoryId { get; set; }

        [Required(ErrorMessage = "The field {0} is requeried")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is requeried")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field {0} is requeried")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "The field {0} is requeried")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The field {0} is requeried")]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "The field {0} is requeried")]
        public string Image { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The field {0} needs to have the mininum value of {1}")]
        [Required(ErrorMessage = "The field {0} is requeried")]
        public int Quantity { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The field {0} needs to have the mininum value of {1}")]
        [Required(ErrorMessage = "The field {0} is requeried")]
        public int Height { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The field {0} needs to have the mininum value of {1}")]
        [Required(ErrorMessage = "The field {0} is requeried")]
        public int Width { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The field {0} needs to have the mininum value of {1}")]
        [Required(ErrorMessage = "The field {0} is requeried")]
        public int Depth { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
