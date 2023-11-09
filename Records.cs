using System.Globalization;
namespace HanoiTowers
{
    public abstract class Records
    {
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
            int bestOfTheBestRecord;
            int recordOld = 1000;
            int recordNew;

            switch (level)
            {
                case "1":
                    fileName = fileNameEasy;
                    bestOfTheBestRecord = minimalRecordEasy;
                    break;
                case "2":
                    fileName = fileNameNormal;
                    bestOfTheBestRecord = minimalRecordNormal;
                    break;
                case "3":
                    fileName = fileNameHard;
                    bestOfTheBestRecord = minimalRecordHard;
                    break;
                default:
                    fileName = "";
                    bestOfTheBestRecord = 0;
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

            if (movesPlayerCount > recordOld)
            {
                Graphics.GameOver();
                Console.WriteLine($"Potrzebowales az {movesPlayerCount} ruchow aby ulozyc te lamiglowke :-(");
                Console.WriteLine($"Dotychczasowy rekord wynosi {recordOld} ruchow");
                Console.WriteLine($"Moze sprobujesz jeszcze raz?");
                Console.WriteLine();
            }
            else
            {
                if (movesPlayerCount == bestOfTheBestRecord)
                {
                    Graphics.CongratulationOnly();
                    Console.WriteLine($"Osiagnales mistrzostwo tego poziomu! Potrzebowales jedynie {movesPlayerCount} ruchow aby wygrac.");
                    Console.WriteLine($"Jest to niezbedna, minimalna liczba ruchow potrzeba do ulozenia tej lamigowki.");
                    Console.WriteLine("Moze sprobujesz teraz na wyzszym poziomie?");
                    Console.WriteLine();
                }
                else
                {
                    Graphics.CongratulationNewRecord();
                    Console.WriteLine($"Potrzebowales jedynie {movesPlayerCount} ruchow aby ulozyc te lamiglowke.");
                    Console.WriteLine($"Dotychczasowy rekord wynosil {recordOld} ruchow");
                    Console.WriteLine($"Twoj nowy rekord zostal zapisany. Gratulacje!");
                    Console.WriteLine($"A moze chcesz go sprobowac pobic i zagrac jeszcze raz?");
                    Console.WriteLine();
                }
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
