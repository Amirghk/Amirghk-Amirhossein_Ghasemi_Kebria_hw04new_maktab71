using Newtonsoft.Json;

string[] info = { "First Name", "Last Name", "Height", "Phone Number", "Father's Name", "Weight", "Address", "Id", "Day of birth", "Month of Birth", "Year of Birth" };


List<string>? list = new List<string>();

// ask user for info and save them in a list
foreach (string item in info)
{
    Console.WriteLine($"Please Enter your {item}");
    string? input = Console.ReadLine();
    list.Add(input);
}

// convert birthday to datetime format
int day = Convert.ToInt32(list[list.Count - 3]);
int month = Convert.ToInt32(list[list.Count - 2]);
int year = Convert.ToInt32(list[list.Count - 1]);
DateTime birthDate = new DateTime(year, month, day);



// make a new person according to info provided
Person person = new Person(list[0], list[1], Convert.ToInt32(list[2]), list[3], list[4], Convert.ToInt32(list[5]), birthDate, list[6], list[7]);

string address = @"G:\MAKTAB\HomeWork4\Users.txt";

string output = JsonConvert.SerializeObject(person);
File.WriteAllText(address, output);

List<Person> personList = new List<Person>();
string data = File.ReadAllText(address);
Person? nperson = JsonConvert.DeserializeObject<Person>(data);
personList.Add(nperson);

foreach( Person p in personList)
{
    Console.WriteLine(p.ToString());
}


Console.WriteLine("Press Any key to continue.");
Console.ReadKey(true);

File.WriteAllText(address, ""); // contents of the file are deleted here


Console.WriteLine("Choose option: ");
Console.WriteLine("1-SMS");
Console.WriteLine("2-Email");

var choice = Console.ReadKey(true);

// do boxing here
ISendMessage smsMessage = new SMSSender();
ISendMessage emailMessage = new EmailSender();

switch(choice.Key)
{
    case ConsoleKey.D1:
        ISMSSending sms = (SMSSender)smsMessage; // unboxing
        sms.Send();
        break;
    case ConsoleKey.D2:
        IEmailSending email = (IEmailSending)emailMessage;
        email.Send();
        break;
}






