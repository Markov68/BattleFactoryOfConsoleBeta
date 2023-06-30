using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class SunnyDay : Skill
    {
        public SunnyDay() :base("にほんばれ", Type.Types.Fire, Kind.change, 0, 20, 100,0,false) { }


        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                if(weather != Weather.Weathers.Sunny) 
                {
                    Console.WriteLine("ひざしがつよくなった!");
                    Weather.SetWeather(Weather.Weathers.Sunny);
                    if(pokemon.HaveItem.Name == "あついいわ") 
                    {
                        Weather.WeatherCount = -3;
                    }
                    else 
                    {
                        Weather.WeatherCount = 0;
                    }
                }
            }
        }
    }
}
