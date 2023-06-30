//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class Moxie: Ability
    {
        public Moxie() : base("じしんかじょう")
        {
        }

        public override void AttackFaintedEffect(Pokemon pokemon, Pokemon target)
        {
            base.AttackFaintedEffect(pokemon, target);
            {
                if (target.IH == 0)
                {
                    Console.WriteLine($"{pokemon.Name}の{pokemon.Abilities.Name}!!");
                    Check check = new Check();
                    if (pokemon.Arank == 6)
                    {
                        Console.WriteLine($"{pokemon.Name}のこうげきはもうあがらない!");
                    }
                    else
                    {
                        pokemon.Arank += 1;
                        check.CheckRankState(pokemon);
                        Console.WriteLine($"{pokemon.Name}は{pokemon.Abilities.Name}でのうりょくがあがった!");
                    }

                }
            }
        }

    }
}
