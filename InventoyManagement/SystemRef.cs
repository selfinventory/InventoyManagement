using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement
{
    public class SystemRef
    {
        public enum StatusE
        {
            /// <summary>
            /// Not processed yet
            /// </summary>
            [Display(Name = "Active")]
            Active,
            /// <summary>
            /// In progress to process
            /// </summary>
            [Display(Name = "Deactivated")]
            Deactivated,
            /// <summary>
            /// Process Successfully
            /// </summary>
            [Display(Name = "Block")]
            Block,
            /// <summary>
            /// Error will reprocess
            /// </summary>
            [Display(Name = "Waiting For Approval")]
            WaitingForApproval,
            /// <summary>
            /// Error will not reprocess
            /// </summary>
            [Display(Name = "Approved")]
            Approved,
        }
    }
}
