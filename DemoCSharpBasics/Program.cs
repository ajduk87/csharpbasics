using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DemoCSharpBasics
{
    public static class Program
    {       

        private static void WriteListItems(List<Shape> soldShapes) 
        {
            foreach (Shape soldShape in soldShapes)
            {
                Console.WriteLine($"name: {soldShape.Name}  kind: {soldShape.Material}  volume: {soldShape.Calculate()}  price:{soldShape.Price}");
            }
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        private static void WriteItem(Shape soldShape)
        {
            Console.WriteLine($"name: {soldShape.Name}  kind: {soldShape.Material}  volume: {soldShape.Calculate()}  price:{soldShape.Price}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {                    

            //AsReadOnly()
            List<ChessField> fields = ChessField.CreateChessFields();
            ReadOnlyCollection<ChessField> chessFieldsList = fields.AsReadOnly();

            fields.Add(new ChessField('J',2));
            //chessFieldsList.Add(new ChessField('J', 2));

            ChessField[] chessFieldsArray = ChessField.CreateChessFieldsWithArray();

            ChessField listItem = fields[4];

            ChessField arrayItem = chessFieldsArray[4];


            Console.ReadKey();
        }
    }
}
