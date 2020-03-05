using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class OrdersModel
    {
        public OrdersModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
        [Key]
        public string OrderID { get; set; }
        public UsersModel UserInfo{ get; set; }
        public CustomersModel Customer { get; set; }
        public CompaniesModel Company { get; set; }
        public int OrderStatus { get; set; }
        public float CostValue { get; set; }
        public float TaxValue { get; set; }
        public float TotalValue { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public ICollection<OrderDetailsModel> OrderList { get; set; }
        public InvoicesModel Invoices { get; set; }
        public TaxModel Tax { get; set; }
    }
}
