using Project.Core.Domain.EmployeeType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Branches
{
    
    public class SubBranchEmployees:BaseEntity
    {
        [Column(TypeName ="nvarchar(100)")]
        public string EmployeeName { get; set; }

        [Column(TypeName ="nvarchar(150)")]
        public string EmployeeAddress { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string MobileNumber { get; set; }

        public long SubBrancheId { get; set; }
        public long EmployeeTypeId { get; set; }
        public EmployeeTypes EmployeeType { get; set; }
        public SubBranche SubBranche { get; set; }
    }
}
