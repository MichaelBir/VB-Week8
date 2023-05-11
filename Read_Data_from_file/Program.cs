string folderPath = @"C:\data\";
string heroFile = "heros.txt";
string villainFile = "villains.txt";

string[] heros = FileShare.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = FileShare.ReaAllLines(Path.Combine(folderPath, villainFile));

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