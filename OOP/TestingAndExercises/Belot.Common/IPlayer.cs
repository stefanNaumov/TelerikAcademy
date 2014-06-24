using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belot.Common
{
    public interface IPlayer
    {
        string Name { get; }
        string Points { get; }
        void PlayCard();



        
    }
}
