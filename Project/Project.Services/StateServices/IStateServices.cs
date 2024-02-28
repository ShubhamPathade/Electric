using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.StateServices
{
    public interface IStateServices
    {
        Task<State> AddState(State state);
    }
}
