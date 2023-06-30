namespace BattleOfConsole
{
    internal class Weather
    {

        public enum Weathers
        {
            None,
            Rain,
            SandStorm,
            Snow,
            Sunny
        }

        public static Weathers CurrentWeather { get; set; }

        public static int WeatherCount { get; set; } = 0;

        public Weather()
        {
            CurrentWeather = Weathers.None;
        }

        public static double WeatherDamageEffect { get; set; } = 1;

        public static void SetWeather(Weather.Weathers weather)
        {
            CurrentWeather = weather;
        }


        public static void WheatherEffect(Skill selectedSkill, Weather.Weathers weather)
        {
            WeatherDamageEffect = 1;
            if ((selectedSkill.SkillType == Type.Types.Water) && (weather == Weathers.Rain))
            {
                WeatherDamageEffect = 1.5;
            }
            else if ((selectedSkill.SkillType == Type.Types.Fire) && (weather == Weathers.Rain))
            {
                WeatherDamageEffect = 0.5;
            }
            else if ((selectedSkill.SkillType == Type.Types.Water) && (weather == Weathers.Sunny))
            {
                WeatherDamageEffect = 0.5;
            }
            else if((selectedSkill.SkillType == Type.Types.Fire) && (weather == Weathers.Sunny)) 
            {
                WeatherDamageEffect = 1.5;
            }
        }

        public static void WeatherStateEffect(Pokemon pokemon,Weather.Weathers weather) 
        {
            if(((pokemon.Type1 == Type.Types.Rock) || (pokemon.Type2 == Type.Types.Rock)) && (weather == Weathers.SandStorm))
            {
                pokemon.ID = (int)(pokemon.InitialID * 1.5);
            }
            else if (((pokemon.Type1 == Type.Types.Ice) || (pokemon.Type2 == Type.Types.Ice)) && (weather == Weathers.Snow)) 
            {
                pokemon.IB = (int)(pokemon.InitialIB * 1.5);
            }
        } 
    }
}
