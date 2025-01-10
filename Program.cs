/* Have a title for the app Guestbook
Ask the guest to leave a family name 
//store the name
ask guest how many in their party
//store the number 
//check to see if more guest are coming

once all the guest have logged their info
print out the guest list and number of guest
//loop over names and print them

print out the total of all the guest that
came
*/
using System.Diagnostics.Contracts;

Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Were glad you're here, please sign our Guestbook!");
Console.WriteLine();

var partyName = new List<string>();
var guestCount = new List<int>();
int total = 0;
GuestInfo();
PrintList();

(List<string>, List<int>) GuestInfo()
{

  do
  {
    Console.Write("What is the name for your party: ");
    string? name = Console.ReadLine();
    Console.Write("How many people are in your party: ");
    string? peopleInParty = Console.ReadLine();
    bool isCountValid = int.TryParse(peopleInParty, out int count);
    Console.WriteLine();

    if (name != null && isCountValid)
    {
      partyName.Add(name);
      guestCount.Add(count);

    }
    else
    {
      Console.WriteLine("Not a valid entry");
    }
  } while (partyName.Count < 5);

  return (partyName, guestCount);
}

void PrintList()
{
  Console.WriteLine("Guest that attended the party:");
  foreach (var name in partyName)
  {
    Console.WriteLine(name);
  }
  foreach (var count in guestCount){
    total += count;
  }
  Console.WriteLine($"{total} people were in attendance tonight!");
}