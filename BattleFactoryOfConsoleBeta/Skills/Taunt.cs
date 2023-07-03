using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class Taunt : Skill
    {
        public Taunt() :base("ちょうはつ", Type.Types.Dark, Kind.change, 0, 20, 100,0,false) { }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                if (target.Taunt == true) 
                {
                    Console.WriteLine("しかしうまくきまらなかった!");
                }
                else 
                {
                    target.Taunt =true;
                    target.TauntCount = 3;
                    Console.WriteLine($"{target.Name}はちょうはつにのってしまった!");
                }
            }
        }
    }
}
