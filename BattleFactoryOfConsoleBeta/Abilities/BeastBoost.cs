namespace BattleOfConsole.Abilities
{
    internal class BeastBoost : Ability
    {
        public BeastBoost() : base("ビーストブースト")
        {
        }

        public override void AttackFaintedEffect(Pokemon pokemon, Pokemon target)
        {
            base.AttackFaintedEffect(pokemon, target);
            {
                if(target.IH == 0) 
                {
                    Check check = new Check();
                    if ((pokemon.InitialIA > pokemon.InitialIB) && (pokemon.InitialIA > pokemon.InitialIC) && (pokemon.InitialIA > pokemon.InitialID) && (pokemon.InitialIA > pokemon.InitialIS))
                    {
                        pokemon.Arank +=1;
                    }
                    else if ((pokemon.InitialIB > pokemon.InitialIA) && (pokemon.InitialIB > pokemon.InitialIC) && (pokemon.InitialIB > pokemon.InitialID) && (pokemon.InitialIB > pokemon.InitialIS))
                    {
                        pokemon.Brank += 1;
                    }
                    else if ((pokemon.InitialIC > pokemon.InitialIA) && (pokemon.InitialIC > pokemon.InitialIB) && (pokemon.InitialIC > pokemon.InitialID) && (pokemon.InitialIC > pokemon.InitialIS))
                    {
                        pokemon.Crank += 1;
                    }
                    else if ((pokemon.InitialID > pokemon.InitialIA) && (pokemon.InitialID > pokemon.InitialIB) && (pokemon.InitialID > pokemon.InitialIC) && (pokemon.InitialID > pokemon.InitialIS))
                    {
                        pokemon.Drank += 1;
                    }
                    else if ((pokemon.InitialIS > pokemon.InitialIA) && (pokemon.InitialIS > pokemon.InitialIB) && (pokemon.InitialIS > pokemon.InitialIC) && (pokemon.InitialIS > pokemon.InitialID))
                    {
                        pokemon.Srank += 1;
                    }
                    check.CheckRankState(pokemon);
                    Console.WriteLine($"{pokemon.Name}は{pokemon.Abilities.Name}でのうりょくがあがった!");
                }
            }
        }

    }
}
