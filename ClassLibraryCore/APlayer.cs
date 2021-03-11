using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCore
{
    public abstract class APlayer: IPlayer
    {
        public abstract int Age();
        public abstract bool IsNoob();
        public abstract int Skill();
    }
}
