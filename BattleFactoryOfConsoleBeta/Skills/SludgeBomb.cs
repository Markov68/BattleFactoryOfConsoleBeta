using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class SludgeBomb : Skill
    {
        Random r = new Random();
        public SludgeBomb() :base("ヘドロばくだん", Type.Types.Poison, Kind.cattack, 90, 10, 100,0,false) { }

        public override void AfterDamageEffect(Pokemon pokemon ,Pokemon target,double damage) 
        {
            var random = r.Next(1,101);
            if ((target.State == Pokemon.Statements.None) && ((target.Type1 != Type.Types.Poison) || (target.Type2 != Type.Types.Poison)))
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
