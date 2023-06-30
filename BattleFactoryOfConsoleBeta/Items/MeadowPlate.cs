namespace BattleOfConsole.Items
{
    internal class MeadowPlate:Item
    {
        public MeadowPlate() : base("みどりのプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Leaf;
            }
        }

    }
}
