using static System.Console;

Console.WriteLine("Inserisci il primo numero");
string? input1 = Console.ReadLine();

Console.WriteLine("Inserisci il secondo numero");
string? input2 = Console.ReadLine();

int firstNumber;
int secondNumber;

bool conversioneRiuscita1 = int.TryParse(input1, out firstNumber);
bool conversioneRiuscita2 = int.TryParse(input2, out secondNumber);

if (conversioneRiuscita1 && conversioneRiuscita2)
{
    int sum = firstNumber + secondNumber;
    WriteLine($"La somma è: {sum}");
}
else
{
    WriteLine("Uno dei due valori inseriti non è un numero");
}
