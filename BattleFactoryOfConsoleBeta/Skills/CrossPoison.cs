using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class CrossPoison:Skill
    {
        public CrossPoison() : base("クロスポイズン", Type.Types.Poison, Kind.attack, 70, 20, 100,0,true) 
        {
        }

        public override void BeforeAttackEffect(Pokemon pokemon, Pokemon target)
        {
            base.BeforeAttackEffect(pokemon, target);
            {
                
                pokemon.CriticalHitStage += 1;

            }
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                Random r = new Random();
                if ((r.Next(1, 101) <= 10) && (target.State == Pokemon.Statements.None) && (target.Type1 != Type.Types.Metal) && (target.Type1 != Type.Types.Poison) && (target.Type2 != Type.Types.Metal) && (target.Type2 != Type.Types.Poison))
                {
                    target.State = Pokemon.Statements.Poison;
                    Console.WriteLine($"{target.Name}はどくじょうたいになった!");
                }
            }
        }


    }
}
