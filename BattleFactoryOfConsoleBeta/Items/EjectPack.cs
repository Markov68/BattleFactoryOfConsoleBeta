using System;

namespace BattleOfConsole.Items
{
    internal class EjectPack:Item
    {
        public EjectPack() : base("だっしゅつパック")
        { 
        }

        public override void ItemCounterEffect(Pokemon pokemon, Pokemon target)
        {
            base.ItemCounterEffect(pokemon, target);
            {
                Battle battle = new Battle();
                NoneItem noneItem = new NoneItem();
                if((pokemon.Arank < pokemon.InitialArank) || (pokemon.Brank < pokemon.InitialBrank) || (pokemon.Crank < pokemon.InitialCrank) || (pokemon.Drank < pokemon.InitialDrank) || (pokemon.Srank < pokemon.InitialSrank)) 
                {
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}でてもちにもどった!");
                    if (pokemon == BattleField.OppPokemon)
                    {
                        battle.OppPokeTrade(pokemon, target, Field.CurrentField, Weather.CurrentWeather);
                        BattleField.OppPokemon.HaveItem = noneItem;
                    }
                    else
                    {
                        battle.PokeTrade(pokemon, target, Mine.MyTeam, Field.CurrentField, Weather.CurrentWeather);
                        BattleField.MyPokemon.HaveItem = noneItem;
                    }
                }
            }
        }
    }
}
