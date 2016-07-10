using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krestikinoliki
{
    //test
    class Proga
    {
        private int[] massiv1 = new int[9];

        private Krestiki b;

        public Proga(Krestiki b)
        {
            this.b = b;
        }
        public int hz()
        {
            for (int i = 0; i < 9; i++)
            {
                if (b.massiv[i] == "х")
                {
                    massiv1[i] = 1;
                }
                else if (b.massiv[i] == "0")
                {
                    massiv1[i] = 10;
                }
                else 
                {
                    massiv1[i] = 100;
                }

            }
            if (massiv1[0] + massiv1[1] + massiv1[2] == 102)
            {
                if (massiv1[0] == 100) { return 0; }
                if (massiv1[1] == 100) { return 1; }
                if (massiv1[2] == 100) { return 2; }
            }
            if (massiv1[3] + massiv1[4] + massiv1[5] == 102)
            {
                if (massiv1[3] == 100) { return 3; }
                if (massiv1[4] == 100) { return 4; }
                if (massiv1[5] == 100) { return 5; }
            }
            if (massiv1[6] + massiv1[7] + massiv1[8] == 102)
            {
                if (massiv1[6] == 100) { return 6; }
                if (massiv1[7] == 100) { return 7; }
                if (massiv1[8] == 100) { return 8; }
            }
            if (massiv1[0] + massiv1[3] + massiv1[6] == 102)
            {
                if (massiv1[0] == 100) { return 0; }
                if (massiv1[3] == 100) { return 3; }
                if (massiv1[6] == 100) { return 6; }
            }
            if (massiv1[1] + massiv1[4] + massiv1[7] == 102)
            {
                if (massiv1[1] == 100) { return 1; }
                if (massiv1[4] == 100) { return 4; }
                if (massiv1[7] == 100) { return 7; }
            }
            if (massiv1[2] + massiv1[5] + massiv1[8] == 102)
            {
                if (massiv1[2] == 100) { return 2; }
                if (massiv1[5] == 100) { return 5; }
                if (massiv1[8] == 100) { return 8; }
            }
            if (massiv1[0] + massiv1[4] + massiv1[8] == 102)
            {
                if (massiv1[0] == 100) { return 0; }
                if (massiv1[4] == 100) { return 4; }
                if (massiv1[8] == 100) { return 8; }
            }
            if (massiv1[2] + massiv1[4] + massiv1[6] == 102)
            {
                if (massiv1[2] == 100) { return 2; }
                if (massiv1[4] == 100) { return 4; }
                if (massiv1[6] == 100) { return 6; }
            }

            //  ksjfksdjf;klasdlfafd
            if (massiv1[0] + massiv1[1] + massiv1[2] == 120)
            {
                if (massiv1[0] == 100) { return 0; }
                if (massiv1[1] == 100) { return 1; }
                if (massiv1[2] == 100) { return 2; }
            }
            if (massiv1[3] + massiv1[4] + massiv1[5] == 120)
            {
                if (massiv1[3] == 100) { return 3; }
                if (massiv1[4] == 100) { return 4; }
                if (massiv1[5] == 100) { return 5; }
            }
            if (massiv1[6] + massiv1[7] + massiv1[8] == 120)
            {
                if (massiv1[6] == 100) { return 6; }
                if (massiv1[7] == 100) { return 7; }
                if (massiv1[8] == 100) { return 8; }
            }
            if (massiv1[0] + massiv1[3] + massiv1[6] == 120)
            {
                if (massiv1[0] == 100) { return 0; }
                if (massiv1[3] == 100) { return 3; }
                if (massiv1[6] == 100) { return 6; }
            }
            if (massiv1[1] + massiv1[4] + massiv1[7] == 120)
            {
                if (massiv1[1] == 100) { return 1; }
                if (massiv1[4] == 100) { return 4; }
                if (massiv1[7] == 100) { return 7; }
            }
            if (massiv1[2] + massiv1[5] + massiv1[8] == 120)
            {
                if (massiv1[2] == 100) { return 2; }
                if (massiv1[5] == 100) { return 5; }
                if (massiv1[8] == 100) { return 8; }
            }
            if (massiv1[0] + massiv1[4] + massiv1[8] == 120)
            {
                if (massiv1[0] == 100) { return 0; }
                if (massiv1[4] == 100) { return 4; }
                if (massiv1[8] == 100) { return 8; }
            }
            if (massiv1[2] + massiv1[4] + massiv1[6] == 120)
            {
                if (massiv1[2] == 100) { return 2; }
                if (massiv1[4] == 100) { return 4; }
                if (massiv1[6] == 100) { return 6; }
            }
            return 33;
        }

    }
    class Krestiki
    {
        Proga c;
        private Random _random = new Random();

        public string vtoroihod, tretiihod;
        public int chislo, rchislo, chislo2, dop;
        public Krestiki()
        {
            c = new Proga(this);
        }
        
        public int hui()
        {
            int hui = Rand1();
            if (hui == 10 | hui == 11 | hui == 12)
            {
                hui = 5;
            }
            return hui;
        }
        
        public int Rand1()
        {
            int a = _random.Next(1, 12);
            return a;
        }
        public int Rand7()
        {
            int b = _random.Next(1, 9);
            while (b == rchislo | b == chislo)
            {
                b = _random.Next(1, 9);
            }
            
            return b;
        }
        public int Rand7_1()
        {
            int b = _random.Next(1, 9);
            while (b == rchislo | b == chislo | rchislo + chislo == 10)
            {
                b = _random.Next(1, 9);
            }

            return b;
        }
        public int Rand1379()
        {
            int b = _random.Next(1, 9);
            while (b == 2 | b == 4 | b == 6 | b == 8 | b == 5)
            {
                b = _random.Next(1, 9);
            }

            return b;
        }
        public int Rand1379_1()
        {
            int b = _random.Next(1, 9);
            while (b == 2 | b == 4 | b == 6 | b == 8 | b == 5 | b == rchislo | b == chislo)
            {
                b = _random.Next(1, 9);
            }
            

            return b;
        }
        public int Randnew()
        {
            int b = _random.Next(1, 9);
            while (b == rchislo | b == chislo | b == chislo2)
            {
                b = _random.Next(1, 9);
            }

            return b;
        }

        //private int RandomByTwo(int first, int second)
        //{
        //    return _random.Next(0, 1) == 0 ? first : second;
        //}

        public string[] massiv = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void X()
        {
            int x = hui();
            rchislo = x;
            massiv[x-1] = "х";
        }
    
        public void Hod2()
        {
            dop = 0;
            int x = rchislo + chislo;
            if (rchislo == 2 | rchislo == 4 | rchislo == 6 | rchislo == 8)
            {
                if (vtoroihod == "1" | vtoroihod == "3" | vtoroihod == "7" | vtoroihod == "9")
                {
                    massiv[Rand7()-1] = "х";
                    massiv[chislo - 1] = "0";
                }
                else if (vtoroihod == "5")
                {
                    massiv[Rand7_1() - 1] = "х";
                    massiv[chislo - 1] = "0";
                }
                // противоположная сторона
                else if (hui() + chislo == 10)
                {
                    massiv[Rand7() - 1] = "х";
                    massiv[chislo - 1] = "0";
                }
                else
                {
                    dop = 1;
                    massiv[4] = "х";
                    massiv[chislo - 1] = "0";
                }
            }
            else if (rchislo == 5)
            {
                if (vtoroihod == "1" | vtoroihod == "3" | vtoroihod == "7" | vtoroihod == "9")
                {
                    massiv[Rand7_1() - 1] = "х";
                    massiv[chislo - 1] = "0";
                }
                else
                {
                    massiv[Rand1379()-1] = "х";
                    massiv[chislo - 1] = "0";
                }
            }
            else
            {
                if (vtoroihod == "2" | vtoroihod == "4" | vtoroihod == "6" | vtoroihod == "8")
                {
                    massiv[4] = "х";
                    massiv[chislo - 1] = "0";
                }
                else if (vtoroihod == "5")
                {
                    massiv[10 - rchislo - 1] = "х";
                    massiv[chislo - 1] = "0";
                }
                
                else if (x == 10)
                {
                    massiv[Rand1379_1()-1] = "х";
                    massiv[chislo - 1] = "0";
                }
                else
                {
                    massiv[10 - chislo-1] = "х";
                    massiv[chislo - 1] = "0";
                }
            }
        }
        public void Hod3()
        {
            massiv[chislo2 - 1] = "0";

            if (c.hz() == 33 & dop == 1)
            {
                massiv[Randnew() - 1] = "х";
            }
            if (c.hz() == 33)
            {
                massiv[Randnew() - 1] = "х";
            }
            else
            {
                massiv[c.hz()] = "х";
            }
           
            

        }
        public void iditenahui()
        {
            Console.WriteLine("{0}{1}{2}\n{3}{4}{5}\n{6}{7}{8}\nделайте ход", massiv[0], massiv[1], massiv[2], massiv[3], massiv[4], massiv[5], massiv[6], massiv[7], massiv[8]);
            //Console.WriteLine(Rand1());
            //Console.WriteLine(Rand7());
            //Console.WriteLine(Rand7_1());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Krestiki a = new Krestiki();
            string[] masiv = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string krilinol;
            Console.WriteLine("Выберите х или 0");
            krilinol = Console.ReadLine();
            krilinol = krilinol.ToLower();
            if (krilinol == "х")
            {
                Console.WriteLine("{0}{1}{2}\n{3}{4}{5}\n{6}{7}{8}\nделайте ход", masiv[0], masiv[1], masiv[2], masiv[3], masiv[4], masiv[5], masiv[6], masiv[7], masiv[8]);
            }
            else if (krilinol == "0")
            {
                a.X();
                a.iditenahui();
                a.vtoroihod = Console.ReadLine();
                a.chislo = Convert.ToInt32(a.vtoroihod);
                a.Hod2();
                a.iditenahui();
                a.tretiihod = Console.ReadLine();
                a.chislo2 = Convert.ToInt32(a.tretiihod);
                a.Hod3();
                a.iditenahui();
            }
            
            Console.WriteLine("\n\n\n");
            Console.ReadLine();

        }
    }
}
