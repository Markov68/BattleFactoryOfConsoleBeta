//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class Drizzle : Ability
    {
        public Drizzle() : base("あめふらし")
        {
        }


        public override void FirstPutEffect(Pokemon pokemon, Pokemon target, Field.Fields field, Weather.Weathers weather)
        {
            if (weather != Weather.Weathers.Rain)
            {
                Console.WriteLine($"{pokemon.Name}の{pokemon.Abilities.Name}!");
                Console.WriteLine("あめがふりはじめた!!");
                Weather.SetWeather(Weather.Weathers.Rain);
                if (pokemon.HaveItem.Name == "しめったいわ")
                {
                    Weather.WeatherCount = -3;
                }
                else 
                {
                    Weather.WeatherCount = 0;
                }
            }
        }
    }
}
