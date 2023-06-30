using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class ClearSmog:Skill
    {
        public ClearSmog() : base("クリアスモッグ", Type.Types.Poison, Kind.cattack, 50, 15, 1000,0,false) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            Check check = new Check();
            Console.WriteLine($"{target.Name}ののうりょくをもとにもどした!");
            target.Arank = 0;
            target.Brank = 0;
            target.Crank = 0;
            target.Drank = 0;
            target.Srank = 0;
            check.CheckRankState(target);
        }
    }
}
