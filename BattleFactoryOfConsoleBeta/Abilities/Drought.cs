//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class Drought : Ability
    {
        public Drought() : base("ひでり")
        {
        }


        public override void FirstPutEffect(Pokemon pokemon, Pokemon target, Field.Fields field, Weather.Weathers weather)
        {
            if (weather != Weather.Weathers.Sunny)
            {
                Console.WriteLine($"{pokemon.Name}の{pokemon.Abilities.Name}!");
                Console.WriteLine("ひざしがつよくなった!!");
                Weather.SetWeather(Weather.Weathers.Sunny);
                if (pokemon.HaveItem.Name == "あついいわ") 
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
