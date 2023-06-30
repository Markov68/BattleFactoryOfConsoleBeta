//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class Static : Ability
    {
        public Static() : base("せいでんき")
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                if((target.SelectedSkill.IsTouchSkill == true) && (target.State == Pokemon.Statements.None) && ((target.Type1 != Type.Types.Elec) || (target.Type2 != Type.Types.Elec)))
                {
                    Random r = new Random();
                    if(r.Next(1,101) <= 30)
                    {
                        target.State = Pokemon.Statements.Paralyze;
                        Console.WriteLine($"{target.Name}は{pokemon.Name}の{pokemon.Abilities.Name}でしびれた!");
                    }
                }
            }
        }

    }
}
