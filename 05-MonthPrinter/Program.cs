int month = int.Parse(Console.ReadLine());

string monthOfTheYear = string.Empty;

switch (month)
{
    case 1:
        monthOfTheYear = "January";
        break;
    case 2:
        monthOfTheYear = "February";
        break;
    case 3:
        monthOfTheYear = "March";
        break;
    case 4:
        monthOfTheYear = "April";
        break;
    case 5:
        monthOfTheYear = "May";
        break;
    case 6:
        monthOfTheYear = "June";
        break;
    case 7:
        monthOfTheYear = "July";
        break;
    case 8:
        monthOfTheYear = "August";
        break;
    case 9:
        monthOfTheYear = "September";
        break;
    case 10:
        monthOfTheYear = "October";
        break;
    case 11:
        monthOfTheYear = "November";
        break;
    case 12:
        monthOfTheYear = "December";
        break;
    default:
        monthOfTheYear = "Error!";
        break;
}

Console.WriteLine(monthOfTheYear);
