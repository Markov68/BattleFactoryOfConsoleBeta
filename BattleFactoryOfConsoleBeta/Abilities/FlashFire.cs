//using BattleOfConsole.Fields;

using BattleOfConsole.Items;

namespace BattleOfConsole.Abilities
{
    internal class FlashFire : Ability
    {
        public FlashFire() : base("もらいび")
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                if(target.SelectedSkill.SkillType == Type.Types.Fire) 
                {
                    pokemon.IH += (int)damage;
                    pokemon.Abilities.TypeEnhance = Type.Types.Fire;
                    Console.WriteLine($"{pokemon.Name}は{pokemon.Abilities.Name}でほのおのいりょくがあがった!");   
                }
            }
        }

    }
}
