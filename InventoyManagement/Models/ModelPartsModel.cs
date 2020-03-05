using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class ModelPartsModel
    {
        public ModelPartsModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
        [Key]
        public string ModelPartsID { get; set; }
        public string ModelPartsDesc { get; set; }
        public string ModelPartsYear { get; set; }
        public string ModelPartsCC { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
      public ICollection<PartsGroupModel> PartsGroup { get; set; }
        public ICollection<PartsModel> Parts { get; }=new List<PartsModel>();
    }
}
