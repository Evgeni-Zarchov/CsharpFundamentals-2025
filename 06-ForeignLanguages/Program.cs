string country = Console.ReadLine();

string spokenLanguage = string.Empty;

switch (country)
{
    case "England":
    case "USA":
        spokenLanguage = "English";
        break;
    case "Spain":
    case "Argentina":
    case "Mexico":
        spokenLanguage = "Spanish";
        break;
    default:
        spokenLanguage = "unknown";
        break;
}

Console.WriteLine(spokenLanguage);