using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class FireBlast:Skill
    {
        public FireBlast() : base("だいもんじ", Type.Types.Fire, Kind.cattack, 110, 5, 85,0,false) 
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
