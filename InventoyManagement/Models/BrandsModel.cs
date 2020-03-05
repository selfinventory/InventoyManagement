using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class BrandsModel
    {
        [Key]
        public string BrandID { get; set; }
        public string BrandName { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public BrandsModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
        public int BrandStatus { get; set; }
        public ICollection<ModelPartsModel> ModelPartsBrands { get; set; }
    }
}
