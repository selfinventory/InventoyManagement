using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class OrderDetailsModel
    {
        public OrderDetailsModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
        public long OrderDetailsID { get; set; }
        public PartsModel OrderDetailsParts { get; set; }
        public float OrderQTY { get; set; }

        public float pricePerItem { get; set; }
        public string remarks { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
