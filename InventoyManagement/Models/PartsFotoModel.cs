using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class PartsFotoModel
    {
        public PartsFotoModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
        [Key]
        public string PartsFotoID { get; set; }
        public string PartsFotoDesc { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public byte[] PartsStatusImage { get; set; }
        public int PartsFotoStatus { get; set; }
    }
}
