
Console.WriteLine("Bem vindo ao programa que calcula a idade e a média de peso dez pessoas");

List<Person> persons = new List<Person>();

persons.Add(new Person(1, 15.7));
persons.Add(new Person(5, 20.5));
persons.Add(new Person(25, 110.8));
persons.Add(new Person(50, 80));
persons.Add(new Person(75, 67));
persons.Add(new Person(89, 62.8));
persons.Add(new Person(23, 55.7));
persons.Add(new Person(27, 80.5));
persons.Add(new Person(35, 94));
persons.Add(new Person(12, 40));

var oneToTenWeight = 0.0;
var oneToTenCounter = 0.0;
var oneToTenAverage = 0.0;

var elevenToTwentyWeight = 0.0;
var elevenToTwentyCounter = 0.0;
var elevenToTwentyAverage = 0.0;

var tOneToThirtyWeight = 0.0;
var tOneToThirtyCounter = 0.0;
var tOneToThirtyAverage = 0.0;

var abvThirtyWeight = 0.0;
var abvThirtyCounter = 0.0;
var abvThirtyAverage = 0.0;

foreach (var person in persons)
{
    if (person.Age <= 10)
    {
        oneToTenWeight += person.Weight;
        oneToTenCounter++;
    }

    if(person.Age<= 20)
    {
        elevenToTwentyWeight += person.Weight;
        elevenToTwentyCounter++;
    }

    if (person.Age <= 30)
    {
        tOneToThirtyWeight += person.Weight;
        tOneToThirtyCounter++;
    }

    if (person.Age > 30)
    {
        abvThirtyWeight += person.Weight;
        abvThirtyCounter++;
    }
}

oneToTenAverage = oneToTenWeight / oneToTenCounter;
elevenToTwentyAverage = elevenToTwentyWeight / elevenToTwentyCounter;
tOneToThirtyAverage = tOneToThirtyWeight / tOneToThirtyCounter;
abvThirtyAverage = abvThirtyWeight / abvThirtyCounter;

Console.WriteLine();
Console.WriteLine("A média de peso das dez pessoas divida por faixa etária é:");
Console.WriteLine($"1 a 10: {oneToTenAverage.ToString("F2")}");
Console.WriteLine($"11 a 20: {elevenToTwentyAverage.ToString("F2")}");
Console.WriteLine($"21 a 30: {tOneToThirtyAverage.ToString("F2")}");
Console.WriteLine($"Maior que 30: {abvThirtyAverage.ToString("F2")}");



public class Person
{
    public int Age { get; set; }
    public double Weight { get; set; }

    public Person(int age, double weight)
    {
        Age = age;
        Weight = weight;
    }
}
