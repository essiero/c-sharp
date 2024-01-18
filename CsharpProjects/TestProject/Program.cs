string firstName;
firstName = "Bob";
int messages = 3;
float temp = 34.4f;
Console.WriteLine($"Hello, {firstName}! You have {messages} messages in your inbox. The temperature is {temp} celsius.");

Console.WriteLine("Check out a carriage return: \r that was it!");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\data.txt\n");
Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");

// To combine interpolation and verbatim string literals:
//  string englishLocation = $@"c:\Exercise\{projectName}\data.txt";

// decimal decimalQuotient = 7 / 5.0m;
// decimal decimalQuotient = 7.0m / 5.0m;
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

int fahrenheit = 94;

decimal celsius = (fahrenheit - 32m) * 5m/9m;
Console.WriteLine($"The temperature is {celsius} Celsius.");


