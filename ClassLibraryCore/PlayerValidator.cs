using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCore
{
    public class PlayerValidator : IPlayerValidator
    {
        bool IPlayerValidator.IsValid(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }
    }
}
