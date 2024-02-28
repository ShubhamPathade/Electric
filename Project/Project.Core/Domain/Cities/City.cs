using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Domain.Cities
{
    /// <summary>
    /// 
    /// </summary>
    public class City:BaseEntity
    {
        #region
        public string CityName { get; set; }
        public long StateId { get;set; }
        public State State { get; set; }    
        #endregion
    }
}
