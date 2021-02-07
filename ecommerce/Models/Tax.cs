using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ecommerce.Models
{
    public class Tax
    {
        [Key]
        public int TaxId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters")]
        [Index("Tax_CompanyId_Description_Index", 2, IsUnique = true)]
        [Display(Name = "Impuesto")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(0,1, ErrorMessage = "You must select a {0} between {1} and {2}")]
        [DisplayFormat(DataFormatString = "{0:P2}",ApplyFormatInEditMode = false)]
        public double Rate { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Index("Tax_CompanyId_Description_Index", 1, IsUnique = true)]
        [Display(Name = "Compañia")]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}