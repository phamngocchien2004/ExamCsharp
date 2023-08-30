using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    internal class Cylinder
    {
        private double Radius { get; set; }
        private double Height { get; set; }
        public void Process()
        {
            Console.WriteLine("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());
        }

        public void Result()
        {
            double BaseArea = Radius * Radius * Math.PI;
            double LateralArea = 2 * Math.PI * Radius * Height;
            double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            double Volume = Math.PI * Radius * Radius * Height;
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine($"Radius :{Radius}");
            Console.WriteLine($"Height : {Height}");
 
            Console.WriteLine($"Base: {BaseArea}");
            Console.WriteLine($"Lateral: {LateralArea}");
            Console.WriteLine($"Total: {TotalArea}");
            Console.WriteLine($"Volumn: {Volume}");
        }
    }
}