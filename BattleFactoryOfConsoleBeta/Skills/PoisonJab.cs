using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class PoisonJab:Skill
    {
        public PoisonJab() : base("どくづき", Type.Types.Poison, Kind.attack, 80, 20, 100, 0, true)
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Random r = new Random();
            var random = r.Next(1, 101);
            if ((target.State == Pokemon.Statements.None)　&& ((target.Type1 != Type.Types.Poison) || (target.Type2 != Type.Types.Poison)))
            {
                if (random <= 30)
                {
                    target.State = Pokemon.Statements.Poison;
                    Console.WriteLine($"{target.Name}はどくじょうたいになった!");
                }
            }
        }
    }
}
