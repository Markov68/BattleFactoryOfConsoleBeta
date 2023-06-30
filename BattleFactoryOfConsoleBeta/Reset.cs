using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole
{
    internal class Reset
    {
        Mine mine = new Mine();
        AI ai = new AI();
        BattleField field = new BattleField();
        public void BattleResetState(Pokemon pokemon)
        {
            pokemon.SelectLockSkill = null;
            pokemon.Confusion = false;
            pokemon.ToxicCount = 0;
            pokemon.YawnCount = -1;
            pokemon.Abilities.TypeEnhance = Type.Types.None;
            pokemon.Arank = 0;
            pokemon.Brank = 0;
            pokemon.Crank= 0;
            pokemon.Drank= 0;
            pokemon.Srank= 0;
            pokemon.IA = pokemon.InitialIA;
            pokemon.IB = pokemon.InitialIB;
            pokemon.IC = pokemon.InitialIC;
            pokemon.ID = pokemon.InitialID;
            pokemon.IS = pokemon.InitialIS;
        }
        public void ResetPokeState(List<Pokemon> pokemon)
        {
            foreach (Pokemon target in pokemon)
            {
                target.IH = target.InitialIH;
                target.IA = target.InitialIA;
                target.IB = target.InitialIB;
                target.IC = target.InitialIC;
                target.ID = target.InitialID;
                target.IS = target.InitialIS;
                target.Arank = 0;
                target.Brank = 0;
                target.Crank = 0;
                target.Drank = 0;
                target.Srank = 0;
                target.Abilities.TypeEnhance = Type.Types.None;
                target.State = Pokemon.Statements.None;
                target.HaveItem = target.InitialHaveItem;
                target.Abilities = target.InitialAbilities;
                target.Fainted = false;
            }
        }

        public void ResetBool()
        {
            Mine.TradeSkip = false;
            AI.TradeSkip = false;
            BattleField.MyPokemon.HaveItem.IHMaxToZero = false;
            BattleField.OppPokemon.HaveItem.IHMaxToZero = false;
            BattleField.MyPokemon.Confusion = false;
            BattleField.OppPokemon.Confusion = false;
            BattleField.MyPokemon.Flinch = false;
            BattleField.OppPokemon.Flinch = false;
            BattleField.MyPokemon.TurnSkip = false;
            BattleField.OppPokemon.TurnSkip = false;
        }

        public void FieldReset()
        {
            Field.CurrentField = Field.Fields.None;
            Weather.CurrentWeather = Weather.Weathers.None;
            Field.FieldCount = 0;
            Weather.WeatherCount = 0;
            Mine.MineStealthRock = false;
            AI.AIStealthRock = false;
        }

        public void InitialRankReset() 
        {
            BattleField.MyPokemon.InitialArank = BattleField.MyPokemon.Arank;
            BattleField.MyPokemon.InitialBrank = BattleField.MyPokemon.Brank;
            BattleField.MyPokemon.InitialCrank = BattleField.MyPokemon.Crank;
            BattleField.MyPokemon.InitialDrank = BattleField.MyPokemon.Drank;
            BattleField.MyPokemon.InitialSrank = BattleField.MyPokemon.Srank;
            BattleField.OppPokemon.InitialArank = BattleField.OppPokemon.Arank;
            BattleField.OppPokemon.InitialBrank = BattleField.OppPokemon.Brank;
            BattleField.OppPokemon.InitialCrank = BattleField.OppPokemon.Crank;
            BattleField.OppPokemon.InitialDrank = BattleField.OppPokemon.Drank;
            BattleField.OppPokemon.InitialSrank = BattleField.OppPokemon.Srank;
        }
    }
}
