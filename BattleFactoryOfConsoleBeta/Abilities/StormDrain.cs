//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class StormDrain : Ability
    {
        public StormDrain() : base("よびみず")
        {
        }


        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            base.AfterDamageEffect(pokemon, target,damage);
            {
                Check check = new Check();
                if(target.SelectedSkill.SkillType == Type.Types.Water) 
                {
                    Console.WriteLine($"{pokemon.Name}のよびみず!");
                    if(pokemon.Crank == 6) 
                    {
                        Console.WriteLine($"{pokemon.Name}のとくこうはもうあがらない!");    
                    }
                    else 
                    {
                        Console.WriteLine($"{pokemon.Name}のとくこうがあがった!");
                        pokemon.Crank += 1;
                        check.CheckRankState(pokemon);
                    }
                    pokemon.IH += (int)damage;
                    check.CheckIH(pokemon);
                }
            }
        }
    }
}
