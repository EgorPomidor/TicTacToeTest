using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krestikinoliki
{
    //Новый коммент
    class Proga
    {
        // bhf ;jgf
        private int[] massiv1 = new int[9];

        private Krestiki b;
        public int kill;

        public Proga(Krestiki b)
        {
            this.b = b;
        }
        public int hz()
        {
            kill = 0;
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
                kill = 1;
                if (massiv1[0] == 100) { return 0; }
                if (massiv1[1] == 100) { return 1; }
                if (massiv1[2] == 100) { return 2; }
            }
            if (massiv1[3] + massiv1[4] + massiv1[5] == 102)
            {
                kill = 1;
                if (massiv1[3] == 100) { return 3; }
                if (massiv1[4] == 100) { return 4; }
                if (massiv1[5] == 100) { return 5; }
            }
            if (massiv1[6] + massiv1[7] + massiv1[8] == 102)
            {
                kill = 1;
                if (massiv1[6] == 100) { return 6; }
                if (massiv1[7] == 100) { return 7; }
                if (massiv1[8] == 100) { return 8; }
            }
            if (massiv1[0] + massiv1[3] + massiv1[6] == 102)
            {
                kill = 1;
                if (massiv1[0] == 100) { return 0; }
                if (massiv1[3] == 100) { return 3; }
                if (massiv1[6] == 100) { return 6; }
            }
            if (massiv1[1] + massiv1[4] + massiv1[7] == 102)
            {
                kill = 1;
                if (massiv1[1] == 100) { return 1; }
                if (massiv1[4] == 100) { return 4; }
                if (massiv1[7] == 100) { return 7; }
            }
            if (massiv1[2] + massiv1[5] + massiv1[8] == 102)
            {
                kill = 1;
                if (massiv1[2] == 100) { return 2; }
                if (massiv1[5] == 100) { return 5; }
                if (massiv1[8] == 100) { return 8; }
            }
            if (massiv1[0] + massiv1[4] + massiv1[8] == 102)
            {
                kill = 1;
                if (massiv1[0] == 100) { return 0; }
                if (massiv1[4] == 100) { return 4; }
                if (massiv1[8] == 100) { return 8; }
            }
            if (massiv1[2] + massiv1[4] + massiv1[6] == 102)
            {
                kill = 1;
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

        public string vtoroihod, tretiihod, prosral, chetvertyihod, piatyihod;
        public int chislo, h1, chislo2, dop, chislo3, chislo4, h2, h3, h4, h5;
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
            while (b == h1 | b == chislo)
            {
                b = _random.Next(1, 9);
            }
            return b;
        }
        public int Rand7_1()
        {
            int b = _random.Next(1, 9);
            while (b == h1 | b == chislo | h1 + b == 10)
            {
                b = _random.Next(1, 9);
            }
            return b;
        }
        public int Rand1379()
        {
            if (chislo == 2)
                return _random.Next(0, 1) == 0 ? 7 : 9;
            if (chislo == 4)
                return _random.Next(0, 1) == 0 ? 3 : 9;
            if (chislo == 6)
                return _random.Next(0, 1) == 0 ? 1 : 7;
            if (chislo == 8)
                return _random.Next(0, 1) == 0 ? 1 : 3;
            return 1;
        }
        public int Rand1379_1()
        {
            int b = _random.Next(1, 9);
            while (b == 2 | b == 4 | b == 6 | b == 8 | b == 5 | b == h1 | b == chislo)
            {
                b = _random.Next(1, 9);
            }
            return b;
        }
        public int Rand1379_2()
        {
            if (h1 == 2)
                return _random.Next(0, 1) == 0 ? 1 : 3;
            if (h1 == 4)
                return _random.Next(0, 1) == 0 ? 1 : 7;
            if (h1 == 6)
                return _random.Next(0, 1) == 0 ? 9 : 3;
            if (h1 == 8)
                return _random.Next(0, 1) == 0 ? 7 : 9;
            return 1;
        }
        public int RandNeProtivUgol()
        {
            if (h1 == 1)
                return _random.Next(0, 1) == 0 ? 7 : 3;
            if (h1 == 3)
                return _random.Next(0, 1) == 0 ? 1 : 9;
            if (h1 == 7)
                return _random.Next(0, 1) == 0 ? 9 : 1;
            if (h1 == 9)
                return _random.Next(0, 1) == 0 ? 7 : 3;
            return 1;
        }

        public int Randnew()
        {
            int b = _random.Next(1, 9);
            while (b == h1 | b == chislo | b == chislo2 | b == h2)
            {
                b = _random.Next(1, 9);
            }

            return b;
        }
        public int Randnew1()
        {
            int b = _random.Next(1, 9);
            while (b == h1 | b == chislo | b == chislo2 | b == chislo3 | b == h2 | b == h3)
            {
                b = _random.Next(1, 9);
            }

            return b;
        }
        public int Randnew2()
        {
            for (int i = 0; i<9; i++)
            {
                if (massiv[i] != "х" | massiv[i] != "0") { return i; }
            }
             
            return 1;
        }

        public string[] massiv = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void X()
        {
            int x = hui();
            h1 = x;
            massiv[x-1] = "х";
        }
    
        public void Hod2()
        {
            massiv[chislo - 1] = "0";
            dop = 0;
            if (h1 == 2 | h1 == 4 | h1 == 6 | h1 == 8)
            {
                if (vtoroihod == "1" | vtoroihod == "3" | vtoroihod == "7" | vtoroihod == "9")
                {
                    h2 = Rand7() - 1;
                    massiv[h2] = "х";
                }
                else if (vtoroihod == "5")
                {
                    h2 = Rand7_1() - 1;
                    massiv[h2] = "х";
                }
                // противоположная сторона
                else if (h1 + chislo == 10)
                {
                    h2 = Rand7() - 1;
                    massiv[h2] = "х";
                }
                else
                {
                    dop = 1;
                    massiv[4] = "х";
                }
            }
            else if (h1 == 5)
            {
                if (vtoroihod == "1" | vtoroihod == "3" | vtoroihod == "7" | vtoroihod == "9")
                {
                    h2 = Rand7() - 1;
                    massiv[h2] = "х";
                }
                else
                {
                    h2 = Rand1379() - 1;
                    massiv[h2] = "х";
                }
            }
            else
            {
                if (vtoroihod == "2" | vtoroihod == "4" | vtoroihod == "6" | vtoroihod == "8")
                {
                    h2 = RandNeProtivUgol();
                    massiv[h2] = "х";
                }
                else if (vtoroihod == "5")
                {
                    h2 = 10 - h1 - 1;
                    massiv[h2] = "х";
                }
                // противоположный угол
                else if (h1 + chislo == 10)
                {
                    dop = 2;
                    h2 = Rand1379_1() - 1;
                    massiv[h2] = "х";
                }
                //не противоположный угол
                else
                {
                    h2 = 10 - chislo - 1;
                    massiv[h2] = "х";
                }
            }
        }
        public void Hod3()
        {
            massiv[chislo2 - 1] = "0";

            if (c.hz() == 33 & dop == 1)
            {
                h3 = Rand1379_2() - 1;
                massiv[h3] = "х";
                return;
            }
            if (dop == 2)
            {
                h3 = 8 - h2;
                massiv[h3] = "х";
                return;
            }

            if (c.hz() == 33)
            {
                h3 = Randnew() - 1;
                massiv[h3] = "х";
            }
            else
            {
                h3 = c.hz();
                massiv[h3] = "х";
            }
        }
        public void Hod4()
        {
            massiv[chislo3 - 1] = "0";
            
            if (c.hz() == 33)
            {
                h4 = Randnew1() - 1;
                massiv[h4] = "х";
            }
            else
            {
                h4 = c.hz();
                massiv[h4] = "х";
            }
        }
        public void Hod5()
        {
            massiv[chislo4 - 1] = "0";
            h5 = Randnew2() - 1;
            massiv[h5] = "х";
        }

        public void iditenahui()
        {
            int a = _random.Next(0, 2);
            string[] prosral1 = new string[] { "мне жаль(((", "ты лох азазазазаз", "просрал" };
            prosral = prosral1[a];
            if (c.kill == 1)
            {
                Console.WriteLine("{0}{1}{2}\n{3}{4}{5}\n{6}{7}{8}\n{9}", massiv[0], massiv[1], massiv[2], massiv[3], massiv[4], massiv[5], massiv[6], massiv[7], massiv[8], prosral);
            }
            else
            {
                Console.WriteLine("{0}{1}{2}\n{3}{4}{5}\n{6}{7}{8}\nделайте ход", massiv[0], massiv[1], massiv[2], massiv[3], massiv[4], massiv[5], massiv[6], massiv[7], massiv[8]);
                
            }
        }
        public void iditenahui1()
        {
                Console.WriteLine("{0}{1}{2}\n{3}{4}{5}\n{6}{7}{8}\nничья", massiv[0],
                    massiv[1], massiv[2], massiv[3], massiv[4], massiv[5], massiv[6], massiv[7], massiv[8]);
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

                a.chetvertyihod = Console.ReadLine();
                a.chislo3 = Convert.ToInt32(a.chetvertyihod);
                a.Hod4();
                a.iditenahui();

                a.piatyihod = Console.ReadLine();
                a.chislo4 = Convert.ToInt32(a.piatyihod);
                a.Hod5();
                a.iditenahui1();
            }
            
            Console.WriteLine("\n\n\n");
            Console.ReadLine();

        }
    }
}
