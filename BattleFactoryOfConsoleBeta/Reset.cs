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
            pokemon.HaveItem.TypeEnhance = Type.Types.None;
            pokemon.Abilities.TypeEnhance = Type.Types.None;
            pokemon.Type1 = pokemon.InitialType1;
            pokemon.Type2 = pokemon.InitialType2;
            pokemon.Arank = 0;
            pokemon.Brank = 0;
            pokemon.Crank= 0;
            pokemon.Drank= 0;
            pokemon.Srank= 0;
            pokemon.CriticalHitStage = 0;
            if(pokemon.InitialIA != pokemon.SubInitialIA) 
            {
                pokemon.IA = pokemon.SubInitialIA;
            }
            else
            {
                pokemon.IA = pokemon.InitialIA;
            }
            if(pokemon.InitialIB != pokemon.SubInitialIB) 
            {
                pokemon.IB = pokemon.SubInitialIB;
            }
            else 
            {
                pokemon.IB = pokemon.InitialIB;
            }
            if (pokemon.InitialIC != pokemon.SubInitialIC)
            {
                pokemon.IC = pokemon.SubInitialIC;
            }
            else
            {
                pokemon.IC = pokemon.InitialIC;
            }
            if (pokemon.InitialID != pokemon.SubInitialID)
            {
                pokemon.ID = pokemon.SubInitialID;
            }
            else
            {
                pokemon.ID = pokemon.InitialID;
            }
            if (pokemon.InitialIS != pokemon.SubInitialIS)
            {
                pokemon.IS = pokemon.SubInitialIS;
            }
            else
            {
                pokemon.IS = pokemon.InitialIS;
            }
        }
        public void ResetPokeState(List<Pokemon> pokemon)
        {
            foreach (Pokemon target in pokemon)
            {
                if (target.InitialIA != target.SubInitialIA)
                {
                    target.IA = target.SubInitialIA;
                }
                else
                {
                    target.IA = target.InitialIA;
                }
                if (target.InitialIB != target.SubInitialIB)
                {
                    target.IB = target.SubInitialIB;
                }
                else
                {
                    target.IB = target.InitialIB;
                }
                if (target.InitialIC != target.SubInitialIC)
                {
                    target.IC = target.SubInitialIC;
                }
                else
                {
                    target.IC = target.InitialIC;
                }
                if (target.InitialID != target.SubInitialID)
                {
                    target.ID = target.SubInitialID;
                }
                else
                {
                    target.ID = target.InitialID;
                }
                if (target.InitialIS != target.SubInitialIS)
                {
                    target.IS = target.SubInitialIS;
                }
                else
                {
                    target.IS = target.InitialIS;
                }
                target.IH = target.InitialIH;
                target.Arank = 0;
                target.Brank = 0;
                target.Crank = 0;
                target.Drank = 0;
                target.Srank = 0;
                target.HaveItem.TypeEnhance = Type.Types.None;
                target.Abilities.TypeEnhance = Type.Types.None;
                target.State = Pokemon.Statements.None;
                target.HaveItem = target.InitialHaveItem;
                target.Abilities = target.InitialAbilities;
                target.Type1 = target.InitialType1;
                target.Type2 = target.InitialType2;
                target.Flinch = false;
                target.Recoil = false;
                target.Fainted = false;
                target.LeechSeed = false;
                target.Taunt = false;
                target.SelectLockSkill = null;
                target.Confusion = false;
                target.ToxicCount = 0;
                target.YawnCount = -1;
                target.CriticalHitStage = 0;
            }
        }

        public void ResetBool()
        {
            Mine.TradeSkip = false;
            AI.TradeSkip = false;
            BattleField.MyPokemon.HaveItem.IHMaxToZero = false;
            BattleField.OppPokemon.HaveItem.IHMaxToZero = false;
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
            Mine.MineLightScreen = false;
            Mine.MineReflect = false;
            AI.AILightScreen = false;
            AI.AIReflect = false;
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
