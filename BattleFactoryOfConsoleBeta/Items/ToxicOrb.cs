using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class ToxicOrb:Item
    {
        public ToxicOrb() : base("どくどくだま")
        { 
        }

        public override void EndTurnEffect(Pokemon pokemon, Pokemon target)
        {
            base.EndTurnEffect(pokemon, target);
            {
                if(pokemon.State == Pokemon.Statements.None) 
                {
                    pokemon.State = Pokemon.Statements.Toxic;
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}でもうどくになった!");
                }
            }
        }

    }
}
