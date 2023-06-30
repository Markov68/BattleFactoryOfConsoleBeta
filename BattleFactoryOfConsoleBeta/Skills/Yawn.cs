using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class Yawn : Skill
    {
        public Yawn() :base("あくび", Type.Types.Nomal, Kind.change, 0, 10, 100,0,false) 
        {
        }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                Random r = new Random();
                Check check = new Check();
                if((Field.CurrentField == Field.Fields.ElecField) || (Field.CurrentField == Field.Fields.MistField)) 
                {
                    Console.WriteLine($"フィールドのこうかでねむらない!");
                }
                else 
                {
                    Console.WriteLine($"{target.Name}のねむけをさそった");
                    target.YawnCount = Turn.TurnCount;
                }
            }
        }
    }
}
