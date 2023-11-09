namespace HanoiTowers
{
    public class Graphics // Komponenty graficzne
    {
        public static string top = "                __                ";
        public static string ringA0 = "               |  |               ";
        public static string ringB0 = "               |  |               ";
        public static string ringA1 = "             __|__|__             ";
        public static string ringB1 = "            |████████|            ";
        public static string ringA2 = "           ____|__|____           ";
        public static string ringB2 = "          |████████████|          ";
        public static string ringA3 = "         ______|__|______         ";
        public static string ringB3 = "        |████████████████|        ";
        public static string ringA4 = "       ________|__|________       ";
        public static string ringB4 = "      |████████████████████|      ";
        public static string ringA5 = "     __________|__|__________     ";
        public static string ringB5 = "    |████████████████████████|    ";
        public static string ringA6 = "   ____________|__|____________   ";
        public static string ringB6 = "  |████████████████████████████|  ";
        public static string ringA7 = " ______________|__|______________ ";
        public static string ringB7 = "|████████████████████████████████|";
        public static string floor = "_______________|__|_______________";
        public static string floorA1 = "                ██╗               ";
        public static string floorA2 = "              ████║               ";
        public static string floorA3 = "              ╚═██║               ";
        public static string floorA4 = "                ██║               ";
        public static string floorA5 = "                ██║               ";
        public static string floorA6 = "                ╚═╝               ";
        public static string floorB1 = "              █████╗              ";
        public static string floorB2 = "              ╚═══██╗             ";
        public static string floorB3 = "               ████╔╝             ";
        public static string floorB4 = "              ██╔══╝              ";
        public static string floorB5 = "              ██████╗             ";
        public static string floorB6 = "              ╚═════╝             ";
        public static string floorC1 = "              █████╗              ";
        public static string floorC2 = "              ╚═══██╗             ";
        public static string floorC3 = "               ████╔╝             ";
        public static string floorC4 = "               ╚══██╗             ";
        public static string floorC5 = "              █████╔╝             ";
        public static string floorC6 = "              ╚════╝              ";

        public static void GreetingsScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Witaj w grze:");
            Console.WriteLine();
            Console.WriteLine("       ██╗  ██╗ █████╗ ███╗   ██╗ ██████╗ ██╗        ");
            Console.WriteLine("       ██║  ██║██╔══██╗████╗  ██║██╔═══██╗██║        ");
            Console.WriteLine("       ███████║███████║██╔██╗ ██║██║   ██║██║        ");
            Console.WriteLine("       ██╔══██║██╔══██║██║╚██╗██║██║   ██║██║        ");
            Console.WriteLine("       ██║  ██║██║  ██║██║ ╚████║╚██████╔╝██║        ");
            Console.WriteLine("       ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝        ");
            Console.WriteLine("████████╗ ██████╗ ██╗    ██╗███████╗██████╗ ███████╗ ");
            Console.WriteLine("╚══██╔══╝██╔═══██╗██║    ██║██╔════╝██╔══██╗██╔════╝ ");
            Console.WriteLine("   ██║   ██║   ██║██║ █╗ ██║█████╗  ██████╔╝███████╗ ");
            Console.WriteLine("   ██║   ██║   ██║██║███╗██║██╔══╝  ██╔══██╗╚════██║ ");
            Console.WriteLine("   ██║   ╚██████╔╝╚███╔███╔╝███████╗██║  ██║███████║ ");
            Console.WriteLine("   ╚═╝    ╚═════╝  ╚══╝╚══╝ ╚══════╝╚═╝  ╚═╝╚══════╝ ");
            Console.WriteLine();
            Console.WriteLine("    Wybierz proszę:");
            Console.WriteLine("    ===============");
            Console.WriteLine();
            Console.WriteLine("1 - Wiem już wszystko, chcę od razu zagrać.");
            Console.WriteLine("2 - Chcę poznać historię i zasady gry.");
            Console.WriteLine("3 - Chcę skasowac wszystkie dotychczasowe rekordy i zaczac od nowa.");
            Console.WriteLine();
        }
        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ ");
            Console.WriteLine("██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗");
            Console.WriteLine("██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝");
            Console.WriteLine("██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗");
            Console.WriteLine("╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║");
            Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝");
            Console.WriteLine();
        }
        public static void CongratulationNewRecord()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ██████╗ ██████╗  █████╗ ████████╗██╗   ██╗██╗      █████╗  ██████╗     ██╗███████╗ ");
            Console.WriteLine("██╔════╝ ██╔══██╗██╔══██╗╚══██╔══╝██║   ██║██║     ██╔══██╗██╔════╝     ██║██╔════╝ ");
            Console.WriteLine("██║  ███╗██████╔╝███████║   ██║   ██║   ██║██║     ███████║██║          ██║█████╗   ");
            Console.WriteLine("██║   ██║██╔══██╗██╔══██║   ██║   ██║   ██║██║     ██╔══██║██║     ██   ██║██╔══╝   ");
            Console.WriteLine("╚██████╔╝██║  ██║██║  ██║   ██║   ╚██████╔╝███████╗██║  ██║╚██████╗╚█████╔╝███████╗ ");
            Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚════╝ ╚══════╝ ");
            Console.WriteLine();
            Console.WriteLine("███╗   ██╗███████╗██╗    ██╗   ██████╗ ███████╗ ██████╗ ██████╗ ██████╗ ██████╗ ██╗");
            Console.WriteLine("████╗  ██║██╔════╝██║    ██║   ██╔══██╗██╔════╝██╔════╝██╔═══██╗██╔══██╗██╔══██╗██║");
            Console.WriteLine("██╔██╗ ██║█████╗  ██║ █╗ ██║   ██████╔╝█████╗  ██║     ██║   ██║██████╔╝██║  ██║██║");
            Console.WriteLine("██║╚██╗██║██╔══╝  ██║███╗██║   ██╔══██╗██╔══╝  ██║     ██║   ██║██╔══██╗██║  ██║╚═╝");
            Console.WriteLine("██║ ╚████║███████╗╚███╔███╔╝   ██║  ██║███████╗╚██████╗╚██████╔╝██║  ██║██████╔╝██╗");
            Console.WriteLine("╚═╝  ╚═══╝╚══════╝ ╚══╝╚══╝    ╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚═════╝ ╚═╝");
            Console.WriteLine();
        }
        public static void CongratulationOnly()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ██████╗ ██████╗  █████╗ ████████╗██╗   ██╗██╗      █████╗  ██████╗     ██╗███████╗ ");
            Console.WriteLine("██╔════╝ ██╔══██╗██╔══██╗╚══██╔══╝██║   ██║██║     ██╔══██╗██╔════╝     ██║██╔════╝ ");
            Console.WriteLine("██║  ███╗██████╔╝███████║   ██║   ██║   ██║██║     ███████║██║          ██║█████╗   ");
            Console.WriteLine("██║   ██║██╔══██╗██╔══██║   ██║   ██║   ██║██║     ██╔══██║██║     ██   ██║██╔══╝   ");
            Console.WriteLine("╚██████╔╝██║  ██║██║  ██║   ██║   ╚██████╔╝███████╗██║  ██║╚██████╗╚█████╔╝███████╗ ");
            Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚════╝ ╚══════╝ ");
            Console.WriteLine();
        }
        public static void ChooseLevelScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("    Wybierz poziom trudności:");
            Console.WriteLine("    ==========================");
            Console.WriteLine();
            Console.WriteLine("1 - EASY, jak dla dzidziusiow");
            Console.WriteLine("2 - NORMAL, dla normalnych ludzi");
            Console.WriteLine("3 - HARD, dla tych, ktorzy lubią film 'Die Hard'");
            Console.WriteLine();
        }
    }
}