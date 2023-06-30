namespace BattleOfConsole.Items
{
    internal class LifeOrb:Item
    {
        public LifeOrb() : base("いのちのたま")
        {
        }

        public override void ItemEffect(Pokemon pokemon,Pokemon target,Skill selectskill)
        {
            base.ItemEffect(pokemon,target,selectskill);
            {
                ItemDamageEffect = 1.3;
            }
        }
        public override void AfterAttackEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            base.AfterAttackEffect(pokemon, target,damage);
            {
                Check check = new Check();
                pokemon.IH -= pokemon.InitialIH / 10;
                Console.WriteLine($"{pokemon.Name}はいのちがすこしけずられた!");
                check.CheckIH(pokemon);
            }
        }
    }
}
