using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera_TDD.Classes
{
    internal class Machine
    {
        CupSizes CupSizes;
        Cups LargeCups;
        Cups MediumCups;
        Cups SmallCups;
        Coffe Coffe;
        Sugar Sugar;
        int CupOfCoffe;
        int CoffeForCup;
        int HowMuchSugar;
        public Machine(CupSizes CupSizes, Cups LargeCups, Cups MediumCups, Cups SmallCups, Coffe Coffe, Sugar Sugar) 
        {
            this.CupSizes = CupSizes; 
            this.LargeCups = LargeCups;
            this.MediumCups= MediumCups;
            this.SmallCups= SmallCups;
            this.Coffe = Coffe;
            this.Sugar = Sugar;
        }

        public void Start()
        {
            Console.WriteLine("WELCOME TO YOU VIRTUAL COFFE MACHINE");
            Console.WriteLine("FEEL FREE TO CHOOSE ONE OR OUR COFFE CUPS, CHOOSE YOUR SIZE (WRITE ITS NUMBER):");
            Console.WriteLine("1. SMALL");
            Console.WriteLine("2. MEDIUM");
            Console.WriteLine("3. LARGE");
            string Input = Console.ReadLine();
            try
            {
                CupOfCoffe = int.Parse(Input);
                this.GetCoffeAskSugar();
            } catch(Exception err)
            {
                Console.WriteLine("JUST WRITE ONE OF THE NUMBERS OF THE CUP SIZES");
                Console.WriteLine("PRESS ANY KEY.....");
                Console.ReadKey();
                Console.Clear();
                this.Start();
            }
        }

        public void GetCoffeAskSugar()
        {
            int HowMuchCoffe = this.Coffe.HowMuchCoffe();
            switch (CupOfCoffe)
            {
                case 1:
                    //Confirm if there are enough cups of Small sizes
                    int SmallCups = this.SmallCups.HasCups();
                    int SizeOnzSmallCups = this.SmallCups.GetSizeOnz();
                    //IF NOT
                    if (SmallCups <= 0)
                    {
                        Console.WriteLine("WE RAN OUT OF SMALL CUPS OF COFFE, CHOOSE ANOTHER SIZE");
                        Console.WriteLine("PRESS ANY KEY.....");
                        Console.ReadKey();
                        Console.Clear();
                        this.Start();
                    }

                    if (!this.Coffe.HasEnoughCoffe(SizeOnzSmallCups))
                    {
                        if(this.Coffe.HowMuchCoffe() == 0)
                        {
                            Console.WriteLine("THERE IS NOT MORE COFFE");
                            Console.ReadLine();
                            Console.Clear();
                            this.Start();
                        }
                        Console.WriteLine("WE RAN OUT OF COFFE TO FILL SMALL CUP OF COFFE, I WILL GIVE THE LAST "+ this.Coffe.HowMuchCoffe() +" ONZ");
                        CoffeForCup = this.Coffe.HowMuchCoffe();
                        Console.ReadKey();
                    }
                    else
                    {
                        CoffeForCup = SizeOnzSmallCups;
                    }
              
                    this.SmallCups.GiveCup();
                    this.Coffe.GiveCoffe(CoffeForCup);

                    Console.WriteLine("WRITE HOW MANY SPOONS OF SUGAR YOU WANT IN YOU COFFE");
                    string InputSugar = Console.ReadLine();

                    try
                    {
                        HowMuchSugar = int.Parse(InputSugar);
                        this.AddSugarToCoffe();
                    } catch (Exception err)
                    {
                        Console.WriteLine("JUST WRITE THE NUMBERS OF THE AMOUNT OF SUGAR YOU WANT");
                        Console.WriteLine("PRESS ANY KEY.....");
                        Console.ReadKey();
                        Console.Clear();
                        this.AddSugar2();
                    }
                    break;

                case 2:
                    //Confirm if there are enough cups of Medium sizes
                    int MediumCups = this.MediumCups.HasCups();
                    int SizeOnzMediumCups = this.MediumCups.GetSizeOnz();
                    //IF NOT
                    if (MediumCups <= 0)
                    {
                        Console.WriteLine("WE RAN OUT OF MEDIUM CUPS OF COFFE, CHOOSE ANOTHER SIZE");
                        Console.WriteLine("PRESS ANY KEY.....");
                        Console.ReadKey();
                        Console.Clear();
                        this.Start();
                    }

                    if (!this.Coffe.HasEnoughCoffe(SizeOnzMediumCups))
                    {
                        if (this.Coffe.HowMuchCoffe() <= 0)
                        {
                            Console.WriteLine("THERE IS NOT MORE COFFE");
                            Console.ReadLine();
                            Console.Clear();
                            this.Start();
                        }
                        Console.WriteLine("WE RAN OUT OF COFFE TO FILL MEDIUM CUP OF COFFE, I WILL GIVE THE LAST " + this.Coffe.HowMuchCoffe() + " ONZ");
                        CoffeForCup = this.Coffe.HowMuchCoffe();
                        Console.ReadKey();
                    }
                    else
                    {
                        CoffeForCup = SizeOnzMediumCups;
                    }

                    this.MediumCups.GiveCup();
                    this.Coffe.GiveCoffe(CoffeForCup);

                    Console.WriteLine("WRITE HOW MANY SPOONS OF SUGAR YOU WANT IN YOU COFFE");
                    string InputSugarMedium = Console.ReadLine();

                    try
                    {
                        HowMuchSugar = int.Parse(InputSugarMedium);
                        this.AddSugarToCoffe();
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("JUST WRITE THE NUMBERS OF THE AMOUNT OF SUGAR YOU WANT");
                        Console.WriteLine("PRESS ANY KEY.....");
                        Console.ReadKey();
                        Console.Clear();
                        this.AddSugar2();
                    }
                    break;
                case 3:
                    //Confirm if there are enough cups of Medium sizes
                    int LargeCups = this.LargeCups.HasCups();
                    int SizeOnzLargeCups = this.LargeCups.GetSizeOnz();
                    //IF NOT
                    if (LargeCups <= 0)
                    {
                        Console.WriteLine("WE RAN OUT OF LARGE CUPS OF COFFE, CHOOSE ANOTHER SIZE");
                        Console.WriteLine("PRESS ANY KEY.....");
                        Console.ReadKey();
                        Console.Clear();
                        this.Start();
                    }

                    if (!this.Coffe.HasEnoughCoffe(SizeOnzLargeCups))
                    {
                        if (this.Coffe.HowMuchCoffe() <= 0)
                        {
                            Console.WriteLine("THERE IS NOT MORE COFFE");
                            Console.ReadLine();
                            Console.Clear();
                            this.Start();
                        }
                        Console.WriteLine("WE RAN OUT OF COFFE TO FILL LARGE CUP OF COFFE, I WILL GIVE THE LAST " + this.Coffe.HowMuchCoffe() + " ONZ");
                        CoffeForCup = this.Coffe.HowMuchCoffe();
                        Console.ReadKey();
                    }
                    else
                    {
                        CoffeForCup = SizeOnzLargeCups;
                    }

                    this.LargeCups.GiveCup();
                    this.Coffe.GiveCoffe(CoffeForCup);

                    Console.WriteLine("WRITE HOW MANY SPOONS OF SUGAR YOU WANT IN YOU COFFE");
                    string InputSugarLarge = Console.ReadLine();

                    try
                    {
                        HowMuchSugar = int.Parse(InputSugarLarge);
                        this.AddSugarToCoffe();
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("JUST WRITE THE NUMBERS OF THE AMOUNT OF SUGAR YOU WANT");
                        Console.WriteLine("PRESS ANY KEY.....");
                        Console.ReadKey();
                        Console.Clear();
                        this.AddSugar2();
                    }
                    break;
                default:
                    Console.WriteLine("JUST WRITE ONE OF THE NUMBERS OF THE CUP SIZES");
                    Console.ReadKey();
                    Console.Clear();
                    this.Start();
                    break;
            }
        }

        public void AddSugarToCoffe()
        {
            if (!this.Sugar.HasEnoughSuggar(HowMuchSugar))
            {
                Console.WriteLine("THERE IS NOT ENOUGH SUGAR FOR " + HowMuchSugar + " SPOONS, WHAT ABOUT LESS?");
                Console.WriteLine("PRESS ANY KEY....");
                Console.ReadKey();
                Console.Clear();
                this.AddSugar2();
            }

            Console.Clear();
            Console.WriteLine("THIS IS YOUR CUP OF COFFE:");
            switch (CupOfCoffe)
            {
                case 1:
                    Console.WriteLine("Cup Size: " + CupSizes.Small + " (" + this.SmallCups.GetSizeOnz() + " .ONZ)");
                    Console.WriteLine("Coffe: " + CoffeForCup + " .ONZ");
                    break;
                case 2:
                    Console.WriteLine("Cup Size: " + CupSizes.Medium + " (" + this.MediumCups.GetSizeOnz() + " .ONZ)");
                    Console.WriteLine("Coffe: " + CoffeForCup + " .ONZ");
                    break;
                case 3:
                    Console.WriteLine("Cup Size: " + CupSizes.Large + " (" + this.LargeCups.GetSizeOnz() + " .ONZ)");
                    Console.WriteLine("Coffe: " + CoffeForCup + " .ONZ");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Sugar: " + HowMuchSugar + " SPOONS");
            Console.WriteLine("PRESS ANY KEY TO GET ANOTHER ONE");
            Console.ReadKey();
            Console.Clear();
            this.Start();
        }

        public void AddSugar2 ()
        {
            Console.WriteLine("WRITE HOW MANY SPOONS OF SUGAR YOU WANT IN YOU COFFE");
            string InputSugar = Console.ReadLine();

            try
            {
                HowMuchSugar = int.Parse(InputSugar);
                this.AddSugarToCoffe();
            }
            catch (Exception err)
            {
                Console.WriteLine("JUST WRITE THE NUMBERS OF THE AMOUNT OF SUGAR YOU WANT");
                Console.WriteLine("PRESS ANY KEY.....");
                Console.ReadKey();
                Console.Clear();
                this.AddSugar2();
            }
        }
    }
}
