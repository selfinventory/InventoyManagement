using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class SuppliersModel
    {
        public SuppliersModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
        [Key]
        public int SupplierRegistrationID { get; set; }
        [Required]
        public string SupplierName { get; set; }
        [Required]
        public string SupplierAdd1 { get; set; }
        public string SupplierAdd2 { get; set; }
        public string SupplierAdd3 { get; set; }
        public string SupplierAdd4 { get; set; }
        [Required]
        public string SupplierCity { get; set; }
        [Required]
        public string SupplierState { get; set; }
        public string SupplierCounty { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierTelOffice { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public int SupplierStatus { get; set; }
    }
}
