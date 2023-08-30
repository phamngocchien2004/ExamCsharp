using Exam2;

class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion(200, "Lion");
        Tiger tiger = new Tiger(100, "Tiger");

        Animal[] animals = {  tiger , lion };

        foreach (var animal in animals)
        {
            animal.Show();
        }
    }
}
