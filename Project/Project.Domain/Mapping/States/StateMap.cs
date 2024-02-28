using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Mapping.States
{
    [Keyless]
    public class StateMap:ProjectEntityTypeConfiguration<State>
    {
        #region
        public override void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable(nameof(State));
            builder.HasKey(state => state.Id);
            builder.Property(state=>state.Name).HasMaxLength(100);

            base.Configure(builder);
        }
        #endregion
    }
}
