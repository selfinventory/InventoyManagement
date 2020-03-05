using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class InvoicesModel
    {
        public InvoicesModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
        [Key]
        public int InvoiceID { get; set; }
   
        public int CustomerID { get; set; }
        public int CompanyID { get; set; }
        public float TotalValue{ get; set; }
        public float DiscountValue { get; set; }
        public float TaxValue { get; set; }
        public float TaxPercentage { get; set; }
        public float CostValue { get; set; }
        public DateTime? DateInvoice { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
