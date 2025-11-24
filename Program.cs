namespace Nevek_szűrése
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                    case "1": Console.WriteLine("1");break;
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
