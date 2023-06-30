using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class WillOWisp : Skill
    {
        public WillOWisp() :base("おにび", Type.Types.Fire, Kind.change, 0, 15, 85,0,false) { }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                if(target.State != Pokemon.Statements.None) 
                {
                    Console.WriteLine("しかしうまくきまらなかった!");
                }
                else if ((target.Type1 == Type.Types.Fire) || (target.Type2 == Type.Types.Fire))
                {
                    Console.WriteLine($"{target.Name}にはこうかがないようだ");
                }
                else 
                {
                    target.State = Pokemon.Statements.Burn;
                    Console.WriteLine($"{target.Name}はやけどをおった!!");
                }
            }
        }
    }
}
