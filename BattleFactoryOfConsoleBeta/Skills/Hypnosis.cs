using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class Hypnosis : Skill
    {
        public Hypnosis() :base("さいみんじゅつ", Type.Types.Psy, Kind.change, 0, 20, 60,0,false) 
        {
        }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                Random r = new Random();
                Check check = new Check();
                if(target.State != Pokemon.Statements.None) 
                {
                    Console.WriteLine($"しかしうまくきまらなかった!");
                }
                else if((Field.CurrentField == Field.Fields.ElecField) || (Field.CurrentField == Field.Fields.MistField)) 
                {
                    Console.WriteLine($"フィールドのこうかでねむらない!");
                }
                else 
                {
                    target.State = Pokemon.Statements.Sleep;
                    target.SleepCount = r.Next(2, 6);
                    Console.WriteLine($"{target.Name}はねむってしまった!!");
                }
            }
        }
    }
}
