using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class AquaStep:Skill
    {
        public AquaStep() : base("アクアステップ", Type.Types.Water, Kind.attack, 80, 10, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                Check check = new Check();  
                if(pokemon.Srank == 6) 
                {
                    Console.WriteLine($"{pokemon.Name}のすばやさはもうあがらない!");
                }
                else 
                {
                    pokemon.Srank += 1;
                    check.CheckRankState(pokemon);
                    Console.WriteLine($"{pokemon.Name}のすばやさがあがった!!");
                }
            }
        }


    }
}
