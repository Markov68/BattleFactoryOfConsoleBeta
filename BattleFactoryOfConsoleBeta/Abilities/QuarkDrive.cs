using BattleOfConsole.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole
{
    internal class QuarkDrive : Ability
    {
        public QuarkDrive(Pokemon pokemon) : base("クォークチャージ") 
        {
            Check check = new Check();
            if (Field.CurrentField == Field.Fields.ElecField)
            {
                check.CheckRankState(pokemon);
                if ((pokemon.IA > pokemon.IB) && (pokemon.IA > pokemon.IC) && (pokemon.IA > pokemon.ID) && (pokemon.IA > pokemon.IS))
                {
                    pokemon.IA = (int)(pokemon.IA * 1.5);
                }
                else if ((pokemon.IB > pokemon.IA) && (pokemon.IB > pokemon.IC) && (pokemon.IB > pokemon.ID) && (pokemon.IB > pokemon.IS))
                {
                    pokemon.IB = (int)(pokemon.IB * 1.5);
                }
                else if ((pokemon.IC > pokemon.IA) && (pokemon.IC > pokemon.IB) && (pokemon.IC > pokemon.ID) && (pokemon.IC > pokemon.IS))
                {
                    pokemon.IC = (int)(pokemon.IC * 1.5);
                }
                else if ((pokemon.ID > pokemon.IA) && (pokemon.ID > pokemon.IB) && (pokemon.ID > pokemon.IC) && (pokemon.ID > pokemon.IS))
                {
                    pokemon.ID = (int)(pokemon.ID * 1.5);
                }
                else if ((pokemon.IS > pokemon.IA) && (pokemon.IS > pokemon.IB) && (pokemon.IS > pokemon.IC) && (pokemon.IS > pokemon.ID))
                {
                    pokemon.IS = (int)(pokemon.IS * 1.3);
                }
                Console.WriteLine($"{pokemon.Name}は{pokemon.Abilities.Name}でのうりょくがあがった!");
            }
            else if (pokemon.HaveItem.Name == "ブーストエナジー") 
            {
                check.CheckRankState(pokemon);
                if ((pokemon.IA > pokemon.IB) && (pokemon.IA > pokemon.IC) && (pokemon.IA > pokemon.ID) && (pokemon.IA > pokemon.IS))
                {
                    pokemon.IA = (int)(pokemon.IA * 1.5);
                }
                else if ((pokemon.IB > pokemon.IA) && (pokemon.IB > pokemon.IC) && (pokemon.IB > pokemon.ID) && (pokemon.IB > pokemon.IS))
                {
                    pokemon.IB = (int)(pokemon.IB * 1.5);
                }
                else if ((pokemon.IC > pokemon.IA) && (pokemon.IC > pokemon.IB) && (pokemon.IC > pokemon.ID) && (pokemon.IC > pokemon.IS))
                {
                    pokemon.IC = (int)(pokemon.IC * 1.5);
                }
                else if ((pokemon.ID > pokemon.IA) && (pokemon.ID > pokemon.IB) && (pokemon.ID > pokemon.IC) && (pokemon.ID > pokemon.IS))
                {
                    pokemon.ID = (int)(pokemon.ID * 1.5);
                }
                else if ((pokemon.IS > pokemon.IA) && (pokemon.IS > pokemon.IB) && (pokemon.IS > pokemon.IC) && (pokemon.IS > pokemon.ID))
                {
                    pokemon.IS = (int)(pokemon.IS * 1.3);
                }
            }
            
        }
    }
}
