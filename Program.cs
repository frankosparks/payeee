using System.Net;

Console.WriteLine("PAYE calculator.");
while(true){
Console.WriteLine("Enter your gross salary:");
//Error handling method 1 *BEST*
if(!double.TryParse(Console.ReadLine(),out double gross)){
    Console.WriteLine("Invalid input.Please enter a valid input!");
    continue;
}
Console.WriteLine("Enter your allowances:");
double allowances = Convert.ToDouble(Console.ReadLine());
//Error handling method 2
try{
    allowances = Convert.ToDouble(allowances);
    break;
}
catch(FormatException){
    Console.WriteLine("Invalid input.Please enter a valid input!");
}

double taxableIncome = gross - allowances;
double taxx; // Declare taxx outside the if-else statements

if (taxableIncome <= 24000)
{
    taxx = taxableIncome * 0.1;
}
else if (taxableIncome <= 40000)
{
    taxx = taxableIncome * 0.15;
}
else if (taxableIncome <= 60000)
{
    taxx = taxableIncome * 0.2;
}
else if (taxableIncome <= 100000)
{
    taxx = taxableIncome * 0.25;
}
else if (taxableIncome <= 150000)
{
    taxx = taxableIncome * 0.3;
}
else if (taxableIncome <= 250000)
{
    taxx = taxableIncome * 0.35;
}
else
{
    taxx = taxableIncome * 0.4;
}

double personalRelief = 1000;
double PAYE = taxx - personalRelief;

Console.WriteLine($"Gross pay = {gross}");
Console.WriteLine($"Allowances = {allowances}");
Console.WriteLine($"Taxable Income = {taxableIncome}");
Console.WriteLine($"Personal Relief = {personalRelief}");
Console.WriteLine($"PAYE = {PAYE}");
}

