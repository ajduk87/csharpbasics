using System;
using System.Text;

namespace DemoCSharpBasics
{
    public static class Program
    {

     
        public static void Main(string[] args)
        {

            //Array with reference types example
            Shape[] shapes = new Shape[4];
            shapes[0] = new Cube(name: "cube", a: 2, color: "blue");
            shapes[1] = new Cylinder(name: "cylinder", r: 2, H: 10, color: "blue");
            shapes[2] = new Sphere(name: "sphere", r: 6, color: "blue");
            ShapeFinder shapeFinder = new ShapeFinder(shapes);


            //shapes[3] = new Cone(name: "cone", r: 2, H:10);(compile error)
            //shapes[8] = new Sphere(name: "sphere", r: 6);//(runtime error)

            /********************************************/
            // a lot of code lines




            // a lot of code lines


            // a lot of code lines

            // a lot of code lines







            // a lot of code lines



            // a lot of code lines
            /********************************************/

            //we want to find sphere from shapeFinder.
            //How?
            //we will use indexers in c#.
            Shape sphere = shapeFinder["sphere"];

            //Much better ?
            //i think yes.
            //No magic number , we wanted sphere from shapeFinder and only wrote sphere
            //AND AGAIN => AVOIDING MAGIC NUMBERS !!!!!!!!!!!!!!!!!!!!!!!

            //How set sphere using indexers
            shapeFinder["sphere"].Color = "green";

            Console.ReadKey();
        }
    }
}
