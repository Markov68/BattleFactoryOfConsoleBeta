using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class Reflect: Skill
    {
        public Reflect() : base("リフレクター", Type.Types.Psy, Kind.change, 0, 20, 100, 0, false)
        {
        }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target, Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target, weather);
            {
                if(pokemon == BattleField.MyPokemon) 
                {
                    if(Mine.MineReflect == true) 
                    {
                        Console.WriteLine("しかしうまくきまらなかった!");
                    }
                    else if(pokemon.HaveItem.Name == "ひかりのねんど") 
                    {
                        Mine.MineReflect = true;
                        Mine.ReflectCounter = 8;
                        Console.WriteLine("みかたはリフレクターでぶつりにつよくなった!");
                    }
                    else 
                    {
                        Mine.MineReflect = true;
                        Mine.ReflectCounter = 5;
                        Console.WriteLine("みかたはリフレクターでぶつりにつよくなった!");
                    }
                }
                else 
                {
                    if (AI.AIReflect == true)
                    {
                        Console.WriteLine("しかしうまくきまらなかった!");
                    }
                    else if (pokemon.HaveItem.Name == "ひかりのねんど")
                    {
                        AI.AIReflect = true;
                        AI.ReflectCounter = 8;
                        Console.WriteLine("あいてはリフレクターでぶつりにつよくなった!");
                    }
                    else
                    {
                        AI.AIReflect = true;
                        AI.ReflectCounter = 5;
                        Console.WriteLine("あいてはリフレクターでぶつりにつよくなった!");
                    }
                }
            }
        }

    }
}
