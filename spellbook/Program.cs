using spellbook;
using spellbook.txt;

Console.WriteLine("Generátor randomísek spellů");

List<Spell> seznamSpellu = new List<Spell>();
HelperClass pomocneMetody = new HelperClass();

string[] poleForma = pomocneMetody.PoleZTextu("txt/spellform.txt");
string[] poleTypy = pomocneMetody.PoleZTextu("txt/spellform.txt");
bool franta = true;
while (franta == true)
{
    Console.WriteLine("1. vygenerovat nový spell a přidat do spellbooku");
    Console.WriteLine("2. zobrazit spellbook");
    Console.WriteLine("3. smazat poslední spell ve spellbooku");
    Console.WriteLine("4. smazat celý spellbooku");
    Console.WriteLine("*. pro ukončení aplikace");
    string input = Console.ReadLine();
    if (input == "1")
    {
        Spell spell = new Spell();
        Console.WriteLine(); //netuším

        Random mana = new Random();
        int cislo = mana.Next(0, 100);

        Console.Clear();
    }
    else if (input == "2")
    {
        Console.WriteLine(pomocneMetody.PoleZTextu);
    }
    else if (input == "3")
    {
        int indexPosledniho = seznamSpellu.Count -1;
        Spell posledni = seznamSpellu[indexPosledniho];
        seznamSpellu.Remove(posledni);
    }
    else if (input == "4")
    {
        Console.Clear(); //problém :tf:
        //nevím :(((((((((((((((((((((((((((((((((((((
    }
    else if (input == "*")
    {
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Nepíšeš dobře bráško :(");
    }

}