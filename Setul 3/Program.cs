using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Setul_3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numarul exercitiului(1-31): ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1) ex1();
            if (n == 2) ex2();
            if (n == 3) ex3();
            if (n == 4) ex4();
            if (n == 5) ex5();
            if (n == 6) ex6();
            if (n == 7) ex7();
            if (n == 8) ex8();
            if (n == 9) ex9();
            if (n == 10) ex10();
            if (n == 11) ex11();
            if (n == 12) ex12();
            if (n == 13) ex13();
            if (n == 14) ex14();
            if (n == 15) ex15();
            if (n == 16) ex16();
            if (n == 17) ex17();
            if (n == 18) ex18();
            if (n == 19) ex19();
            if (n == 20) ex20();
            if (n == 21) ex21();
            if (n == 22) ex22();
            if (n == 23) ex23();
            if (n == 24) ex24();
            if (n == 25) ex25();
            if (n == 26) ex26();
            if (n == 27) ex27();
            if (n == 28) ex28();
            if (n == 29) ex29();
            if (n == 30) ex30();
            if (n == 31) ex31();
            if (n > 31 || n < 1) Main();
        }

        static void ex1()
        {
            Console.WriteLine("1.Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, s = 0;

            for (i = 0; i < n; i++)
            { 
                v[i] = int.Parse(Console.ReadLine());
                s += v[i];
            }

            Console.WriteLine(s);
            Main();
        }
        static void ex2()
        {
            Console.WriteLine("2.Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. ");
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i;

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine("Prima pozitie din vector pe care apare " + k + " este " +(i+1));
                    break;
                }
            }


            Main();
        }
        static void ex3()
        {
            Console.WriteLine("3.Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, max, min;

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            max = v[0];
            min = v[0];
            for (i = 1; i < n; i++)
            {
                if (v[i] > max)
                    max = v[i];
                else if (v[i] < min)
                    min = v[i];
            }
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);

            Main();
        }
        static void ex4()
        {
            Console.WriteLine("4.Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, min, max, nrmin = 1, nrmax = 1;

            v[0] = int.Parse(Console.ReadLine());
            min = v[0];
            max = v[0];
            for(i = 1; i < n; i ++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] > max)
                {
                    max = v[i];
                    nrmax = 1;
                }
                if (v[i] < min)
                {
                    min = v[i];
                    nrmin = 1;
                }
                if (v[i] == min)
                    nrmin++;
                if (v[i] == max)
                    nrmax++;
            }
            if (v[0] != max)
                nrmax--;
            if (v[0] != min)
                nrmin--;
            Console.WriteLine("Cel mai mare nr este " + max + " si apare de " + (nrmax));
            Console.WriteLine("Cel mai mic nr este " + min + " si apare de " + (nrmin));

            Main();
        }
        static void ex5()
        {
            Console.WriteLine("5.Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            int i, e, k;

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine()); 

            Console.Write("e = ");
            e = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());

            for (i = n; i > k; i--)
                v[i] = v[i - 1];

            v[k] = e;

            for (i = 0; i < n + 1; i++)
                Console.Write(v[i] + " "); 
            Console.WriteLine();

            Main();
        }
        static void ex6()
        {
            Console.WriteLine("6.Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, k;

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());

            for (i = k; i < n - 1; i++)
                v[i] = v[i + 1];

            for (i = 0; i < n - 1; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

            Main();
        }
        static void ex7()
        {
            Console.WriteLine("7.Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, aux = 0;

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            for(i = 0; i < n / 2; i++)
            {
                aux = v[i];
                v[i] = v[n - 1 - i];
                v[n- 1 - i] = aux;
            }
            
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

            Main();
        }
        static void ex8()
        {
            Console.WriteLine("8.Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, aux;

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            aux = v[0];
            for (i = 0; i < n - 1; i++)
                v[i] = v[i + 1];
            v[n - 1] = aux;

            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

            Main();
        }
        static void ex9()
        {
            Console.WriteLine("9.Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, aux, k;

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
            for(int j = 0; j < k ; j++)
            {
                aux = v[0];
                for (i = 0; i < n - 1; i++)
                    v[i] = v[i + 1];
                v[n - 1] = aux;
            }

            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

            Main();
        }
        static void ex10()
        {
            Console.WriteLine("10.Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, poz = -1, k, max = n, min = -1, j = 0;
            
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());

            for (i = n / 2; j < n / 2; j++)
            {
                if (k == v[i])
                {
                    poz = i;
                    break;
                }
                if (v[i] < k)
                {
                    min = i;
                    i = (max + min) / 2;
                }
                else
                {
                    max = i;
                    i = (max + min) / 2;
                }
            }

            Console.WriteLine(poz);

            Main();
        }
        static void ex11()
        {
            Console.WriteLine("11.Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int i, steag = 0;

            if (n == 6 || n == 5)
                Console.WriteLine(2 + " " + 3 + " " + 5);
            if (n == 4 || n == 3)
                Console.WriteLine(2 + " " + 3);
            if (n == 2)
                Console.WriteLine(2);
            if (n < 2)
                Console.WriteLine("Nu exista un numar pirm care este mai mic sau egal cu " + n);

            if (n > 6)
            {
                Console.Write(2 + " ");
                for (i = 3; i <= n; i += 2)
                {
                    steag = 0;
                    for (int j = 3; j < i / 2; j += 2)
                    {
                        if (i % j == 0)
                            steag = 1;
                    }
                    if (steag == 0)
                        Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Main();
        }
        static void ex12()
        {
            Console.WriteLine("12.Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Random rnd = new Random();
            int i, aux;

            for (i = 0; i < n; i++)
                v[i] = rnd.Next(1, 100);

            for (i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }

            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
            Main();     
        }
        static void ex13()
        {
            Console.WriteLine("13.Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, aux;
            Random rnd = new Random();

            for (i = 0; i < n; i++)
                v[i] = rnd.Next(1, 100);

            for (i = 1; i < n; i++)
            {
                if (v[i] < v[i - 1])
                {
                    aux = v[i];
                    v[i] = v[i - 1];
                    v[i - 1] = aux;
                    if (i == 1)
                        i -= 1;
                    else
                        i -= 2;
                }
            }

            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
            Main();
        }
        static void ex14()
        {
            Console.WriteLine("14.Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, aux, a = n;

            for (i = 0; i < a; i++)
            {
                aux = int.Parse(Console.ReadLine());
                if(aux == 0)
                {
                    v[a-1] = aux;
                    a--;
                    i--;
                }
                else
                {
                    v[i] = aux;
                }
            }

            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
            Main();
        }
        static void ex15()
        {
            Console.WriteLine("15.Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, aux;

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] == v[j])
                    {
                        aux = v[n-1];
                        v[n-1] = v[j];
                        v[j] = aux;
                        n--;
                        j--;
                    }
                }

            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
            Main();
        }
        static void ex16()
        {
            Console.WriteLine("16.Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i, a, b, cmmdc;

            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            cmmdc = v[0];
            for (i = 1; i < n; i++)
            {
                a = cmmdc;
                b = v[i];
                while(a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                cmmdc = a;
            }

            Console.WriteLine("CMMDC = " + cmmdc);
            Main();
        }
        static void ex17()
        {
            Console.WriteLine("17.Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            if (b == 10)
                Console.WriteLine(n);
            else if (b < 10)
            {
                int nr = 1, i;
                while (n > 0)
                {
                    nr = nr * 10 + n % b;
                    n /= b;
                }
                i = nr;
                nr = 0;
                while (i > 0)
                {
                    nr = nr * 10 + i % 10;
                    i /= 10;
                }
                Console.WriteLine(nr / 10);
            }
            else if (b > 10)
            {
                char[] v  = {'a', 'b', 'c', 'd', 'e', 'f'};
                string invers = "";
                while (n > 0)
                {
                    if(n % b > 9)
                    {
                        invers += v[n % b % 10];
                    }
                    else
                        invers += n % b;
                    n /= b;
                }
                char[] aux = invers.ToCharArray();
                string nr = "";
                for (int j = aux.Length - 1; j > -1; j--)
                {
                    nr += aux[j];
                }
                Console.WriteLine(nr);
            }
            
            Main();
        }
        static void ex18()
        {
           
        }
        static void ex19()
        {
            Console.WriteLine("19.Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).");
            Console.WriteLine("Screieti vectorii pe o linie cu un spatiu intre numere!");
            Console.Write("s = ");
            string[] S = Console.ReadLine().Split(' ');
            Console.Write("p = ");
            string[] P = Console.ReadLine().Split(' ');

            int[] s = new int[S.Length];
            int[] p = new int[P.Length];

            int i, j, steag = 0, suma = 0;
            for (i = 0; i < S.Length; i++)
                s[i] = int.Parse(S[i]);
            for (i = 0; i < P.Length; i++)
                p[i] = int.Parse(P[i]);

            for (i = 0; i <= S.Length - P.Length; i++)
            {
                steag = 0;
                for (j = 0; j < P.Length; j++)
                {
                    if (s[i + j] != p[j])
                    {
                        steag = 1;
                        break;
                    }
                }
                if (steag == 0)
                    suma++;
            }
            Console.WriteLine(suma);

            Main();
        }
        static void ex20()
        {
            Console.WriteLine("20.Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. ");
            Console.WriteLine("Screieti 2 vectorii de aceeasi dimensriune cu un spatiu intre numere, ex 1 0 0 1 0 1(0 = alb, 1 = negru)");
            Console.Write("s1 = ");
            string[] S1 = Console.ReadLine().Split(' ');
            Console.Write("s2 = ");
            string[] S2 = Console.ReadLine().Split(' ');

            int[] s1 = new int[S1.Length];
            int[] s2 = new int[S2.Length];

            int i;
            for (i = 0; i < S1.Length; i++)
                s1[i] = int.Parse(S1[i]);
            for (i = 0; i < S2.Length; i++)
                s2[i] = int.Parse(S2[i]);

            int nrmax = 0;
            for (int j = 0; j < s2.Length; j++) 
            {
                int aux = 0;
                for (i = 0; i < s1.Length; i++)
                    if (s1[i] == s2[i])
                        aux++;

                if (aux > nrmax)
                    nrmax = aux;

                aux = s2[0];
                for (i = 1; i < s2.Length; i++)
                    s2[i - 1] = s2[i];
                s2[s2.Length - 1] = aux;
            }
            Console.WriteLine(nrmax);

            Main();
        }
        static void ex21()
        {
            Console.WriteLine("21.Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar).");
            Console.WriteLine("Screieti 2 vectorii cu un spatiu intre numere, ex: d a s s a f s");
            Console.Write("v1 = ");
            string[] V1 = Console.ReadLine().Split(' ');
            Console.Write("v2 = ");
            string[] V2 = Console.ReadLine().Split(' ');
            
            char[] v1 = new char[V1.Length];
            char[] v2 = new char[V2.Length];

            int i, n;
            for (i = 0; i < V1.Length; i++)
                v1[i] = char.Parse(V1[i]);
            for (i = 0; i < V2.Length; i++)
                v2[i] = char.Parse(V2[i]);
            
            if(v1.Length < v2.Length)
                n = v1.Length;
            else
                n = v2.Length;

            for (i = 0; i < n; i++)
            {
                if (v1[i] < v2[i])
                {
                    Console.WriteLine(v1);
                    Console.WriteLine(v2);
                    break;
                }
                else if (v1[i] > v2[i])
                {
                    Console.WriteLine(v2);
                    Console.WriteLine(v1);
                    break;
                }
                
                if (i == n - 1 && v1.Length == v2.Length)
                {
                    Console.WriteLine("sirurile sunt egale");
                    Console.WriteLine(v1);
                    Console.WriteLine(v2);
                }
                else if (i == n - 1)
                {
                    if (v1.Length > v2.Length)
                    {
                        Console.WriteLine(v2);
                        Console.WriteLine(v1);
                    }
                    else
                    {
                        Console.WriteLine(v1);
                        Console.WriteLine(v2);
                    }
                }
            }

            Main();
        }
        static void ex22()
        {
            Console.WriteLine("22.Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. ");
            Console.WriteLine("Screieti 2 vectorii cu un spatiu intre numere, ex: 1 8 1 6 1 8 1 9 9 6");
            Console.Write("v1 = ");
            string[] V1 = Console.ReadLine().Split(' ');
            Console.Write("v2 = ");
            string[] V2 = Console.ReadLine().Split(' ');

            int[] v1 = new int[V1.Length];
            int[] v2 = new int[V2.Length];

            int i, j, n, m, a;
            for (i = 0; i < V1.Length; i++)
                v1[i] = int.Parse(V1[i]);
            for (i = 0; i < V2.Length; i++)
                v2[i] = int.Parse(V2[i]);
            n = v1.Length;
            m = v2.Length;

            int[] aux = new int[n + m];

            // v1 reunit cu v2 //

            for (i = 0; i < n; i++)
                aux[i] = v1[i];
            for (i = 0; i < m; i++)
                aux[i + n] = v2[i];
            a = m + n;

            for (i = 0; i < a; i++)
                for (j = i + 1; j < a; j++)
                    if (aux[i] == aux[j])
                    {
                        int k;
                        k = aux[j];
                        aux[j] = aux[a - 1];
                        aux[a - 1] = k;
                        a--;
                        j--;
                    }

            Console.Write("v1 reunit cu v2 = { ");
            for (i = 0; i < a; i++)
                Console.Write(aux[i] + " ");
            Console.WriteLine("}");

            // v1 intersectat cu v2 //

            aux = new int[n + m];
            int x = 0;
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        aux[x] = v1[i];
                        x++;
                        break;
                    }
                }

            for (i = 0; i < x; i++)
                for (j = i + 1; j < x; j++)
                    if (aux[i] == aux[j])
                    {
                        int k;
                        k = aux[j];
                        aux[j] = aux[x - 1];
                        aux[x - 1] = k;
                        x--;
                        j--;
                    }

            Console.Write("v1 intersectat cu v2 = { ");
            for (i = 0; i < x; i++)
                Console.Write(aux[i] + " ");
            Console.WriteLine("}");

            // v1 - v2 //

            aux = new int[n + m];
            x = 0;
            int steag;
            for (i = 0; i < n; i++)
            {
                steag = 0;
                for (j = 0; j < m; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        steag = 1;
                        break;
                    }
                }
                if (steag == 0)
                {
                    aux[x] = v1[i];
                    x++;
                }
            }

            for (i = 0; i < x; i++)
                for (j = i + 1; j < x; j++)
                    if (aux[i] == aux[j])
                    {
                        int k;
                        k = aux[j];
                        aux[j] = aux[x - 1];
                        aux[x - 1] = k;
                        x--;
                        j--;
                    }
            Console.Write("v1 - v2 = { ");
            for (i = 0; i < x; i++)
                Console.Write(aux[i] + " ");
            Console.WriteLine("}");

            // v2 - v1 //

            aux = new int[n + m];
            x = 0;
            for (i = 0; i < m; i++)
            {
                steag = 0;
                for (j = 0; j < n; j++)
                {
                    if (v1[j] == v2[i])
                    {
                        steag = 1;
                        break;
                    }
                }
                if (steag == 0)
                {
                    aux[x] = v2[i];
                    x++;
                }
            }

            for (i = 0; i < x; i++)
                for (j = i + 1; j < x; j++)
                    if (aux[i] == aux[j])
                    {
                        int k;
                        k = aux[j];
                        aux[j] = aux[x - 1];
                        aux[x - 1] = k;
                        x--;
                        j--;
                    }
            Console.Write("v2 - v1 = { ");
            for (i = 0; i < x; i++)
                Console.Write(aux[i] + " ");
            Console.WriteLine("}");

            Main();
        }
        static void ex23()
        {
            Console.WriteLine("23.Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat.(vectorii sunt in ordine crescatoare) ");
            Console.WriteLine("Screieti 2 vectorii cu un spatiu intre numere, ex: 1 2 3 5 6 7 8 9");
            Console.Write("v1 = ");
            string[] V1 = Console.ReadLine().Split(' ');
            Console.Write("v2 = ");
            string[] V2 = Console.ReadLine().Split(' ');

            int[] v1 = new int[V1.Length];
            int[] v2 = new int[V2.Length];

            int i, j, n, m, a;
            for (i = 0; i < V1.Length; i++)
                v1[i] = int.Parse(V1[i]);
            for (i = 0; i < V2.Length; i++)
                v2[i] = int.Parse(V2[i]);
            n = v1.Length;
            m = v2.Length;

            int[] aux = new int[n + m];

            // v1 reunit cu v2 //

            for (i = 0; i < n; i++)
                aux[i] = v1[i];
            for (i = 0; i < m; i++)
                aux[i + n] = v2[i];
            a = m + n;

            for (i = 0; i < a; i++)
                for (j = i + 1; j < a; j++)
                    if (aux[i] == aux[j])
                    {
                        int k;
                        k = aux[j];
                        aux[j] = aux[a - 1];
                        aux[a - 1] = k;
                        a--;
                        j--;
                    }

            Console.Write("v1 reunit cu v2 = { ");
            for (i = 0; i < a; i++)
                Console.Write(aux[i] + " ");
            Console.WriteLine("}");

            // v1 intersectat cu v2 //

            aux = new int[n + m];
            int x = 0;
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        aux[x] = v1[i];
                        x++;
                        break;
                    }
                    if (v1[i] < v2[j])
                        break;
                }

            for (i = 0; i < x; i++)
                for (j = i + 1; j < x; j++)
                    if (aux[i] == aux[j])
                    {
                        int k;
                        k = aux[j];
                        aux[j] = aux[x - 1];
                        aux[x - 1] = k;
                        x--;
                        j--;
                    }

            Console.Write("v1 intersectat cu v2 = { ");
            for (i = 0; i < x; i++)
                Console.Write(aux[i] + " ");
            Console.WriteLine("}");

            // v1 - v2 //

            aux = new int[n + m];
            x = 0;
            int steag;
            for (i = 0; i < n; i++)
            {
                steag = 0;
                for (j = 0; j < m; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        steag = 1;
                        break;
                    }
                    if (v1[i] < v2[j])
                        break;
                }
                if (steag == 0)
                {
                    aux[x] = v1[i];
                    x++;
                }
            }

            for (i = 0; i < x; i++)
                for (j = i + 1; j < x; j++)
                    if (aux[i] == aux[j])
                    {
                        int k;
                        k = aux[j];
                        aux[j] = aux[x - 1];
                        aux[x - 1] = k;
                        x--;
                        j--;
                    }
            Console.Write("v1 - v2 = { ");
            for (i = 0; i < x; i++)
                Console.Write(aux[i] + " ");
            Console.WriteLine("}");

            // v2 - v1 //

            aux = new int[n + m];
            x = 0;
            for (i = 0; i < m; i++)
            {
                steag = 0;
                for (j = 0; j < n; j++)
                {
                    if (v1[j] == v2[i])
                    {
                        steag = 1;
                        break;
                    }
                    if (v2[i] < v1[j])
                        break;
                }
                if (steag == 0)
                {
                    aux[x] = v2[i];
                    x++;
                }
            }

            for (i = 0; i < x; i++)
                for (j = i + 1; j < x; j++)
                    if (aux[i] == aux[j])
                    {
                        int k;
                        k = aux[j];
                        aux[j] = aux[x - 1];
                        aux[x - 1] = k;
                        x--;
                        j--;
                    }
            Console.Write("v2 - v1 = { ");
            for (i = 0; i < x; i++)
                Console.Write(aux[i] + " ");
            Console.WriteLine("}");

            Main();
        }
        static void ex24()
        {

        }
        static void ex25()
        {

        }
        static void ex26()
        {

        }
        static void ex27()
        {

        }
        static void ex28()
        {

        }
        static void ex29()
        {

        }
        static void ex30()
        {

        }
        static void ex31()
        {

        }
    }
}
