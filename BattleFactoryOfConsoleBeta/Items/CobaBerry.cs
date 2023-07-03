namespace BattleOfConsole.Items
{
    internal class CobaBerry : Item
    {
        public CobaBerry() : base("バコウのみ")
        { 
        }

        public override void BeforeDamageEffect(Pokemon pokemon, Pokemon target, ref double damage)
        {
            base.BeforeDamageEffect(pokemon, target, ref damage);
            {
                Type type = new Type();
                NoneItem noneItem = new NoneItem();
                type.TypeEffect(pokemon, target.SelectedSkill);
                if ((target.SelectedSkill.SkillType == Type.Types.Fly) && (type.EffectivCounter >= 2))
                {
                    damage /= 2;
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}でわざのいりょくをおさえた!");
                    pokemon.HaveItem = noneItem;
                }
            }
        }

    }
}
