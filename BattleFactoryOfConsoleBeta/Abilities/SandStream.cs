//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class SandStream : Ability
    {
        public SandStream() : base("すなおこし")
        {
        }


        public override void FirstPutEffect(Pokemon pokemon, Pokemon target, Field.Fields field, Weather.Weathers weather)
        {
            if (weather != Weather.Weathers.SandStorm)
            {
                Console.WriteLine($"{pokemon.Name}の{pokemon.Abilities.Name}!");
                Console.WriteLine("すなあらしがふきはじめた!!");
                Weather.SetWeather(Weather.Weathers.SandStorm);
                if (pokemon.HaveItem.Name == "さらさらいわ") 
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
