using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class Toxic : Skill
    {
        public Toxic() :base("どくどく", Type.Types.Poison, Kind.change, 0, 15, 85,0,false) 
        {
        }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                if(target.State != Pokemon.Statements.None) 
                {
                    Console.WriteLine("しかしうまくきまらなかった!");
                }
                else if ((target.Type1 == Type.Types.Poison) || (target.Type2 == Type.Types.Poison))
                {
                    Console.WriteLine($"{target.Name}にはこうかがないようだ");
                }
                else 
                {
                    target.State = Pokemon.Statements.Toxic;
                    Console.WriteLine($"{target.Name}はもうどくじょうたいになった!!");
                }
            }
        }
    }
}
