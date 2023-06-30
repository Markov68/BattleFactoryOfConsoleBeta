using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class Thunder : Skill
    {
        Random r = new Random();
        public Thunder() :base("かみなり", Type.Types.Elec, Kind.cattack, 110, 10, 70,0,false) { }

        public override void AfterDamageEffect(Pokemon pokemon ,Pokemon target,double damage) 
        {
            var random = r.Next(1,101);
            if ((target.State == Pokemon.Statements.None) && ((target.Type1 != Type.Types.Elec) || (target.Type2 != Type.Types.Elec)))
            {
                if (random <= 30) 
                {
                    target.State = Pokemon.Statements.Paralyze;
                    Console.WriteLine($"{target.Name}はまひじょうたいになった!");
                }
            }
        }
    }
}
