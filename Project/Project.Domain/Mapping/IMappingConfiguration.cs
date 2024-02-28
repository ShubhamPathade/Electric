using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Mapping
{
    public interface IMappingConfiguration
    {
        #region

        void ApplyConfiguration(ModelBuilder modelBuilder);

        #endregion
    }
}
