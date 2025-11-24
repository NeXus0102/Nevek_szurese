namespace Nevek_szűrése
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Molnár Tamás");
            list.Add("Kiss István József");
            list.Add("nagy István Elemér");
            list.Add("Farkas1 Aladár");
            list.Add("pető@Ilona.hu");
            list.Add("Pisti");
            list.Add("12Elemér");
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
                    case "0":return; //kilépés
                    case "1":
                        //minden név listázása
                        Console.Clear();
                        int sorszam = 0;
                        foreach (string nev in list)
                            Console.WriteLine($"{sorszam++}. { nev}")
                        ;break;
                    case "2": Console.WriteLine("2"); break;
                    case "3": Console.WriteLine("3"); break;
                    case "4": Console.WriteLine("4"); break;
                    case "5": Console.WriteLine("5"); break;
                    default: Console.WriteLine("Rossz Parancs!");break;
                }
                Console.ReadKey();
            }
        }
    }
}
