using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class Swagger : Skill
    {
        public Swagger() :base("いばる", Type.Types.Nomal, Kind.change, 0, 5, 100,0,false) 
        {
        }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                Random r = new Random();
                Check check = new Check();
                if(target.Arank == 6) 
                {
                    Console.WriteLine($"{target.Name}のこうげきはもうあがらない!");
                }
                else if(target.Arank == 5) 
                {
                    Console.WriteLine($"{target.Name}のこうげきがあがった!");
                    target.Arank += 1;
                    check.CheckRankState(target);
                }
                else 
                {
                    Console.WriteLine($"{target.Name}のこうげきがぐーんとあがった!");
                    target.Arank += 2;
                    check.CheckRankState(target);
                }
                Thread.Sleep(1000);
                if (target.Confusion == true) 
                {
                    Console.WriteLine($"{target.Name}はすでにこんらんしている!");
                }
                else 
                {
                    Console.WriteLine($"{target.Name}はこんらんした!");
                    target.Confusion = true;
                    target.ConfusionCount = r.Next(2,6);
                }
            }
        }
    }
}
