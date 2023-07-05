using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class Psychic : Skill
    {
        public Psychic() : base("サイコキネシス", Type.Types.Psy, Kind.cattack, 90, 10, 100,0,false) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Check check = new Check();
            Random r = new Random();
            if (target.Drank != -6 && (r.Next(1,101) <= 20) && (target.Abilities.Name == "クリアボディ")) 
            {
                target.Drank -= 1;
                check.CheckRankState(target);
                Console.WriteLine($"{target.Name}のとくぼうがさがった!");
            }

        }
    }
}
