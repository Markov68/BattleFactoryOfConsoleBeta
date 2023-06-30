using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class ThunderWave : Skill
    {
        public ThunderWave() :base("でんじは", Type.Types.Elec, Kind.change, 0, 20, 90,0,false) { }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                if(target.State != Pokemon.Statements.None) 
                {
                    Console.WriteLine("しかしうまくきまらなかった!");
                }
                else if ((target.Type1 == Type.Types.Elec) || (target.Type2 == Type.Types.Elec) || (target.Type1 == Type.Types.Grand) || (target.Type2 == Type.Types.Grand)) 
                {
                    Console.WriteLine($"{target.Name}にはこうかがないようだ");
                }
                else 
                {
                    target.State = Pokemon.Statements.Paralyze;
                    Console.WriteLine($"{target.Name}はしびれた!!");
                }
            }
        }
    }
}
