using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_12_01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a mátrix sorainak számát! ");
            int sor = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a mátrix oszlopainak számát! ");
            int oszlop = int.Parse(Console.ReadLine());
            int[,] m = new int[sor, oszlop];
            bool h = false;
            while (h == false)
            {
                Console.WriteLine();
                Console.WriteLine("Válassz egy menüpontot: ");
                Console.WriteLine("0 Kilépés.");
                Console.WriteLine("1 Mátrix feltöltése.");
                Console.WriteLine("2 Mátrix minimumának megkeresése.");
                Console.WriteLine("3 Mátrix maximumának megkeresése.");
                Console.WriteLine("4 Mátrix elmeinek Átlagának megkeresése.");
                Console.WriteLine("5 Van-e 12-es érték a mátrixban.");
                Console.WriteLine("6 Mátrix eleminek növekvő sorrendbe rendezése.");
                Console.WriteLine("7 Mátrix eleminek csökkenő sorrendbe rendezése.");
                Console.WriteLine("8 Mátrix szétválasztása páros és páratlan részekre.");
                Console.WriteLine();

                Console.WriteLine("Add meg melyik menüpontba szeretnél menni! ");
                int valasztas = int.Parse(Console.ReadLine());
                if (valasztas == 0)
                {
                    h = true;
                }
                else if (valasztas == 1)
                {
                    Console.WriteLine("\nAdd meg a mátrix elemiet:");
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            m[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("\nA mátrix: ");
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            Console.Write(m[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (valasztas == 2)
                {
                    int minimum = m[0, 0];
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            if (minimum > m[i, j])
                                minimum = m[i, j];
                        }
                    }
                    Console.WriteLine("\nA mátrix minimuma: " + minimum);
                }

                else if (valasztas == 3)
                {
                    int max = 0;
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            if (max < m[i, j])
                            {
                                max = m[i, j];
                            }
                        }
                    }
                    Console.WriteLine("\nA mátrix maximuma: " + max);
                }

                else if (valasztas == 4)
                {
                    int osszeg = 0;
                    int db = 0;
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            osszeg += m[i, j];
                            db += 1;
                        }
                    }
                    Console.WriteLine("A mátrix átlaga: " + (double)osszeg / db);
                }

                else if (valasztas == 5)
                {
                    bool a = false;
                    Console.WriteLine("\nA mátrix: ");
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            if (m[i, j] == 12)
                            {
                                a = true;
                            }
                            Console.Write(m[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    if (a == true)
                    {
                        Console.WriteLine("\nVan benne 12-es szám.");
                    }
                    else
                    {
                        Console.WriteLine("\nNincs benne 12-es szám.");
                    }
                }
                else if (valasztas == 6)
                {
                    Console.WriteLine("\nA mátrix: ");
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            Console.Write(m[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nA Rendezett Mátrix:");
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            for(int k  = 0; k < m.GetLength(1); k++)
                            {
                                for (int l = 0; l < m.GetLength(1); l++)
                                {
                                    if (m[i, j] < m[k, l])
                                    {
                                        int temp = m[i, j];
                                        m[i, j] = m[k, l];
                                        m[k, l] = temp;
                                    }
                                }
                            }
                        }
                    }
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            Console.Write(m[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                else if (valasztas == 7)
                {
                    Console.WriteLine("\nA mátrix: ");
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            Console.Write(m[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nA Rendezett Mátrix:");
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            for (int k = 0; k < m.GetLength(1); k++)
                            {
                                for (int l = 0; l < m.GetLength(1); l++)
                                {
                                    if (m[i, j] > m[k, l])
                                    {
                                        int temp = m[i, j];
                                        m[i, j] = m[k, l];
                                        m[k, l] = temp;
                                    }
                                }
                            }
                        }
                    }
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            Console.Write(m[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (valasztas == 8)
                {
                    int parosh = 0;
                    int paratlanh = 0;
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            if (m[i, j] % 2 == 0)
                            {
                                parosh += 1;
                            }
                            else
                            {
                                paratlanh += 1;
                            }
                        }
                    }
                    int[] parost = new int[parosh];
                    int[] paratlant = new int[paratlanh];
                    int parosindex = 0;
                    int paratlanindex = 0;
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            if(m[i,j] % 2 == 0)
                            {
                                parost[parosindex] = m[i, j];
                                parosindex += 1;
                            }         
                            else
                            {
                                paratlant[paratlanindex] = m[i, j];
                                paratlanindex += 1;
                            }
                        }
                    }
                    Console.WriteLine("\nA páros részei a mátrixnak: ");
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                            Console.Write(parost[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("\npáratlan részei a mátrixnak:");
                    for (int i = 0; i < m.GetLength(0); i++)
                    {  
                            Console.Write(paratlant[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
