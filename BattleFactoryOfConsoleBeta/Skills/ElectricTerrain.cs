using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class ElectricTerrain : Skill
    {
        public ElectricTerrain() :base("エレキフィールド", Type.Types.Elec, Kind.change, 0, 10, 100,0,false) { }


        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                if(Field.CurrentField != Field.Fields.ElecField) 
                {
                    Console.WriteLine("あしもとにでんきがかけめぐる!");
                    Field.SetField(Field.Fields.ElecField);
                    if(pokemon.HaveItem.Name == "グランドコート") 
                    {
                        Field.FieldCount = -3;
                    }
                    else 
                    {
                        Field.FieldCount = 0;
                    }
                }
            }
        }
    }
}
