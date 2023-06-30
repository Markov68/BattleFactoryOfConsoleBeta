//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class ElectricSurge : Ability
    {
        public ElectricSurge() : base("エレキメイカー")
        {
        }


        public override void FirstPutEffect(Pokemon pokemon, Pokemon target, Field.Fields field, Weather.Weathers weather)
        {
            if (field != Field.Fields.ElecField)
            {
                Console.WriteLine($"{pokemon.Name}のエレキメイカー!");
                Console.WriteLine("あしもとにでんきがかけめぐる!!");
                Field.SetField(Field.Fields.ElecField);
            }

        }
    }
}
