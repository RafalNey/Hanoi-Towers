using HanoiTowers;

Console.Clear();
Graphics.GreetingsScreen();
string choice;

// Instrukcja obslugi i rozpoczecie gry
do
{
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.Clear();
            break;
        case "2":
            Console.Clear();
            Texts.History();
            Texts.Instruction();
            Console.ReadKey();
            Console.Clear();
            break;
        default:
            Console.WriteLine("Tylko 1 lub 2...");
            Thread.Sleep(1000);
            break;
    }
} while (choice != "1" && choice != "2");

// Wybor poziomu gry
int[] stick0 = { 1, 1, 2, 3, 4, 5 };
int[] stick1 = { 1, 1, 2, 3, 4, 5 };
int[] stick2 = { 0, 0, 0, 0, 0, 0 };
int[] stick3 = { 0, 0, 0, 0, 0, 0 };

do
{
    Graphics.ChooseLevelScreen();
    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            ChooseLevel(1);
            break;
        case "2":
            ChooseLevel(2);
            break;
        case "3":
            ChooseLevel(3);
            break;
        default:
            Console.WriteLine("Tylko 1, 2 lub 3...");
            Thread.Sleep(2000);
            break;
    }
} while (choice != "1" && choice != "2" && choice != "3");

string input;
int ring = 0;
int movesPlayerCount = 0;

do // GRA WLASCIWA
{
    do // Zdejmowanie krazka z patyka
    {
        GameScreen();
        Console.WriteLine("Z ktorego patyka ( 1, 2, 3 ) chcesz wziac krazek?");
        input = Console.ReadLine();
        switch (input)
        {
            case "1":
                RemoveRingFromStick(1);
                break;
            case "2":
                RemoveRingFromStick(2);
                break;
            case "3":
                RemoveRingFromStick(3);
                break;
        }
    } while (ring == 0);

    do
    {
        GameScreen();
        Console.WriteLine("Wybierz patyk ( 1, 2, 3 ) na ktorym chcesz polozyc krazek");
        input = Console.ReadLine();
        switch (input)
        {
            case "1":
                PutRingOnStick(1);
                break;
            case "2":
                PutRingOnStick(2);
                break;
            case "3":
                PutRingOnStick(3);
                break;
        }
    } while (ring != 0);
    GameScreen();
} while (!stick3.SequenceEqual(stick0));

Records.CompareAndSave(choice, movesPlayerCount);

Graphics.GameOver();
Console.WriteLine($"Potrzebowales az {movesPlayerCount} ruchow aby ulozyc te lamiglowke :-(");
Console.WriteLine($"Moze sprobujesz jeszcze raz?");
Console.WriteLine();

// EKRAN GRY
void GameScreen()
{
    Graphics graphics = new Graphics();

    Console.Clear();
    Console.WriteLine();

    // Czubki patykow
    Console.WriteLine($"{Graphics.top}{Graphics.top}{Graphics.top}");

    // Budowanie wlasciwego ekranu gry (krazkow i patykow), linia po linii.
    for (int row = 1; row < stick0.Length; row++)
    {
        string fieldNameStick1A = GetRingName("A", stick1[row]);
        string fieldNameStick1B = GetRingName("B", stick1[row]);
        string fieldNameStick2A = GetRingName("A", stick2[row]);
        string fieldNameStick2B = GetRingName("B", stick2[row]);
        string fieldNameStick3A = GetRingName("A", stick3[row]);
        string fieldNameStick3B = GetRingName("B", stick3[row]);

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

        Console.WriteLine($"{valueStick1A}{valueStick2A}{valueStick3A}");
        Console.WriteLine($"{valueStick1B}{valueStick2B}{valueStick3B}");
    }

    // Podstawki patykow.
    Console.WriteLine($"{Graphics.floor}{Graphics.floor}{Graphics.floor}");
    Console.WriteLine();

    // Budowanie linia po linii cyferek: 1, 2, 3 pod patykami.
    for (int row = 1; row <= 6; row++)
    {
        string fieldNameFloorA = GetFloorName("A", row);
        string fieldNameFloorB = GetFloorName("B", row);
        string fieldNameFloorC = GetFloorName("C", row);

        var fieldFloorA = typeof(Graphics).GetField(fieldNameFloorA);
        var fieldFloorB = typeof(Graphics).GetField(fieldNameFloorB);
        var fieldFloorC = typeof(Graphics).GetField(fieldNameFloorC);

        var valueFloorA = fieldFloorA.GetValue(graphics);
        var valueFloorB = fieldFloorB.GetValue(graphics);
        var valueFloorC = fieldFloorC.GetValue(graphics);

        Console.WriteLine($"{valueFloorA}{valueFloorB}{valueFloorC}");
    }
    Console.WriteLine();
}

// =======================================================
//             WSZYSTKIE INNE FUNKCJE
// =======================================================

// Budowanie nazwy krazka
static string GetRingName(string stickName, int stickValue)
{
    return $"ring{stickName}{stickValue}";
}
// Budowanie nazwy podstawki
static string GetFloorName(string floorName, int floorValue)
{
    return $"floor{floorName}{floorValue}";
}

// Wartosci inicjalne leveli
void ChooseLevel(int levelNumber)
{
    if (levelNumber == 1)
    {
        stick0 = new int[] { 1, 1, 2, 3 };
        stick1 = new int[] { 1, 1, 2, 3 };
        stick2 = new int[] { 0, 0, 0, 0 };
        stick3 = new int[] { 0, 0, 0, 0 };
    }
    else if (levelNumber == 2)
    {
        stick0 = new int[] { 1, 1, 2, 3, 4, 5 };
        stick1 = new int[] { 1, 1, 2, 3, 4, 5 };
        stick2 = new int[] { 0, 0, 0, 0, 0, 0 };
        stick3 = new int[] { 0, 0, 0, 0, 0, 0 };
    }
    else if (levelNumber == 3)
    {
        stick0 = new int[] { 1, 1, 2, 3, 4, 5, 6, 7 };
        stick1 = new int[] { 1, 1, 2, 3, 4, 5, 6, 7 };
        stick2 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        stick3 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
    }
}

// Zabieranie krazka z patyka
int RemoveRingFromStick(int stickNumber)
{
    var stick = stickNumber == 1 ? stick1 : stickNumber == 2 ? stick2 : stick3;

    // Jesli patyk jest pusty
    if (stick[0] == 0)
    {
        Texts.Salomon();
        Thread.Sleep(2000);
        return ring = 0;
    }
    else
    {
        ring = stick[0];

        // Zdejmowanie krazka z patyka
        for (var index = 1; index < stick.Length; index++)
        {
            if (stick[index] == ring)
            {
                stick[index] = 0;
            }
        }
        // Zmiana indexu patyka
        var minimumNoZero = int.MaxValue;
        var foundNoZero = false;

        for (var index = 1; index < stick.Length; index++)
        {
            if (stick[index] != 0 && stick[index] < minimumNoZero)
            {
                minimumNoZero = stick[index];
                foundNoZero = true;
            }
        }
        if (foundNoZero)
        {
            stick[0] = minimumNoZero;
        }
        else
        {
            stick[0] = 0;
        }
        movesPlayerCount++;
        return ring;
    }
}

// Kladzenie krazka na patyku
int PutRingOnStick(int stickNumber)
{
    var stick = stickNumber == 1 ? stick1 : stickNumber == 2 ? stick2 : stick3;

    // jesli probujemy polozyc wiekszy krazek na mniejszym
    if (ring > stick[0] && stick[0] != 0)
    {
        Texts.RingsRulesPoem();
        Thread.Sleep(4000);
        return ring;
    }
    else
    {
        // Zmiana indexu patyka
        stick[0] = ring;

        // Kladzenie krazka na patylu
        for (var index = stick.Length - 1; index >= 0; index--)
        {
            if (stick[index] == 0)
            {
                stick[index] = ring;
                break;
            }
        }
        return ring = 0;
    }
}


/*
            input = Console.ReadLine();
            if (input.ToUpper() == "Q")
            {
                Console.Clear();
                Graphics.GameOver();
                break;
            }
            if (input.ToUpper() == "H")
            {
                Console.Clear();
                Texts.HelpA();
                break;
            }
        } while (input != "1" && input != "2" && input != "3" && input.ToUpper() != "Q" && input.ToUpper() != "H" || ring == 0);

            input = Console.ReadLine();
            if (input.ToUpper() == "Q")
            {
                Graphics.GameOver();
                break;
            }
            else if (input.ToUpper() == "H")
            {
                Texts.HelpA();
                break;
            }
        } while (input != "1" && input != "2" && input != "3" && input.ToUpper() != "Q" && input.ToUpper() != "H");
*/