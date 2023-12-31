﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class RainDance : Skill
    {
        public RainDance() :base("あまごい", Type.Types.Water, Kind.change, 0, 20, 100,0,false) { }


        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                if(weather != Weather.Weathers.Rain) 
                {
                    Console.WriteLine("あめがふりはじめた!");
                    Weather.SetWeather(Weather.Weathers.Rain);
                    if (pokemon.HaveItem.Name == "しめったいわ")
                    {
                        Weather.WeatherCount = -3;
                    }
                    else
                    {
                        Weather.WeatherCount = 0;
                    }
                }
                else 
                {
                    Console.WriteLine("しかしうまくきまらなかった!");
                }
            }
        }
    }
}
