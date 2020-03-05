using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class FinanceModel
    {
        public FinanceModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
        [Key]
        public string FinanceGLID { get; set; }
        public string FinanceGLDesc { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public SuppliersModel SupplierInfo { get; set; }
    }
}
