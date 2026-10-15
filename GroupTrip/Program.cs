const double taxRate = 0.18;
const int slicesPerPizza = 8;





Console.WriteLine("=== Part 1: Road Trip ===");

Console.Write("What was the round trip in miles? ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car you are using? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the gas price? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How many pizzas will there be? ");
double pizzaAmount = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What was the price per pizza? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//do the math

//do the output

Console.WriteLine("");
Console.WriteLine("Fuel Cost: " + FuelCost(milesForTheTrip, milesPerGallon, gasPrice).ToString("C"));
Console.WriteLine("");

//Pizza Party

//Gather the data

Console.WriteLine("=== Part 2: Pizza Party ===");

//Console.WriteLine("How many people are going? ");
//int peopleGoing = Convert.ToInt32(Console.ReadLine());

//do the math

double totalSlices = pizzaAmount * slicesPerPizza;
double slicesPerPerson = totalSlices / (double)peopleGoing;
double pizzaCost = pizzaAmount * pricePerPizza;

Console.WriteLine("");
Console.WriteLine("Total slices: " + totalSlices.ToString());
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
Console.WriteLine("");

//Paycheck

//collect data

Console.WriteLine("=== Part 3: Paycheck ===");

//Console.WriteLine("How many hours did you work this week? ");
//double hoursWorked = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("What is your hourly rate? ");
//double hourlyRate = Convert.ToDouble(Console.ReadLine());

//Do the Math

//Print the Output

Console.WriteLine("");
Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));
Console.WriteLine("");


//Create the methods

static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}
static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double grossPay = hours * hourlyRate;
    double taxWithheld = grossPay * taxRate;
    return grossPay - taxWithheld;
}
static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed / takeHomePerHour;

}