using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class Trailblaze : Skill
    {
        public Trailblaze() : base("くさわけ", Type.Types.Leaf, Kind.attack, 50, 20, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                if(pokemon.Srank == 6) 
                {
                    Console.WriteLine($"{pokemon.Name}のすばやさはもうあがらない!");
                }
                else 
                {
                    Check check = new Check();
                    pokemon.Srank ++;
                    check.CheckRankState(pokemon);
                    Console.WriteLine($"{pokemon.Name}のすばやさがあがった!");
                }
            }
        }


    }
}
