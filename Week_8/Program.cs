string[] heroes = { "Harry potter", "Lara Croft", "Siil udus", "Onu Reimus" };
string[] villanis = { "Kana", "Vares", "Kull", "Kukk" };
string[] weapon = { "hark", "kõbla", "labidas", "reha" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Täna {hero} võitleb {heroWeapon} et päästa maailm! ");

string villain = GetRandomValueFromArray(villanis);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Täna {villain} koos {villainWeapon} püüab maailma vallutada");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}