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

        private IPlayerValidator playerValidator;

        public Player()
        { }

        public Player(IPlayerValidator playerValidator)
        {
            this.playerValidator = playerValidator;
        }

        public override int Skill()
        {
            return 0;
        }

        public bool Validate()
        { 
            var result = playerValidator.IsValid(this.Name);
            return result;
        }
    }
}
