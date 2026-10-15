const double taxRate = 0.18;
const int slicesPerPizza = 8;

Console.Write("What was the round trip in miles? ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car you are using? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the gas price? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas will there be? ");
double pizzaAmount = Convert.ToDouble(Console.ReadLine());

Console.Write("What was the price per pizza? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//do the math

double fuelCost = FuelCost(milesForTheTrip, milesPerGallon, gasPrice);
double pizzaCost = pizzaAmount * pricePerPizza;
double tripTotal = fuelCost + pizzaCost;

//do the output

Console.WriteLine("");
Console.WriteLine("=== Part 1: The Trip ===");
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
Console.WriteLine($"Pizza cost: {pizzaCost.ToString("C")}");
Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine("");

//List Out Variables

string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

//Do the math

int peopleGoing = names.Length;
double slicesEach = (pizzaAmount * slicesPerPizza)/peopleGoing;
double costPerPerson = tripTotal/peopleGoing;

//Print out values

Console.WriteLine("=== Part 2: The Group ===");
Console.WriteLine("People going: " + peopleGoing.ToString());
Console.WriteLine("Slices each: " + slicesEach.ToString("F1"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("");

Console.WriteLine("=== Part 3: Who Works How Long ===");

double totalHours = 0;
double totalTakeHomePay = 0;
double longest = 0;

for (int i = 0; i < names.Length; i++)
{   
    double takeHomePay = TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate);
    double takeHomePerHour = takeHomePay/hoursWorked[i]; 
    double hoursNeeded = HoursToCover(costPerPerson, takeHomePerHour);

    Console.WriteLine($"{names[i]}: takes home {takeHomePay.ToString("C")} for {hoursWorked[i].ToString()} hours, {takeHomePerHour.ToString("C")} per hour, must work {hoursNeeded.ToString("F2")} hours");

    totalHours = totalHours + hoursWorked[i];
    totalTakeHomePay = totalTakeHomePay + takeHomePay;
    longest = Math.Max(longest, hoursNeeded);
}

Console.WriteLine("");
Console.WriteLine("Total hours worked: " + totalHours.ToString());
Console.WriteLine("Total take home pay: " + totalTakeHomePay.ToString("C"));
Console.WriteLine("Longest anyone must work: " + longest.ToString("F2"));
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