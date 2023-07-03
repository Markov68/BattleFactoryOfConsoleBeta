using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class LightScreen: Skill
    {
        public LightScreen() : base("ひかりのかべ", Type.Types.Psy, Kind.change, 0, 30, 100, 0, false)
        {
        }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target, Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target, weather);
            {
                if(pokemon == BattleField.MyPokemon) 
                {
                    if(Mine.MineLightScreen == true) 
                    {
                        Console.WriteLine("しかしうまくきまらなかった!");
                    }
                    else if(pokemon.HaveItem.Name == "ひかりのねんど") 
                    {
                        Mine.MineLightScreen = true;
                        Mine.LightScreenCounter = 8;
                        Console.WriteLine("みかたはひかりのかべでとくしゅにつよくなった!");
                    }
                    else 
                    {
                        Mine.MineLightScreen = true;
                        Mine.LightScreenCounter = 5;
                        Console.WriteLine("みかたはひかりのかべでとくしゅにつよくなった!");
                    }
                }
                else 
                {
                    if (AI.AILightScreen == true)
                    {
                        Console.WriteLine("しかしうまくきまらなかった!");
                    }
                    else if (pokemon.HaveItem.Name == "ひかりのねんど")
                    {
                        AI.AILightScreen = true;
                        AI.LightScreenCounter = 8;
                        Console.WriteLine("あいてはひかりのかべでとくしゅにつよくなった!");
                    }
                    else
                    {
                        AI.AILightScreen = true;
                        AI.LightScreenCounter = 5;
                        Console.WriteLine("あいてはひかりのかべでとくしゅにつよくなった!");
                    }
                }
            }
        }

    }
}
