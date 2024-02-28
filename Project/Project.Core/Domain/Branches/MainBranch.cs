using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Branches
{
    public class MainBranch:BaseEntity
    {
        [Column(TypeName = "nvarchar(100)")]
        public string MainBranchName { get; set; }

        [Column(TypeName ="nvarchar(200)")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ContactPerson { get; set; }

        [Column(TypeName ="nvarchar(12)")]
        public string ContactPersonNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string EmailAddress { get; set; }
    }
}
