using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class FlameThrower:Skill
    {
        public FlameThrower() : base("かえんほうしゃ", Type.Types.Fire, Kind.cattack, 90, 15, 100,0,false) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Random r = new Random();
            var random = r.Next(1, 101);
            if ((target.State == Pokemon.Statements.None) && ((target.Type1 != Type.Types.Fire) || (target.Type2 != Type.Types.Fire)))
            {
                if (random <= 10)
                {
                    target.State = Pokemon.Statements.Burn;
                    Console.WriteLine($"{target.Name}はやけどをおった!");
                }
            }
        }
    }
}
