namespace BattleOfConsole.Items
{
    internal class SkyPlate:Item
    {
        public SkyPlate() : base("あおぞらプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Fly;
            }
        }

    }
}
