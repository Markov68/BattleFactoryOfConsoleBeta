using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class LeechSeed : Skill
    {
        public LeechSeed() :base("やどりぎのタネ", Type.Types.Leaf, Kind.change, 0, 10, 90,0,false) { }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                if ((target.Type1 == Type.Types.Leaf) || (target.Type2 == Type.Types.Leaf))
                {
                    Console.WriteLine($"{target.Name}にはこうかがないようだ");
                }
                else 
                {
                    target.LeechSeed = true;
                    Console.WriteLine($"{target.Name}はやどりぎのタネをうえつけられた!");
                }
            }
        }
    }
}
