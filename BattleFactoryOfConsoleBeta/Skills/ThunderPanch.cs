using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class ThunderPanch:Skill
    {
        public ThunderPanch() : base("かみなりパンチ", Type.Types.Elec, Kind.attack, 75, 15, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Random r = new Random();
            var random = r.Next(1, 101);
            if ((target.State == Pokemon.Statements.None) && ((target.Type1 != Type.Types.Elec) || (target.Type2 != Type.Types.Elec)))
            {
                if (random <= 10)
                {
                    target.State = Pokemon.Statements.Paralyze;
                    Console.WriteLine($"{target.Name}はまひじょうたいになった!");
                }
            }
        }
    }
}
