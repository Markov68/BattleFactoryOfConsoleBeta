using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Abilities
{
    internal class Threat:Ability
    {
        public Threat() : base("いかく")
        {
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target, Field.Fields field, Weather.Weathers wheather)
        {
            base.FirstPutEffect(pokemon, target, field, wheather);
            {
                Check check = new Check();
                Console.WriteLine($"{pokemon.Name}の{pokemon.Abilities.Name}!");
                if (target.Abilities.Name == "クリアボディ")
                {
                    Console.WriteLine("クリアボディのこうかでのうりょくがさがらない!");
                }
                else if ((target.Abilities != null) && (target.Abilities.Name == "せいしんりょく"))
                {
                    Console.WriteLine($"{target.Name}のこうげきはさがらない!");
                }
                else if (target.Arank == 6) 
                {
                    Console.WriteLine($"{target.Name}のこうげきはもうさがらない!");
                }
                else 
                {
                    Console.WriteLine($"{target.Name}のこうげきがさがった!");
                    target.Arank -= 1;
                    check.CheckRankState(target);
                }
                
            }
        }
    }
}
