using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCore
{
    public class PlayerExpert: Player
    {
        public void CauseArgNulEx(string test)
        {
            if (test == null)
                throw new ArgumentNullException();
        }
    }
}
