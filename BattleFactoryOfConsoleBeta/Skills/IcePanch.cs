using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;

namespace BattleOfConsole.Skills
{
    internal class IcePanch:Skill
    {
        public IcePanch() : base("れいとうパンチ", Type.Types.Ice, Kind.attack, 75, 15, 100, 0, true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Random r = new Random();
            var random = r.Next(1, 101);
            if ((target.State == Pokemon.Statements.None) && ((target.Type1 != Type.Types.Ice) || (target.Type2 != Type.Types.Ice)))
            {
                if (random <= 10)
                {
                    target.State = Pokemon.Statements.Freeze;
                    Console.WriteLine($"{target.Name}はこおりづけになった!");
                }
            }
        }
    }
}
