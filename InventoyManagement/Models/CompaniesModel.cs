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
    public class CompaniesModel
    {
        public CompaniesModel()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
            StatusList = GetRankSelectList();
        }
        [Key]
        [Required]
        [DisplayName("SSM NO")]
        public string CompanyRegistrationID { get; set; }
        [Required]
        [DisplayName("COMPANY NAME")]
        public string CompanyName { get; set; }
        [Required]
        [DisplayName("Address 1")]
        public string CompanyAdd1 { get; set; }
        [DisplayName("Address 2")]
        public string CompanyAdd2 { get; set; }
        [DisplayName("Address 3")]
        public string CompanyAdd3 { get; set; }
        [DisplayName("Address 4")]
        public string CompanyAdd4 { get; set; }
        [DisplayName("City")]
        [Required]
        public string CompanyCity { get; set; }
        [DisplayName("State")]
        [Required]
        public string CompanyState { get; set; }
        [DisplayName("Country")]
        public string CompanyCounty { get; set; }
        [DisplayName("Email")]
        public string CompanyEmail { get; set; }
        [DisplayName("Tel Office")]
        public string CompanyTelOffice { get; set; }
        [DisplayName("Date Created")]
        public DateTime? DateCreated { get; set; }
        [DisplayName("Date Updated")]
        public DateTime? DateUpdated{ get; set; }
        [DisplayName("Status")]
        public StatusE Status { get; set; }

        public ICollection<CustomersModel> Customer { get; } = new List<CustomersModel>();
        [NotMapped]
        public SelectList StatusList { get; set; }

        public static SelectList GetRankSelectList()
        {

            var enumValues = Enum.GetValues(typeof(StatusE)).Cast<StatusE>().Select(e => new { Value = e.ToString(), Text = e.ToString() }).ToList();

            return new SelectList(enumValues, "Value", "Text", "");
        }
    }
}
