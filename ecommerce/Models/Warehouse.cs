using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ecommerce.Models
{
    public class Warehouse
    {
        [Key]
        public int WarehouseId { get; set; }

        [Display(Name = "Compañia")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Index("Warehouse_CompanyId_Name_Index", 1, IsUnique = true)]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters")]
        [Display(Name = "Bodega")]        
        [Index("Warehouse_CompanyId_Name_Index",2, IsUnique = true)]
        public string Name { get; set; }
       

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(20, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters")]
        public string Address { get; set; }
      
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Display(Name = "Departamento")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Display(Name = "Ciudad")]
        public int CityId { get; set; }

        public virtual City City { get; set; }

        public virtual Department Department { get; set; }

        public virtual Company Company { get; set; }


    }
}