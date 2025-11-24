namespace Nevek_szűrése
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Molnar Tamas");
            list.Add("Kiss Istvan Jozsef");
            list.Add("nagy Istvan Elemer");
            list.Add("Farkas1 Aladar");
            list.Add("peto@Ilona.hu");
            list.Add("Pisti");
            list.Add("12Elemer");
            list.Add("SzekeresKata");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("0 - Kilépés");
                Console.WriteLine("1 - Összes név listázása");
                Console.WriteLine("2 - Csak betűt tartalmazó nevek listázása");
                Console.WriteLine("3 - Nagybetűvel kezdődő nevek listázása");
                Console.WriteLine("4 - Rövid nevek listázása");
                Console.WriteLine("5 - Nagybetűvel kezdődő nevek ahol a többi kicsi" + "és nem tartalmaz számot és speciális jelet");
                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "0":return; //Kilépés
                    case "1":
                        //Minden név listázása
                        Console.Clear();
                        int sorszam = 0;
                        foreach (string nev in list)
                            Console.WriteLine($"{sorszam++}. { nev}")
                        ;break;
                    case "2": 
                        //Csak betűk
                        Console.Clear();
                        sorszam = 0;
                        foreach (string nev in list)
                        {
                            bool jo = true;
                            foreach (char betu in nev)
                            {
                                if(!Char.IsLetter(betu) && betu !=' ')
                                    jo = false;
                            }
                            if(jo)
                                Console.WriteLine($"{sorszam++}. {nev}");
                        }
                        break;
                    case "3":
                        // Nagybetűvel kezdődő nevek
                        Console.Clear();
                        sorszam = 0;
                        foreach (string nev in list)
                        {
                            bool jo = true;
                            String[] kezdodo = nev.Split(" ");
                            foreach (var kezdodik in kezdodo)
                            {
                                
                                if (!Char.IsUpper(nev[0])) jo = false;
                            }

                            if (jo)
                                Console.WriteLine($"{sorszam++}. {nev}");
                        }
                        break;
                    case "4": Console.WriteLine("4"); break;
                    case "5":
                        // Szűrés - Nagybetűvel kezdődik, a többi kicsi, és nincs benne se szám sem speciális jel
                        Console.Clear();
                        sorszam = 0;
                        foreach (string nev in list)
                        {
                            bool jo = true;
                            foreach (char betu in nev)
                            {
                                if (!Char.IsLetter(betu) && betu != ' ')
                                    jo = false;
                            }
                            String[] nevdarabok = nev.Split(" ");
                            foreach (var nevdarab in nevdarabok)
                            {
                                //első nagybetű
                                if (!Char.IsUpper(nev[0])) jo = false;
                                //többi kicsi
                                if (nevdarab.Substring(1)!= nevdarab.Substring(1).ToLower())
                                    jo = false;
                            }

                            if (jo)
                                Console.WriteLine($"{sorszam++}. {nev}");
                        }
                        break;
                    default: Console.WriteLine("Rossz Parancs!");break;
                }
                Console.ReadKey();
            }
        }
    }
}
