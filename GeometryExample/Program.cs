using GeometryExample;

class Program
{
    static void Main(string[] args)
    {
        Cylinder cylinder = new Cylinder();

        Console.WriteLine("enter the dimenstions of the cylinder");
        Console.WriteLine("---------------------------------------------");

        cylinder.Process();
        cylinder.Result();
    }
}
