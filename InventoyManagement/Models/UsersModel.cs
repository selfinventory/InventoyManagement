using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class UsersModel
    {
        public UsersModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
        [Key]
        public string UserID { get; set; }
        public string UserInfo { get; set; }
        public byte[] UserPassword { get; set; }
        public int Retry { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public int UserGroup { get; set; }
        public int UserStatus { get; set; }
    }
}
