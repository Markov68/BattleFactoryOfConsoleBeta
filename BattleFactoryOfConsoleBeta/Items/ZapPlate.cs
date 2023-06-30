namespace BattleOfConsole.Items
{
    internal class ZapPlate:Item
    {
        public ZapPlate() : base("いかずちプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Elec;
            }
        }

    }
}
