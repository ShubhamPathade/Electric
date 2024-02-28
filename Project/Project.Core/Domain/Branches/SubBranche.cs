using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Branches
{
    public class SubBranche : BaseEntity
    {
        public long MainBranchId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string BranchName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string BranchAddress { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string ContactNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ContactPersonName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string EmailAddress { get; set; }    

        public MainBranch MainBranch { get; set; }
    }
}
