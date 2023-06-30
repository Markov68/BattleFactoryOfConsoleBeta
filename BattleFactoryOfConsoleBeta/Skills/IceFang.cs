using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class IceFang:Skill
    {
        public IceFang() : base("こおりのキバ", Type.Types.Ice, Kind.attack, 65, 15, 95, 0, true)
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Random r = new Random();
            var random = r.Next(1, 101);
            if ((target.State == Pokemon.Statements.None)　&& ((target.Type1 != Type.Types.Ice) || (target.Type2 != Type.Types.Ice)))
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
