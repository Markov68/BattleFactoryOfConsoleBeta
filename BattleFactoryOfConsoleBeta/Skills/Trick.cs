using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class Trick:Skill
    {
        public Trick() : base("トリック", Type.Types.Psy, Kind.change, 0, 20, 100,0,false) 
        {
        }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target, Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target, weather);
            {
                pokemon.HaveItem = target.InitialHaveItem;
                target.HaveItem = pokemon.InitialHaveItem;
                Console.WriteLine("おたがいのどうぐをいれかえた!!");
                pokemon.SelectLockSkill = null;
                target.SelectLockSkill = null;
            }
        }


    }
}
