using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class PartsGroupModel
    {
        public PartsGroupModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
        [Key]
        public string PartsGroupID { get; set; }
        public string PartsGroupDesc { get; set; }
        public byte[] PartsGroupImage { get; set; }
     

        public ICollection<PartsModel> PartsList { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public int PartsStatus { get;set;}
    }
}
