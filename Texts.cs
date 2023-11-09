namespace HanoiTowers
{
    public class Texts // Komponenty tekstowe
    {
        public static void Instruction()
        {
            Console.WriteLine();
            Console.WriteLine("Zasady gry:");
            Console.WriteLine("===========");
            Console.WriteLine();
            Console.WriteLine("Mamy trzy słupki: początkowy, pomocniczy i końcowy. Na słupku początkowym znajduje się");
            Console.WriteLine("wieża składającą się z krążkow. Naszym zadaniem jest przenieść wszystkie krążki ze");
            Console.WriteLine("słupka początkowego na słupek końcowy, z zachowaniem tego samego kształtu wieży.");
            Console.WriteLine("Podczas przenoszenia możemy wspomagać się słupkiem pomocniczym stosując trzy nastąpujące zasady:");
            Console.WriteLine();
            Console.WriteLine("1. Można przekładać na raz tylko jeden krążek.");
            Console.WriteLine("2. Można brać tylko krążek z samej góry słupka");
            Console.WriteLine("3. Można układać tylko mniejszy krążek na większy.");
            Console.WriteLine();
            Console.WriteLine("Pamietaj:");
            Console.WriteLine("=========");
            Console.WriteLine();
            Console.WriteLine("W kazdej chwili mozesz przerwac gre wybierajac 'Q'");
            Console.WriteLine("A jezeli bedziesz potrzebowac pomocy, wybierz 'H'");
            Console.WriteLine();
            Console.WriteLine("Jesli jestes juz gotowy na gre, to nacisnij dowolny klawisz...");
        }
        public static void History()
        {
            Console.WriteLine();
            Console.WriteLine("Historia:");
            Console.WriteLine("=========");
            Console.WriteLine();
            Console.WriteLine("Zagadka Wieże Hanoi powstała prawdopodobnie w Azji w XIX wieku. Gra została sprowadzona");
            Console.WriteLine("na Zachód po raz pierwszy przez francuskiego matematyka Édouarda Lucasa w 1883 roku.");
            Console.WriteLine("Do każdego sprzedawanego zestawu dołączona była tybetańska legenda, według której");
            Console.WriteLine("mnisi w świątyni Brahmy rozwiązują tę łamigłówkę z 64 złotymi krążkami. Legenda głosi,");
            Console.WriteLine("że gdy mnisi zakończą swoje zadanie, nastąpi koniec świata.");
            Console.WriteLine();
            Console.WriteLine("Jednak bez obaw... zakładając, że mnisi wykonują jeden ruch na sekundę, ułożenie wieży");
            Console.WriteLine("zajmie im przeszło 500 miliardów lat. Dla porównania: od Wielkiego Wybuchu minęło");
            Console.WriteLine("dopiero 14 miliardów lat :-)");
        }
        public static void HelpA()
        {
            Console.WriteLine();
            Console.WriteLine("Jesteś pewny, że chcesz poznać rozwiązanie? To zepsuje Ci całą zabawę.");
            Console.WriteLine("Pamietaj, że rozwiązanie problemu samemu daje największą frajdę.");
            Console.WriteLine();
            Console.WriteLine("Jesli jednak nadal potrzebujesz pomocy, ponownie nacisnij 'H'.");
            Console.WriteLine("Jesli chcesz powrocic do gry, nacisnij inny, dowolny klawisz.");
            Console.WriteLine();
        }
        public static void HelpB()
        {
            Console.WriteLine();
            Console.WriteLine("Rozwiazanie problemu Wieze Hanoi:");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("1. Przenieś najmniejszy krążek na kolejny słupek (*).");
            Console.WriteLine("2. Wykonaj jedyny możliwy do wykonania ruch, nie zmieniając położenia najmniejszego krążka.");
            Console.WriteLine("3. Powtarzaj powyższe punkty, aż do odpowiedniego ułożenia wszystkich krążków.");
            Console.WriteLine();
            Console.WriteLine("(*) Kolejny słupek zależy od początkowej liczby krążków. Jeśli liczba krążków");
            Console.WriteLine("jest parzysta, to kolejnym słupkiem jest ten po prawej stronie.Natomiast, jeśli");
            Console.WriteLine("liczba krążków jest nieparzysta, to kolejnym słupkiem jest ten po lewej stronie.");
            Console.WriteLine("Kiedy w ten sposób dojdziesz do najdalszego słupka po lewej, to kolejnym będzie");
            Console.WriteLine("już ten skrajny z prawej strony.");
            Console.WriteLine();
            Console.WriteLine("Jesli chcesz powrocic do gry, nacisnij dowolny klawisz...");
        }
        public static void RingsRulesPoem()
        {
            Console.WriteLine();
            Console.WriteLine("Pamiętaj chemiku młody, wlewaj zawsze kwas do wody, nigdy odwrotnie!");
            Console.WriteLine("Eeee, to jest znaczy się chciałem powiedzieć:");
            Console.WriteLine();
            Console.WriteLine("Na słupku krążek kładź z szacunkiem,");
            Console.WriteLine("bo zawsze mniejszy leży na większym.");
            Console.WriteLine("Możesz grać tylko pod tym warunkiem!");
            Console.WriteLine();
        }
        public static void Salomon()
        {
            Console.WriteLine();
            Console.WriteLine("Hola, hola! Z pustego nawet Salomon nie naleje... ");
            Console.WriteLine("Wybierz patyk na ktorym jest jakis krazek.");
            Console.WriteLine();

        }
    }
}