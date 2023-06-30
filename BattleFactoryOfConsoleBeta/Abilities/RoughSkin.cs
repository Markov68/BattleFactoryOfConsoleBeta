//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class RoughSkin : Ability
    {
        public RoughSkin() : base("さめはだ")
        {
        }


        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            base.AfterDamageEffect(pokemon, target,damage);
            {
                Check check = new Check();
                if(target.SelectedSkill.IsTouchSkill == true) 
                {
                    Console.WriteLine($"{target.Name}はきずついた!");
                    target.IH -= target.InitialIH / 8;
                    check.CheckIH(target);
                }
            }
        }
    }
}
