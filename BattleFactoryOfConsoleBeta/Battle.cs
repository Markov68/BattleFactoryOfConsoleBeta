using static System.Net.Mime.MediaTypeNames;

namespace BattleOfConsole
{
    internal class Battle
    {
        Random r = new Random();
        Type type = new Type();
        Check check = new Check();
        Reset reset = new Reset();

        public bool MyGameOver { get; set; } = false;
        public bool OppGameOver { get; set; } = false;


        public void AttackPokemon(Pokemon attack, Pokemon target, Skill selectedskill, Field.Fields field, Weather.Weathers weather)
        {
            type.TypeEffect(target, selectedskill);
            Field.FieldEffect(selectedskill, field);
            Weather.WheatherEffect(selectedskill, weather);
            attack.HaveItem.ItemEffect(attack,target,selectedskill);
            Type.CollectSkillType(attack, selectedskill);
            Type.TypeEnhanceDamage(attack);
            check.BurnCheck(attack);
            attack.Abilities.AbilityEffect(attack, target);
            Console.WriteLine($"{attack.Name}の{selectedskill.Name}!!");
            var hitRateNum = r.Next(1, 101);
            var damegeRandom = Math.Round(r.NextDouble() * 0.15 + 0.85, 2);
            int intDamage;
          
            if (hitRateNum > selectedskill.HitRate)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"しかし{attack.Name}のこうげきははずれた!!");
            }
            else
            {
                if (selectedskill.Kinds == Skill.Kind.attack)
                {
                    double damage = (((2 * 100 / 5 + 2) * selectedskill.Impact * attack.IA / target.IB) / 50 + 2) * type.EffectivCounter * Ability.AbilityEffectCount * Weather.WeatherDamageEffect * Field.FieldDamageEffect * attack.HaveItem.ItemDamageEffect * Type.SkillTypeCollect * Ability.TypeEnhanceCounter * Item.TypeEnhanceCounter * damegeRandom * attack.BurnGainIA;
                    target.HaveItem.BeforeDamageEffect(target, attack, ref damage);
                    target.IH -= (int)damage;
                    intDamage = (int)damage;
                    if ((type.EffectivCounter == 2) || (type.EffectivCounter == 4))
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine($"こうかはばつぐんだ!!　{target.Name}に{(int)damage}のダメージを与えた!");
                        Thread.Sleep(1000);
                        attack.Abilities.AttackFaintedEffect(attack, target);
                        Thread.Sleep(1000);
                        selectedskill.AfterDamageEffect(attack, target, damage);
                        Thread.Sleep(1000);
                        target.Abilities.AfterDamageEffect(target, attack,damage);
                        Thread.Sleep(1000);
                        attack.HaveItem.ItemCounterEffect(attack,target);
                        Thread.Sleep(1000);
                        target.HaveItem.ItemCounterEffect(target, attack);
                        Thread.Sleep(1000);
                        attack.HaveItem.AfterAttackEffect(attack, target, damage);
                        Thread.Sleep(1000);
                        target.HaveItem.AfterDamageEffect(target, attack, damage);
                        check.CheckIH(target);

                    }
                    else if ((type.EffectivCounter == 0.5) || (type.EffectivCounter == 0.25))
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine($"こうかはいまひとつのようだ　{target.Name}に{(int)damage}のダメージを与えた!");
                        Thread.Sleep(1000);
                        attack.Abilities.AttackFaintedEffect(attack, target);
                        Thread.Sleep(1000);
                        selectedskill.AfterDamageEffect(attack, target, damage);
                        Thread.Sleep(1000);
                        target.Abilities.AfterDamageEffect(target, attack,damage);
                        Thread.Sleep(1000);
                        attack.HaveItem.ItemCounterEffect(attack, target);
                        Thread.Sleep(1000);
                        target.HaveItem.ItemCounterEffect(target, attack);
                        Thread.Sleep(1000);
                        attack.HaveItem.AfterAttackEffect(attack, target, damage);
                        Thread.Sleep(1000);
                        target.HaveItem.AfterDamageEffect(target, attack, damage);
                        check.CheckIH(target);
                    }
                    else if (type.EffectivCounter == 0)
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine($"こうかがないようだ");
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine($"{target.Name}に{(int)damage}のダメージを与えた！");
                        Thread.Sleep(1000);
                        attack.Abilities.AttackFaintedEffect(attack, target);
                        Thread.Sleep(1000);
                        selectedskill.AfterDamageEffect(attack, target, damage);
                        Thread.Sleep(1000);
                        target.Abilities.AfterDamageEffect(target, attack,damage);
                        Thread.Sleep(1000);
                        attack.HaveItem.ItemCounterEffect(attack, target);
                        Thread.Sleep(1000);
                        target.HaveItem.ItemCounterEffect(target, attack);
                        Thread.Sleep(1000);
                        attack.HaveItem.AfterAttackEffect(attack, target, damage);
                        Thread.Sleep(1000);
                        target.HaveItem.AfterDamageEffect(target, attack, damage);
                        check.CheckIH(target);
                    }
                }
                else if (selectedskill.Kinds == Skill.Kind.cattack)
                {
                    double damage = (((2 * 100 / 5 + 2) * selectedskill.Impact * attack.IC / target.ID) / 50 + 2) * type.EffectivCounter * Ability.AbilityEffectCount * Weather.WeatherDamageEffect * Field.FieldDamageEffect * attack.HaveItem.ItemDamageEffect * Type.SkillTypeCollect * Ability.TypeEnhanceCounter * Item.TypeEnhanceCounter * damegeRandom;
                    target.HaveItem.BeforeDamageEffect(target, attack, damage);
                    target.IH -= (int)damage;
                    intDamage = (int)damage;
                    if ((type.EffectivCounter == 2) || (type.EffectivCounter == 4))
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine($"こうかはばつぐんだ!!　{target.Name}に{(int)damage}のダメージを与えた!");
                        Thread.Sleep(1000);
                        attack.Abilities.AttackFaintedEffect(attack, target);
                        Thread.Sleep(1000);
                        selectedskill.AfterDamageEffect(attack, target, damage);
                        Thread.Sleep(1000);
                        target.Abilities.AfterDamageEffect(target, attack,damage);
                        Thread.Sleep(1000);
                        attack.HaveItem.ItemCounterEffect(attack, target);
                        Thread.Sleep(1000);
                        target.HaveItem.ItemCounterEffect(target, attack);
                        Thread.Sleep(1000);
                        attack.HaveItem.AfterAttackEffect(attack,target, damage);
                        Thread.Sleep(1000);
                        target.HaveItem.AfterDamageEffect(target, attack, damage);
                        check.CheckIH(target);

                    }
                    else if ((type.EffectivCounter == 0.5) || (type.EffectivCounter == 0.25))
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine($"こうかはいまひとつのようだ　{target.Name}に{(int)damage}のダメージを与えた!");
                        Thread.Sleep(1000);
                        attack.Abilities.AttackFaintedEffect(attack, target);
                        Thread.Sleep(1000);
                        selectedskill.AfterDamageEffect(attack, target, damage);
                        Thread.Sleep(1000);
                        target.Abilities.AfterDamageEffect(target, attack,damage);
                        Thread.Sleep(1000);
                        attack.HaveItem.ItemCounterEffect(attack, target);
                        Thread.Sleep(1000);
                        target.HaveItem.ItemCounterEffect(target, attack);
                        Thread.Sleep(1000);
                        attack.HaveItem.AfterAttackEffect(attack, target, damage);
                        Thread.Sleep(1000);
                        target.HaveItem.AfterDamageEffect(target, attack, damage);
                        check.CheckIH(target);
                    }
                    else if (type.EffectivCounter == 0)
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine($"こうかがないようだ");
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine($"{target.Name}に{(int)damage}のダメージを与えた！");
                        Thread.Sleep(1000);
                        attack.Abilities.AttackFaintedEffect(attack, target);
                        Thread.Sleep(1000);
                        selectedskill.AfterDamageEffect(attack, target, damage);
                        Thread.Sleep(1000);
                        target.Abilities.AfterDamageEffect(target, attack,damage);
                        Thread.Sleep(1000);
                        attack.HaveItem.ItemCounterEffect(attack, target);
                        Thread.Sleep(1000);
                        target.HaveItem.ItemCounterEffect(target, attack);
                        Thread.Sleep(1000);
                        attack.HaveItem.AfterAttackEffect(attack, target, damage);
                        Thread.Sleep(1000);
                        target.HaveItem.AfterDamageEffect(target, attack, damage);
                        check.CheckIH(target);
                    }
                    Thread.Sleep(2000);
                }
                else if (selectedskill.Kinds == Skill.Kind.oneshot)
                {
                    if (type.EffectivCounter == 0)
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine($"こうかがないようだ");
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        OneShotSkill(target, selectedskill);
                    }
                }
                else if (selectedskill.Kinds == Skill.Kind.change)
                {
                    Thread.Sleep(2000);
                    selectedskill.ChangeSkillEffect(attack, target, weather);
                    Thread.Sleep(1000);
                    attack.HaveItem.ItemCounterEffect(attack, target);
                    Thread.Sleep(1000);
                    target.HaveItem.ItemCounterEffect(target, attack);
                    Thread.Sleep(1000);
                    attack.HaveItem.AfterDamageEffect(attack, target, 0);
                    Thread.Sleep(1000);
                    target.HaveItem.AfterDamageEffect(target, attack, 0);
                }
            }
            if (((attack.HaveItem.Name == "こだわりスカーフ") || (attack.HaveItem.Name == "こだわりメガネ") || (attack.HaveItem.Name == "こだわりハチマキ")) && (attack.SelectLockSkill == null))
            {
                attack.SelectLockSkill = selectedskill;
            }
            if (BattleField.OppPokemon.Fainted == true)
            {
                if (check.AllTeamPokemonFainted(AI.AITeam) == true)
                {
                    OppGameOver = true;
                }
                else
                {
                    OppPokeTrade(BattleField.OppPokemon, BattleField.MyPokemon, Field.CurrentField, Weather.CurrentWeather);
                }
            }
            if (BattleField.MyPokemon.Fainted == true)
            {
                if (check.AllTeamPokemonFainted(Mine.MyTeam) == true)
                {
                    MyGameOver = true;
                }
                else
                {
                    PokeTrade(BattleField.MyPokemon, BattleField.OppPokemon, Mine.MyTeam, Field.CurrentField, Weather.CurrentWeather);
                }
            }
            Thread.Sleep(1000);


        }
        public void OneShotSkill(Pokemon target, Skill selectedskill)
        {
            type.TypeEffect(target, selectedskill);
            if (type.EffectivCounter != 0)
            {
                target.IH -= target.InitialIH;
                Console.WriteLine("いちげきひっさつ!!");
            }
            else
            {
                Console.WriteLine("こうかがないようだ");
            }
        }

        public void PokeTrade(Pokemon currentMyPoke, Pokemon currentAIPoke, List<Pokemon> minepoke, Field.Fields field, Weather.Weathers weather)
        {
            while (true)
            {
                Console.WriteLine("交換先を選んでください");
                Console.WriteLine($"0:{minepoke[0].Name} 1:{minepoke[1].Name} 2:{minepoke[2].Name}");
                int selectindex = int.Parse(Console.ReadLine());
                Console.WriteLine($"{minepoke[selectindex].Name}をどうする?");
                Console.WriteLine($"0:いれかえる　1:ようすをみる");
                if (int.TryParse(Console.ReadLine(), out var selectnum))
                {
                    switch (selectnum)
                    {
                        case 0:
                            {
                                if (currentMyPoke == minepoke[selectindex])
                                {
                                    Console.WriteLine("そのポケモンはすでに場に出ています");
                                    continue;
                                }
                                else if (minepoke[selectindex].Fainted == true)
                                {
                                    Console.WriteLine("そのポケモンはたたかうためのげんきがのこっていない!!");
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine($"よくやった!{currentMyPoke.Name}!!");
                                    reset.BattleResetState(BattleField.MyPokemon);
                                    BattleField.MyPokemon = minepoke[selectindex];
                                    Thread.Sleep(2000);
                                    Console.WriteLine($"ゆけっ!{BattleField.MyPokemon.Name}!!");
                                    Thread.Sleep(2000);
                                    BattleField.MyPokemon.Abilities.FirstPutEffect(BattleField.MyPokemon, currentAIPoke, field, weather);
                                    BattleField.OppPokemon.HaveItem.ItemCounterEffect(BattleField.OppPokemon, BattleField.MyPokemon);
                                    BattleField.MyPokemon.HaveItem.FirstPutEffect(BattleField.MyPokemon,BattleField.OppPokemon);
                                    Mine.TradeSkip = true;

                                    break;
                                }
                            }
                        case 1:
                            {
                                check.CheckStats(minepoke[selectindex],field,weather);
                                continue;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("無効な入力です。数値を入力してください。");
                    continue;
                }
                break;
            }
        }
        public void OppPokeTrade(Pokemon opppokemon, Pokemon minepokemon, Field.Fields field, Weather.Weathers weather)
        {
            var loopcount = 1;
            while (true)
            {
                Random r = new Random();
                int randomIndex = r.Next(0, 3);
                if (opppokemon == AI.AITeam[randomIndex])
                {
                    if(loopcount >= 100) 
                    {
                        break;
                    }
                    loopcount++;
                    continue;
                }
                else if (AI.AITeam[randomIndex].IH == 0)
                {
                    if(loopcount >= 100) 
                    {
                        break;
                    }
                    loopcount++;
                    continue;
                }
                else
                {
                    if (opppokemon.IH != 0)
                    {
                        Console.WriteLine($"{opppokemon.Name}をひっこめた!!");
                    }
                    reset.BattleResetState(BattleField.OppPokemon);
                    BattleField.OppPokemon = AI.AITeam[randomIndex];
                    Thread.Sleep(2000);
                    Console.WriteLine($"あいては{BattleField.OppPokemon.Name}をくりだした!!");
                    Thread.Sleep(2000);
                    BattleField.OppPokemon.Abilities.FirstPutEffect(BattleField.OppPokemon, minepokemon, field, weather);
                    BattleField.MyPokemon.HaveItem.ItemCounterEffect(BattleField.MyPokemon, BattleField.OppPokemon);
                    BattleField.OppPokemon.HaveItem.FirstPutEffect(BattleField.OppPokemon, minepokemon);
                    Thread.Sleep(2000);
                    //field.OppPokemon.OppPutFieldObject();
                    AI.TradeSkip = true;
                }
                break;
            }
        }
    }
}
