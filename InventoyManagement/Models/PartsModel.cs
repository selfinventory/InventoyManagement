using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class PartsModel
    {
        public PartsModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }

        [Key]
        public string PartsID { get; set; }
        public string PartsDesc { get; set; }
        public string PartsQty { get; set; }
        public string PartsPrice { get; set; }
        public string PartsSellPrice { get; set; }
        public string PartsManufactureYear{ get; set; }
        public string PartsRackNo{ get; set; }
        public FinanceModel FinanceInfo { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public int PartsStatus { get; set; }
        public ICollection<ModelPartsModel> Model { get; } = new List<ModelPartsModel>();
    }
}
