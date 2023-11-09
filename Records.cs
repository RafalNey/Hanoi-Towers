namespace HanoiTowers
{
    public abstract class Records
    {
        // Wartosci inicjalne patykow dla wszystkich leveli
        public static int[] stickFullEasy = new int[] { 1, 1, 2, 3 };
        public static int[] stickFullNormal = new int[] { 1, 1, 2, 3, 4, 5 };
        public static int[] stickFullHard = new int[] { 1, 1, 2, 3, 4, 5, 6, 7 };
        public static int[] stickEmptyEasy = new int[] { 0, 0, 0, 0 };
        public static int[] stickEmptyNormal = new int[] { 0, 0, 0, 0, 0, 0 };
        public static int[] stickEmptyHard = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };

        // nazwy plikow 
        public static string fileNameEasy = "easy.txt";
        public static string fileNameNormal = "normal.txt";
        public static string fileNameHard = "hard.txt";

        // wartosci inicjalne rekordow
        public static int inicialRecordEasy = 20;
        public static int inicialRecordNormal = 65;
        public static int inicialRecordHard = 250;

        // Minimalne ilosci ruchow (ze wzoru L(n) = 2^n - 1)
        public static int minimalRecordEasy = 7;
        public static int minimalRecordNormal = 31;
        public static int minimalRecordHard = 127;

        public static void CompareAndSave(string level, int movesPlayerCount)
        {
            string fileName;
            int recordOld = 1000;
            int recordNew = 0;

            switch (level)
            {
                case "1":
                    fileName = fileNameEasy;
                    break;
                case "2":
                    fileName = fileNameNormal;
                    break;
                case "3":
                    fileName = fileNameHard;
                    break;
                default:
                    fileName = "";
                    break;
            }

            if (File.Exists(fileName))
            {
                string contents = File.ReadAllText(fileName);
                recordOld = int.Parse(contents);
            }
            else
            {
                Console.WriteLine($"Jakas lipa... plik o nazwie {fileName} nie istnieje.");
            }

            recordNew = Math.Min(recordOld, movesPlayerCount);

            if (recordNew < recordOld)
            {
                try
                {
                    File.Delete(fileName);
                    File.Create(fileName).Close();
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.Write(recordNew);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd podczas zapisu do pliku: " + ex.Message);
                }
            }
        }

        public static void CreateInicialRecordFiles()
        {
            DeleteFile(fileNameEasy);
            DeleteFile(fileNameNormal);
            DeleteFile(fileNameHard);

            CreateFile(fileNameEasy, inicialRecordEasy.ToString());
            CreateFile(fileNameNormal, inicialRecordNormal.ToString());
            CreateFile(fileNameHard, inicialRecordHard.ToString());
        }
        // Funkcja kasowania pliku
        public static void DeleteFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            else
            {
                Console.WriteLine($"Lipa, panie lipa... plik o nazwie {fileName} nie istnieje.");
            }
        }

        // Funkcja tworzenia pliku
        public static void CreateFile(string fileName, string fileContent)
        {
            File.WriteAllText(fileName, fileContent);
            Console.WriteLine($"Mowisz i masz. Utworzono plik: {fileName}");
        }
    }
}
