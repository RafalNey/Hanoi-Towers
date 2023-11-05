using System.Globalization;
using HanoiTowers;

Console.Clear();
Graphics.GreetingsScreen();

// Instrukcja obslugi i rozpoczecie gry
string choice;
do
{
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Choose();
            break;
        case "2":
            Console.Clear();
            Texts.History();
            Texts.Instruction();
            Console.ReadKey();
            Choose();
            break;
        default:
            Console.WriteLine("Tylko 1 lub 2...");
            break;
    }
} while (choice != "1" && choice != "2");

// Wybieranie poziomu gry
void Choose()
{
    // Tutaj wybierasz jeden z trzech poziomow gry (tzw. level)
    // Graphics.ChooseLevelScreen();

}

// Wyswietlanie ekranu gry
string input;
int ring;
var movesPlayerCount = 0;

// Warunek: graj dopuki stan gry nie jest stanem koncowym
// Zmieniaj ekran gry po kazdym ruchu
// licz ruchy gracza

Console.Clear();
LevelEasy.GameScreen();
Console.WriteLine("Z ktorego patyka ( 1, 2 lub 3 ) chcesz wziac krazek?");

// reset krazka
ring = 0;

// RUCH GRACZA
do
{
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
        default:
            Console.WriteLine("Jezeli ugrzazles i nie wiesz co zrobic, mozesz nacisnac 'H' aby otrzymac podpowiedz (hint).");
            Console.WriteLine("W kazdej chwili mozesz tez zakonczyc gre naciskajac 'Q' (quit).");
            Console.WriteLine("A jezeli grasz dalej, to wybierz 1, 2 lub 3...");
            input = Console.ReadLine();
            if (input.ToUpper() == "Q")
            {
                Console.Clear();
                Graphics.GameOver();
                break;
            }
            else if (input.ToUpper() == "H")
            {
                Console.Clear();
                Texts.HelpA();
                break;
            }
            break;
    }
} while (input != "1" && input != "2" && input != "3" && input.ToUpper() != "Q" && input.ToUpper() != "H" || ring == 0);

Console.WriteLine("Wybierz patyk ( 1, 2 lub 3 ) na ktorym chcesz polozyc krazek");

do
{
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
        default:
            Console.WriteLine("Jezeli ugrzazles i nie wiesz co zrobic, mozesz nacisnac 'H' aby otrzymac podpowiedz (hint).");
            Console.WriteLine("W kazdej chwili mozesz tez zakonczyc gre naciskajac 'Q' (quit).");
            Console.WriteLine("A jezeli grasz dalej, to wybierz 1, 2 lub 3...");
            input = Console.ReadLine();
            if (input == "q" || input == "Q")
            {
                Graphics.GameOver();
                break;
            }
            else if (input == "H" || input == "h")
            {
                Texts.HelpA();
                break;
            }
            break;
    }
} while (input != "1" && input != "2" && input != "3" && input.ToUpper() != "Q" && input.ToUpper() != "H");

movesPlayerCount++;

// zapis zmiany stanu gry



int RemoveRingFromStick(int stickNumber)
{
    var stick = stickNumber == 1 ? LevelEasy.stick1 : stickNumber == 2 ? LevelEasy.stick2 : LevelEasy.stick3;

    // Jesli krazek jest pusty
    if (stick[0] == 0)
    {
        Console.WriteLine("Hola, hola! Z pustego nawet Salomon nie naleje... ");
        Console.WriteLine("Wybierz patyk na ktorym jest jakis krazek.");
        return ring = 0;
    }
    else
    {
        Console.WriteLine($"Zdejmujesz krazek z patyka {stickNumber}");
        ring = stick[0];
        var minimumStick = int.MaxValue;
        int minimumIndex = -1;

        // Zdejmowanie krazka z patyka
        for (var index = 1; index < stick.Length; index++)
        {
            if (stick[index] == ring)
            {
                stick[index] = 0;
            }
        }
        // Zmiana indexu patyka
        for (var index = 1; index < stick.Length; index++)
        {
            if (stick[index] != 0 && stick[index] < minimumStick)
            {
                minimumStick = stick[index];
                minimumIndex = index;
            }
        }
        stick[0] = (minimumIndex != -1) ? stick[minimumIndex] : 0;
        return ring;
    }
}

void PutRingOnStick(int stickNumber)
{
    var stick = stickNumber == 1 ? LevelEasy.stick1 : stickNumber == 2 ? LevelEasy.stick2 : LevelEasy.stick3;

    // Jesli jest tam juz mniejszy krazek
    if (ring > stick[0] && stick[0] != 0)
    {
        Texts.RingsRulesPoem();
    }
    else
    {
        Console.WriteLine($"Kladziesz krazek na patyku {stickNumber}");

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
    }
}




