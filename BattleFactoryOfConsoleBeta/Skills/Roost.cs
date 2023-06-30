using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class Roost : Skill
    {
        public Roost() : base("はねやすめ", Type.Types.Fly, Kind.change, 0, 5, 100,0,false) 
        {
        }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target, Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target, weather);
            {   
                Check check = new Check();  
                if(pokemon.IH == pokemon.InitialIH) 
                {
                    Console.WriteLine($"{pokemon.Name}のたいりょくはまんたんだ!");
                }
                else 
                {
                    pokemon.IH += pokemon.InitialIH / 2;
                    Console.WriteLine($"{pokemon.Name}はたいりょくをかいふくした!");
                    check.CheckIH(pokemon);
                }
            }
        }


    }
}
