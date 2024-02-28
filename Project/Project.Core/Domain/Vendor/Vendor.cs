using Project.Core.Domain.Branches;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Vendor
{
    public class Vendor:BaseEntity
    {
        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName ="nvarchar(12)")]
        public string MobileNumber { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string EmailAddress { get; set; }

        public long MainBranchId { get; set; }  

        public MainBranch MainBranch { get; set; }
    }
}
