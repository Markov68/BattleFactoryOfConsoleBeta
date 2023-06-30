using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class DrainPunch:Skill
    {
        public DrainPunch() : base("ドレインパンチ", Type.Types.Fight, Kind.attack, 75, 10, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            Check check = new Check();
            pokemon.IH += (int)(damage / 2);
            Console.WriteLine($"{pokemon.Name}はたいりょくをすいとった!");
            check.CheckIH(pokemon);
        }
    }
}
