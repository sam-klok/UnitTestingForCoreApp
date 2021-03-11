using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCore
{
    public class Player: APlayer 
    {
        public override bool IsNoob() { return true; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{Name} {LastName}";

        public int age { get; set; }
        public override int Age() {
            if (age == 0)
                age = 14;

            return age;
        }



        public override int Skill()
        {
            return 0;
        }
    }
}
