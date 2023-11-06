namespace HanoiTowers
{
    public abstract class Statistics
    {
        // Wartosci inicjalne dla wszystkich leveli
        public static int[] stickFullEasy = new int[] { 1, 1, 2, 3 };
        public static int[] stickFullNormal = new int[] { 1, 1, 2, 3, 4, 5 };
        public static int[] stickFullHard = new int[] { 1, 1, 2, 3, 4, 5, 6, 7 };
        public static int[] stickEmptyEasy = new int[] { 0, 0, 0, 0 };
        public static int[] stickEmptyNormal = new int[] { 0, 0, 0, 0, 0, 0 };
        public static int[] stickEmptyHard = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
    }
}