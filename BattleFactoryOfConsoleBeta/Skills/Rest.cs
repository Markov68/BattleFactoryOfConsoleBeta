using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class Rest : Skill
    {
        public Rest() :base("ねむる", Type.Types.Nomal, Kind.change, 0, 5, 100,0,false) 
        {
        }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                Random r = new Random();
                Check check = new Check();
                if(pokemon.IH == pokemon.InitialIH) 
                {
                    Console.WriteLine($"{pokemon.Name}のたいりょくはまんたんだ!");
                }
                else if((Field.CurrentField == Field.Fields.ElecField) || (Field.CurrentField == Field.Fields.MistField)) 
                {
                    Console.WriteLine($"フィールドのこうかでねむらない!");
                }
                else 
                {
                    pokemon.State = Pokemon.Statements.Sleep;
                    pokemon.SleepCount = r.Next(2, 6);
                    pokemon.IH = pokemon.InitialIH;
                    Console.WriteLine($"{pokemon.Name}はねむってたいりょくをかいふくした!!");
                    check.CheckIH(pokemon);
                }
            }
        }
    }
}
