//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class WeakArmor : Ability
    {
        public WeakArmor() : base("くだけるよろい")
        {
        }


        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            base.AfterDamageEffect(pokemon, target,damage);
            {
                Check check = new Check();
                if(target.SelectedSkill.Kinds == Skill.Kind.attack) 
                {
                    Console.WriteLine($"{pokemon.Name}のくだけるよろい!");
                    if (pokemon.IB == -6) 
                    {
                        Console.WriteLine($"{pokemon.Name}のぼうぎょはもうさがらない!");
                    }
                    else 
                    {
                        Console.WriteLine($"{pokemon.Name}のぼうぎょがさがった!");
                        pokemon.Brank -= 1;
                        check.CheckRankState(pokemon);
                    }
                    Thread.Sleep(1000);
                    if (pokemon.IS == 6) 
                    {
                        Console.WriteLine($"{pokemon.Name}のすばやさはもうあがらない!");
                    }
                    else if (pokemon.IS == 5) 
                    {
                        Console.WriteLine($"{pokemon.Name}のすばやさがあがった!");
                        pokemon.Srank += 1;
                        check.CheckRankState(pokemon);
                    }
                    else 
                    {
                        Console.WriteLine($"{pokemon.Name}のすばやさがぐーんとあがった!");
                        pokemon.Srank += 2;
                        check.CheckRankState(pokemon);
                    }
                }
            }
        }
    }
}
