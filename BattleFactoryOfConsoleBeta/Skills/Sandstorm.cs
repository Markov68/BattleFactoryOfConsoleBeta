using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class Sandstorm : Skill
    {
        public Sandstorm() :base("すなあらし", Type.Types.Rock, Kind.change, 0, 20, 100,0,false) { }


        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                if(weather != Weather.Weathers.SandStorm) 
                {
                    Console.WriteLine("すなあらしがふきはじめた!");
                    Weather.SetWeather(Weather.Weathers.SandStorm);
                }
            }
        }
    }
}
