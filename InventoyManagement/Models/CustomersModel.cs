using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static InventoyManagement.SystemRef;

namespace InventoyManagement.Models
{
    public class CustomersModel
    {
        public CustomersModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
            StatusList = GetRankSelectList();
        }
        [Key]
        [DisplayName("IC No")]
        [Required]
        public string CustomerID { get; set; }
        [Required]
        [DisplayName("Name")]
        public string CustomerName { get; set; }
        [DisplayName("Birth Date")]
        public DateTime? CustomerDateOfBirth { get; set; }
        [DisplayName("Photo")]
        public byte[] CustomerPhoto { get; set; }
        [Required]
        [DisplayName("Address 1")]
        public string CustomerAdd1 { get; set; }
        [DisplayName("Address 2")]
        public string CustomerAdd2 { get; set; }
        [DisplayName("Address 3")]
        public string CustomerAdd3 { get; set; }
        [DisplayName("Address 4")]
        public string CustomerAdd4 { get; set; }
        [Required]
        [DisplayName("City")]
        public string CustomerCity { get; set; }
        [Required]
        [DisplayName("State")]
        public string CustomerState { get; set; }
        [DisplayName("Country")]
        public string CustomerCounty { get; set; }
        [DisplayName("Email")]
        public string CustomerEmail { get; set; }
        [DisplayName("Tel Office")]

        public string CustomerTelOffice { get; set; }
        [DisplayName("Tel Mobile")]
        public string CustomerTelMobile { get; set; }
        [DisplayName("Date Created")]
        public DateTime? DateCreated { get; set; }
        [DisplayName("Date Updated")]
        public DateTime? DateUpdated { get; set; }
       
        [DisplayName("Status")]
        public StatusE Status { get; set; }
      
        public ICollection<CompaniesModel> Company { get; } = new List<CompaniesModel>();
        [NotMapped]
        public SelectList StatusList { get; set; }
      
        public static SelectList GetRankSelectList()
        {

            var enumValues = Enum.GetValues(typeof(StatusE)).Cast<StatusE>().Select(e => new { Value = e.ToString(), Text = e.ToString() }).ToList();

            return new SelectList(enumValues, "Value", "Text", "");
        }
    }
  
}
