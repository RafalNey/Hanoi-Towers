namespace HanoiTowers
{
    // Jak wszystko bedzie dzialac, to zamienie ten Level na klase bazowa LevelBase 
    // i wszystkie inne beda z niej korzystac. 
    public class LevelEasy
    {
        // wartosci iniclalne patykow
        public static int[] stick1 = Statistics.stickFullEasy;
        public static int[] stick2 = Statistics.stickEmptyEasy;
        public static int[] stick3 = Statistics.stickEmptyEasy;

        static string GetRingName(int stickValue, string stickName)
        {
            return $"ring{stickName}{stickValue}";
        }
        static string GetFloorName(int floorValue, string floorName)
        {
            return $"floor{floorName}{floorValue}";
        }
        public static void GameScreen()
        {
            // // stan poczatkowy gry
            stick1 = new int[] { 2, 0, 2, 3, 4, 5 };
            stick2 = new int[] { 1, 0, 0, 0, 0, 1 };
            stick3 = new int[] { 3, 0, 0, 0, 0, 3 };

            Console.Clear();
            Console.WriteLine();

            // Czubki patykow
            Console.WriteLine($"{Graphics.top}{Graphics.top}{Graphics.top}");

            Graphics graphics = new Graphics();

            for (int row = 1; row <= 5; row++)
            {
                string fieldNameStick1A = GetRingName(stick1[row], "A");
                string fieldNameStick1B = GetRingName(stick1[row], "B");
                string fieldNameStick2A = GetRingName(stick2[row], "A");
                string fieldNameStick2B = GetRingName(stick2[row], "B");
                string fieldNameStick3A = GetRingName(stick3[row], "A");
                string fieldNameStick3B = GetRingName(stick3[row], "B");

                var fieldStick1A = typeof(Graphics).GetField(fieldNameStick1A);
                var fieldStick1B = typeof(Graphics).GetField(fieldNameStick1B);
                var fieldStick2A = typeof(Graphics).GetField(fieldNameStick2A);
                var fieldStick2B = typeof(Graphics).GetField(fieldNameStick2B);
                var fieldStick3A = typeof(Graphics).GetField(fieldNameStick3A);
                var fieldStick3B = typeof(Graphics).GetField(fieldNameStick3B);

                var valueStick1A = fieldStick1A.GetValue(graphics);
                var valueStick1B = fieldStick1B.GetValue(graphics);
                var valueStick2A = fieldStick2A.GetValue(graphics);
                var valueStick2B = fieldStick2B.GetValue(graphics);
                var valueStick3A = fieldStick3A.GetValue(graphics);
                var valueStick3B = fieldStick3B.GetValue(graphics);

                // Budowanie ekranu gry, linia po linii.
                Console.WriteLine($"{valueStick1A}{valueStick2A}{valueStick3A}");
                Console.WriteLine($"{valueStick1B}{valueStick2B}{valueStick3B}");
            }

            // Podstawki patykow.
            Console.WriteLine($"{Graphics.floor}{Graphics.floor}{Graphics.floor}");
            Console.WriteLine();

            for (int row = 1; row <= 6; row++)
            {
                string fieldNameFloorA = GetFloorName(row, "A");
                string fieldNameFloorB = GetFloorName(row, "B");
                string fieldNameFloorC = GetFloorName(row, "C");

                var fieldFloorA = typeof(Graphics).GetField(fieldNameFloorA);
                var fieldFloorB = typeof(Graphics).GetField(fieldNameFloorB);
                var fieldFloorC = typeof(Graphics).GetField(fieldNameFloorC);

                var valueFloorA = fieldFloorA.GetValue(graphics);
                var valueFloorB = fieldFloorB.GetValue(graphics);
                var valueFloorC = fieldFloorC.GetValue(graphics);

                // Budowanie linia po linii cyfr: 1, 2, 3 pod patykami.
                Console.WriteLine($"{valueFloorA}{valueFloorB}{valueFloorC}");
            }
            Console.WriteLine();
        }
    }
}