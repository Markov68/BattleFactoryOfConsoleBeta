namespace BattleOfConsole
{
    internal class BattleFactory
    {
        public int Attempt { get; set; }
        public List<Pokemon> FirstPick(List<Pokemon> pokemonList, List<Pokemon> opponentPokemonList)
        {
            Check check = new Check();
            Random random = new Random();
            List<Pokemon> firstPickPokemon = new List<Pokemon>();
            List<Pokemon> myTeam = new List<Pokemon>();

            for (int i = 0; i < 6; i++)
            {
                Pokemon selectedPokemon;
                do
                {
                    selectedPokemon = pokemonList[random.Next(0, pokemonList.Count)];
                } while (firstPickPokemon.Contains(selectedPokemon) || opponentPokemonList.Contains(selectedPokemon));

                firstPickPokemon.Add(selectedPokemon);
            }
            Console.WriteLine("Battle Factory Of Console　へようこそ!");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("はじめに６匹のうち自分のチームとなる3匹のポケモンを選んでください。");
            for (int count = 1; count <= 3; count++)
            {
                Console.WriteLine($"{count}匹目のポケモンを選んでください。");
                for (int i = 0; i < firstPickPokemon.Count; i++)
                {
                    Console.WriteLine($"{i}:{firstPickPokemon[i].Name}");
                }

                int selectIndex;
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out selectIndex) || selectIndex < 0 || selectIndex >= firstPickPokemon.Count)
                    {
                        Console.WriteLine("無効な選択肢です。もう一度入力してください。");
                    }
                    else if (myTeam.Contains(firstPickPokemon[selectIndex]))
                    {
                        Console.WriteLine("既に選択されたポケモンです。もう一度入力してください。");
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine($"{firstPickPokemon[selectIndex].Name}をどうする？");
                Console.WriteLine("チームに加える:0 ようすをみる:1 もどる:2");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 0:
                        {
                            myTeam.Add(firstPickPokemon[selectIndex]);
                            Console.Clear();
                            break;
                        }
                    case 1:
                        {
                            count--;
                            check.CheckStats(firstPickPokemon[selectIndex],Field.CurrentField,Weather.CurrentWeather);
                            break;
                        }
                    case 2:
                        {
                            count--;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("無効な選択肢です。もう一度入力してください。");
                            continue;
                        }
                }
            }
            return myTeam;
        }

        public void SecondPick(List<Pokemon> myteam, List<Pokemon> oppteam)
        {
            int mySelectIndex;
            int oppSelectIndex;

            Console.WriteLine("こうかんするじぶんのポケモンをえらんでください");
            Console.WriteLine($"{myteam[0].Name}:0 {myteam[1].Name}:1 {myteam[2].Name}:2");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out mySelectIndex) || mySelectIndex < 0 || mySelectIndex >= myteam.Count)
                {
                    Console.WriteLine("無効な選択肢です。もう一度入力してください。");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("こうかんするあいてのポケモンをえらんでください");
            Console.WriteLine($"{oppteam[0].Name}:0 {oppteam[1].Name}:1 {oppteam[2].Name}:2");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out oppSelectIndex) || oppSelectIndex < 0 || oppSelectIndex >= oppteam.Count)
                {
                    Console.WriteLine("無効な選択肢です。もう一度入力してください。");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"{oppteam[oppSelectIndex].Name}をどうする？");
            Console.WriteLine("チームに加える:0 もどる:1");
            while (true)
            {
                switch (int.Parse(Console.ReadLine()))
                {
                    case 0:
                        {
                            myteam[mySelectIndex] = oppteam[oppSelectIndex];
                            Console.WriteLine("正常に交換が終了しました。");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                    case 1:
                        {
                            continue;
                        }
                    default:
                        {
                            Console.WriteLine("無効な選択肢です。もう一度入力してください。");
                            continue;
                        }
                }
                break;
            }
        }

        public static List<Pokemon> MakeAITeam(List<Pokemon> pokemonList)
        {
            Random random = new Random();
            List<Pokemon> opponentTeam = new List<Pokemon>();

            for (int i = 0; i < 3; i++)
            {
                Pokemon selectedPokemon;
                do
                {
                    selectedPokemon = pokemonList[random.Next(0, pokemonList.Count)];
                } while (opponentTeam.Contains(selectedPokemon));

                opponentTeam.Add(selectedPokemon);
            }
            return opponentTeam;
        }

        public static List<Pokemon> SecondMakeAITeam(List<Pokemon> pokemonList, List<Pokemon> myteam ,List<Pokemon> oldteam)
        {
            Random random = new Random();
            List<Pokemon> opponentTeam = new List<Pokemon>();

            for (int i = 0; i < 3; i++)
            {
                Pokemon selectedPokemon;
                do
                {
                    selectedPokemon = pokemonList[random.Next(0, pokemonList.Count)];
                } while (opponentTeam.Contains(selectedPokemon) || myteam.Contains(selectedPokemon) || (oldteam.Contains(selectedPokemon)));

                opponentTeam.Add(selectedPokemon);
            }
            return opponentTeam;
        }

    }
}

