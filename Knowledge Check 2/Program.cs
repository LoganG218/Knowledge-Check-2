using Knowledge_Check_2;

Console.WriteLine("How many String Instruments do you want to add?");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<StringInstrument>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var stringInstrument = new StringInstrument();

    Console.WriteLine("Enter number of strings.");
    stringInstrument.strings = int.Parse(Console.ReadLine());

    Console.WriteLine("Is it Acoustic?");
    stringInstrument.acoustic = Console.ReadLine() == "true";

    Console.WriteLine("Enter Intrument Name");
    stringInstrument.Name = Console.ReadLine();

    recordList.Add(stringInstrument);
}

// Print out the list of records using Console.WriteLine()
foreach (var stringInstrument in recordList) 
{
    Console.WriteLine(stringInstrument.Name);
    Console.WriteLine(stringInstrument.acoustic);
    Console.WriteLine(stringInstrument.strings);
}