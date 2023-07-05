//using BattleOfConsole.Fields;

using BattleOfConsole.Items;

namespace BattleOfConsole.Abilities
{
    internal class Protean : Ability
    {
        public Protean() : base("へんげんじざい")
        {
        }

        public override void AbilityEffect(Pokemon pokemon, Pokemon target)
        {
            base.AbilityEffect(pokemon, target);
            {
                NoneAbility　noneAbility = new NoneAbility();
                pokemon.Type1 = pokemon.SelectedSkill.SkillType;
                pokemon.Type2 = Type.Types.None;
                Console.WriteLine($"{pokemon.Name}は{pokemon.Abilities.Name}で{pokemon.Type1}タイプになった!");
                pokemon.Abilities = noneAbility;
            }
        }

    }
}
