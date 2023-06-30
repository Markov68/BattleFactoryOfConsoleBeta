using BattleOfConsole.Abilities;
using BattleOfConsole.Items;

namespace BattleOfConsole
{
    internal class Pokemon
    {
        NoneItem noneItem = new NoneItem();
        NoneAbility noneAbility = new NoneAbility();

        int _iH;
        int _arank;
        int _brank;
        int _crank;
        int _drank;
        int _srank;
        public string Name { get; set; }
        public int InitialIH { get; set; }
        public int IH
        {
            get
            {
                return _iH;
            }
            set
            {
                if (value < 0)
                {
                    _iH = 0;
                }
                else if (value > InitialIH)
                {
                    _iH = InitialIH;
                }
                else
                {
                    _iH = value;
                }
            }
        }

        public int InitialIA { get; set; }
        public int IA { get; set; }

        public int InitialIB { get; set; }
        public int IB { get; set; }

        public int InitialIC { get; set; }
        public int IC { get; set; }

        public int InitialID { get; set; }
        public int ID { get; set; }

        public int InitialIS { get; set; }
        public int IS { get; set; }

        public int Arank
        {
            get
            {
                return _arank;
            }
            set
            {
                if (value < -7)
                {
                    _arank = -6;
                }
                else if (value > 6)
                {
                    _arank = 6;
                }
                else
                {
                    _arank = value;
                }
            }
        }
        public int Brank
        {
            get
            {
                return _brank;
            }
            set
            {
                if (value < -7)
                {
                    _brank = -6;
                }
                else if (value > 6)
                {
                    _brank = 6;
                }
                else
                {
                    _brank = value;
                }
            }
        }
        public int Crank
        {
            get
            {
                return _crank;
            }
            set
            {
                if (value < -7)
                {
                    _crank = -6;
                }
                else if (value > 6)
                {
                    _crank = 6;
                }
                else
                {
                    _crank = value;
                }
            }
        }
        public int Drank
        {
            get
            {
                return _drank;
            }
            set
            {
                if (value < -7)
                {
                    _drank = -6;
                }
                else if (value > 6)
                {
                    _drank = 6;
                }
                else
                {
                    _drank = value;
                }
            }
        }
        public int Srank
        {
            get
            {
                return _srank;
            }
            set
            {
                if (value < -7)
                {
                    _srank = -6;
                }
                else if (value > 6)
                {
                    _srank = 6;
                }
                else
                {
                    _srank = value;
                }
            }
        }

        public int InitialArank { get; set; } = 0;
        public int InitialBrank { get; set; } = 0;
        public int InitialCrank { get; set; } = 0;
        public int InitialDrank { get; set; } = 0;
        public int InitialSrank { get; set; } = 0;



        public Type.Types Type1 { get; set; }

        public Type.Types Type2 { get; set; }

        public List<Skill> Skills { get; set; }

        public Skill SelectedSkill { get; set; }

        public Skill? SelectLockSkill { get; set; }
        public Ability Abilities { get; set; }

        public Item HaveItem { get; set; }　

        public Ability InitialAbilities { get; set; }

        public Item InitialHaveItem { get; set; }

        public Statements State { get; set; }

        public bool TurnSkip { get; set; } = false;

        public bool Fainted { get; set; } = false;

        public bool Confusion { get; set; } = false;

        public int ToxicCount { get; set; } = 0;

        public int SleepCount { get; set; } = 0;

        public int ConfusionCount { get; set; } = 0;

        public int YawnCount { get; set; } = -1;

        public bool IHMAXToZero { get; set; } 

        public double BurnGainIA { get; set; } = 1;

        public enum Statements
        {
            None,
            Paralyze,
            Freeze,
            Burn,
            Sleep,
            Poison,
            Toxic,
        }

        public bool Flinch { get; set; } = false;

        public bool Recoil { get; set; } = false;

        public bool Charging { get; set; } = false;

        public bool Diving { get; set; } = false;

        public bool Flying { get; set; } = false;

        public bool Digging { get; set; } = false;

        public bool InTheShadow { get; set; } = false;




        public Pokemon(string name, int iH, int iA, int iB, int iC, int iD, int iS, Type.Types type1, Type.Types type2)
        {
            InitialIH = iH;
            InitialIA = iA;
            InitialIB = iB;
            InitialIC = iC;
            InitialID = iD;
            InitialIS = iS;

            InitialArank = 0;
            InitialBrank = 0;
            InitialCrank = 0;
            InitialDrank = 0;
            InitialSrank = 0;

            Arank = 0;
            Brank = 0;
            Crank = 0;
            Drank = 0;
            Srank = 0;

            Name = name;
            IH = iH;
            IA = iA;
            IB = iB;
            IC = iC;
            ID = iD;
            IS = iS;
            Type1 = type1;
            Type2 = type2;
            Skills = new List<Skill>();
            State = Statements.None;
            Abilities = noneAbility;
            HaveItem = noneItem;
            InitialAbilities = Abilities;
            InitialHaveItem = HaveItem;
            IHMAXToZero = true;
        }

      


        public void AddSkill(Skill skill)
        {
            Skills.Add(skill);
        }

        public void EndTurnStateEffect(Pokemon pokemon) 
        {
            Check check = new Check();
            if(pokemon.State == Statements.Burn) 
            {
                pokemon.IH -= pokemon.InitialIH / 16;
                Console.WriteLine($"{pokemon.Name}はやけどのダメージをうけている!");
                check.CheckIH(pokemon);
            }
            else if(pokemon.State == Statements.Poison) 
            {
                pokemon.IH -= pokemon.InitialIH / 16;
                Console.WriteLine($"{pokemon.Name}はどくにおかされている!");
                check.CheckIH(pokemon);
            }
            else if(pokemon.State == Statements.Toxic) 
            {
                pokemon.IH -= pokemon.InitialIH * pokemon.ToxicCount / 16;
                Console.WriteLine($"{pokemon.Name}はもうどくにおかされている!");
                check.CheckIH(pokemon);
                pokemon.ToxicCount++;
            }
        }

    }
}
