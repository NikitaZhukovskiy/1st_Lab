﻿using System;

namespace _1stLab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 4
            Console.WriteLine($"_LEVEL_1_");

            double x;
            Console.WriteLine($"Enter x for task 4:");
            double.TryParse(Console.ReadLine(), out x);
            double s4 = 0;
            if (x != 0)
            {
                for (int n = 1; n <= 9; n = n + 1)
                {
                    s4 += Math.Cos(n * x) / (Math.Pow(x, n - 1));
                }
                Console.WriteLine($"Task 4: S = {s4}\n");
            }
            #endregion


            #region Task 9

            double s9 = 0;
            double fact = 1;
            for (int n = 1; n <= 6; n = n + 1)
            {
                fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                s9 += (Math.Pow(-1, n) * Math.Pow(5, n)) / fact;

            }
            Console.WriteLine($"Task 9: S = {s9}\n");
            #endregion



            #region Task 15

            int n15, i15;
            double chisltek, chislprosh, znamtek, znamprosh, buff;


            i15 = 3;
            Console.WriteLine($"What is the term of the sequence to find:");
            Int32.TryParse(Console.ReadLine(), out n15);

            chisltek = 2;
            chislprosh = 1;
            znamtek = 1;
            znamprosh = 1;
            buff = 0;

            if (n15 >= 3)
            {
                Console.WriteLine($"Task 15:");
                for (double s15 = 0; i15 <= n15; i15 += 1)
                {
                    buff = chisltek + chislprosh;

                    chislprosh = chisltek;
                    chisltek = buff;


                    buff = znamtek + znamprosh;

                    znamprosh = znamtek;
                    znamtek = buff;
                    s15 = chisltek / znamtek;
                    Console.WriteLine($"{i15} member of the sequence is {s15}");
                }
                Console.WriteLine(" ");
            }
            #endregion

            #region Task 16

            double a16 = 1;
            double s16 = 0;

            for (int i = 0; i <= 64; i = i + 1)
            {
                a16 = Math.Pow(2, i);
                s16 = s16 + a16;
            }
            double count16 = s16 / 15;
            Console.WriteLine($"Task 16: Will be {count16} grams\n");

            #endregion

            #region Task 18

            int count18 = 10;
            int a18 = 0;
            Console.WriteLine($"Task 18:");
            for (int i = 3; i <= 24; i = i + 3)
            {
                a18 = count18 * 2;
                count18 = a18;

                Console.WriteLine($"In {i} hours will be {a18} cells");
            }
            Console.WriteLine(" ");

            #endregion

            #region Level 2 Task 2
            Console.WriteLine(" ");
            Console.WriteLine($"_LEVEL_2_\n");

            int p2 = 1;
            int n2 = 1;
            while (p2 < 30000)
            {
                n2 = n2 + 3;
                p2 = p2 * n2;
            }
            n2 = n2 - 3;
            Console.WriteLine($"Task 2: answer is {n2}\n");
            #endregion


            #region Task 4 

            double x4;
            Console.WriteLine($"Enter x for task 4 (lvl_2): ");
            double.TryParse(Console.ReadLine(), out x4); 
            double s42 = 1;
            if ((x4 < 1) && (x4 > -1) && (x4 != 0))
            {
                double powx4 = x4 * x4;
                x4 = powx4;

                while (x4 >= 0.0001)
                {
                    s42 += x4;
                    x4 *= powx4;
                }
                Console.WriteLine($"Task 4: answer is {s42}\n");
            }
            #endregion


            #region Task 7, 8

            double Day_1_Distance = 10;
            double s7 = 0;
            double AllDistance = 0;
            double DistanceFor7Days = 0;
            int nday = 1;

            for (; nday <= 6; nday += 1)
            {
                s7 = Day_1_Distance + (Day_1_Distance * 0.1);
                Day_1_Distance = s7;
                AllDistance += s7;
            }

            DistanceFor7Days = AllDistance + 10;

            Console.WriteLine($"Tasks 7,8: а) {DistanceFor7Days}");

            Day_1_Distance = 10;
            AllDistance = 0;
            s7 = 0;
            nday = 1;

            while (AllDistance < 100)
            {

                s7 = Day_1_Distance + (Day_1_Distance * 0.1);
                Day_1_Distance = s7;
                AllDistance += s7;
                nday += 1;

            }

            Console.WriteLine($"Tasks 7,8: б) {nday}");

            Day_1_Distance = 10;
            nday = 1;


            while (Day_1_Distance < 20)
            {
                Day_1_Distance += Day_1_Distance * 0.1;
                nday = nday + 1;
            }

            Console.WriteLine($"Tasks 7,8: в) {nday}");

            #endregion


            #region Level 3 Task 1


            Console.WriteLine(" ");
            Console.WriteLine($"_LEVEL_3_\n");

            double s1, a1, x1, y1, dobavka;
            double znak;
            znak = -1;

            Console.WriteLine($"Task 1 (lvl_3):");

            for (x1 = 0.1; x1 <= 1; x1 += 0.1)
            {

                s1 = 1;
                a1 = 1;
                fact = 1;
                dobavka = 0;

                for (int i = 1; Math.Abs(a1) > 0.0001; i++)
                {
                    fact *= (i + dobavka) * (i + dobavka + 1);

                    a1 = Math.Pow(znak, i) * Math.Pow(x1, 2 * i) / (fact);
                    s1 = s1 + a1;

                    dobavka += 1;
                }
                y1 = Math.Cos(x1);

                Console.WriteLine($"x={Math.Round(x1, 3)} \t y={Math.Round(y1, 3)} \t s={Math.Round(s1, 3)}");

            }
            Console.WriteLine();

            #endregion

            #region Task 8

            double x8, s8, a8, y8;

            Console.WriteLine($"Task 8 (lvl_3):");

            for (x8 = 0.1; x8 <= 1 + 0.0001; x8 += 0.05)
            {
                s8 = 1;
                a8 = 1;
                fact = 1;
                for (int i = 1; Math.Abs(a8) > 0.0001; i += 1)
                {
                    fact *= i;
                    a8 = Math.Pow(2 * x8, i) / (fact);
                    s8 += a8;
                }

                y8 = Math.Pow(Math.E, 2 * x8);

                Console.WriteLine($"x={Math.Round(x8, 3)} \t y={Math.Round(y8, 3)} \t s={Math.Round(s8, 3)}");
            }
            Console.WriteLine();

            #endregion


        }
    }
}
