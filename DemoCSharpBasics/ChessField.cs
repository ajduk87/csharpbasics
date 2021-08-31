using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class ChessField
    {
        public char Column { get; set; }
        public int Row { get; set; }

        public ChessField(char column, int row)
        {
            Column = Char.ToUpper(column);
            Row = row;
        }

        public static List<ChessField> CreateChessFields() 
        {
            return new List<ChessField>
            {
                new ChessField('A',1),
                new ChessField('A',2),
                new ChessField('A',3),
                new ChessField('A',4),
                new ChessField('A',5),
                new ChessField('A',6),
                new ChessField('A',7),
                new ChessField('A',8),

                new ChessField('B',1),
                new ChessField('B',2),
                new ChessField('B',3),
                new ChessField('B',4),
                new ChessField('B',5),
                new ChessField('B',6),
                new ChessField('B',7),
                new ChessField('B',8),

                new ChessField('C',1),
                new ChessField('C',2),
                new ChessField('C',3),
                new ChessField('C',4),
                new ChessField('C',5),
                new ChessField('C',6),
                new ChessField('C',7),
                new ChessField('C',8),

                new ChessField('D',1),
                new ChessField('D',2),
                new ChessField('D',3),
                new ChessField('D',4),
                new ChessField('D',5),
                new ChessField('D',6),
                new ChessField('D',7),
                new ChessField('D',8),

                new ChessField('E',1),
                new ChessField('E',2),
                new ChessField('E',3),
                new ChessField('E',4),
                new ChessField('E',5),
                new ChessField('E',6),
                new ChessField('E',7),
                new ChessField('E',8),

                new ChessField('F',1),
                new ChessField('F',2),
                new ChessField('F',3),
                new ChessField('F',4),
                new ChessField('F',5),
                new ChessField('F',6),
                new ChessField('F',7),
                new ChessField('F',8),

                new ChessField('G',1),
                new ChessField('G',2),
                new ChessField('G',3),
                new ChessField('G',4),
                new ChessField('G',5),
                new ChessField('G',6),
                new ChessField('G',7),
                new ChessField('G',8),

                new ChessField('H',1),
                new ChessField('H',2),
                new ChessField('H',3),
                new ChessField('H',4),
                new ChessField('H',5),
                new ChessField('H',6),
                new ChessField('H',7),
                new ChessField('H',8),
            };
        }

        public static List<ChessField> CreateChessFieldsWithAddMethod() 
        {
            List<ChessField> chessFields = new List<ChessField>();

            chessFields.Add(new ChessField('A',1));
            chessFields.Add(new ChessField('A',2));
            chessFields.Add(new ChessField('A',3));
            chessFields.Add(new ChessField('A',4));
            chessFields.Add(new ChessField('A',5));
            chessFields.Add(new ChessField('A',6));
            chessFields.Add(new ChessField('A',7));
            chessFields.Add(new ChessField('A',8));

            chessFields.Add(new ChessField('B', 1));
            chessFields.Add(new ChessField('B', 2));
            chessFields.Add(new ChessField('B', 3));
            chessFields.Add(new ChessField('B', 4));
            chessFields.Add(new ChessField('B', 5));
            chessFields.Add(new ChessField('B', 6));
            chessFields.Add(new ChessField('B', 7));
            chessFields.Add(new ChessField('B', 8));

            chessFields.Add(new ChessField('C', 1));
            chessFields.Add(new ChessField('C', 2));
            chessFields.Add(new ChessField('C', 3));
            chessFields.Add(new ChessField('C', 4));
            chessFields.Add(new ChessField('C', 5));
            chessFields.Add(new ChessField('C', 6));
            chessFields.Add(new ChessField('C', 7));
            chessFields.Add(new ChessField('C', 8));

            chessFields.Add(new ChessField('D', 1));
            chessFields.Add(new ChessField('D', 2));
            chessFields.Add(new ChessField('D', 3));
            chessFields.Add(new ChessField('D', 4));
            chessFields.Add(new ChessField('D', 5));
            chessFields.Add(new ChessField('D', 6));
            chessFields.Add(new ChessField('D', 7));
            chessFields.Add(new ChessField('D', 8));

            chessFields.Add(new ChessField('E', 1));
            chessFields.Add(new ChessField('E', 2));
            chessFields.Add(new ChessField('E', 3));
            chessFields.Add(new ChessField('E', 4));
            chessFields.Add(new ChessField('E', 5));
            chessFields.Add(new ChessField('E', 6));
            chessFields.Add(new ChessField('E', 7));
            chessFields.Add(new ChessField('E', 8));

            chessFields.Add(new ChessField('F', 1));
            chessFields.Add(new ChessField('F', 2));
            chessFields.Add(new ChessField('F', 3));
            chessFields.Add(new ChessField('F', 4));
            chessFields.Add(new ChessField('F', 5));
            chessFields.Add(new ChessField('F', 6));
            chessFields.Add(new ChessField('F', 7));
            chessFields.Add(new ChessField('F', 8));

            chessFields.Add(new ChessField('G', 1));
            chessFields.Add(new ChessField('G', 2));
            chessFields.Add(new ChessField('G', 3));
            chessFields.Add(new ChessField('G', 4));
            chessFields.Add(new ChessField('G', 5));
            chessFields.Add(new ChessField('G', 6));
            chessFields.Add(new ChessField('G', 7));
            chessFields.Add(new ChessField('G', 8));

            chessFields.Add(new ChessField('H', 1));
            chessFields.Add(new ChessField('H', 2));
            chessFields.Add(new ChessField('H', 3));
            chessFields.Add(new ChessField('H', 4));
            chessFields.Add(new ChessField('H', 5));
            chessFields.Add(new ChessField('H', 6));
            chessFields.Add(new ChessField('H', 7));
            chessFields.Add(new ChessField('H', 8));

            return chessFields;
        }

        public static ChessField[] CreateChessFieldsWithArray() 
        {
            ChessField[] chessFields = new ChessField[64];

            chessFields[0] = new ChessField('A', 1);
            chessFields[1] = new ChessField('A', 2);
            chessFields[2] = new ChessField('A', 3);
            chessFields[3] = new ChessField('A', 4);
            chessFields[4] = new ChessField('A', 5);
            chessFields[5] = new ChessField('A', 6);
            chessFields[6] = new ChessField('A', 7);
            chessFields[7] = new ChessField('A', 8);

            chessFields[8] = new ChessField('B', 1);
            chessFields[9] = new ChessField('B', 2);
            chessFields[10] = new ChessField('B', 3);
            chessFields[11] = new ChessField('B', 4);
            chessFields[12] = new ChessField('B', 5);
            chessFields[13] = new ChessField('B', 6);
            chessFields[14] = new ChessField('B', 7);
            chessFields[15] = new ChessField('B', 8);

            chessFields[16] = new ChessField('C', 1);
            chessFields[17] = new ChessField('C', 2);
            chessFields[18] = new ChessField('C', 3);
            chessFields[19] = new ChessField('C', 4);
            chessFields[20] = new ChessField('C', 5);
            chessFields[21] = new ChessField('C', 6);
            chessFields[22] = new ChessField('C', 7);
            chessFields[23] = new ChessField('C', 8);

            chessFields[24] = new ChessField('D', 1);
            chessFields[25] = new ChessField('D', 2);
            chessFields[26] = new ChessField('D', 3);
            chessFields[27] = new ChessField('D', 4);
            chessFields[28] = new ChessField('D', 5);
            chessFields[29] = new ChessField('D', 6);
            chessFields[30] = new ChessField('D', 7);
            chessFields[31] = new ChessField('D', 8);

            chessFields[32] = new ChessField('E', 1);
            chessFields[33] = new ChessField('E', 2);
            chessFields[34] = new ChessField('E', 3);
            chessFields[35] = new ChessField('E', 4);
            chessFields[36] = new ChessField('E', 5);
            chessFields[37] = new ChessField('E', 6);
            chessFields[38] = new ChessField('E', 7);
            chessFields[39] = new ChessField('E', 8);

            chessFields[40] = new ChessField('F', 1);
            chessFields[41] = new ChessField('F', 2);
            chessFields[42] = new ChessField('F', 3);
            chessFields[43] = new ChessField('F', 4);
            chessFields[44] = new ChessField('F', 5);
            chessFields[45] = new ChessField('F', 6);
            chessFields[46] = new ChessField('F', 7);
            chessFields[47] = new ChessField('F', 8);

            chessFields[48] = new ChessField('G', 1);
            chessFields[49] = new ChessField('G', 2);
            chessFields[50] = new ChessField('G', 3);
            chessFields[51] = new ChessField('G', 4);
            chessFields[52] = new ChessField('G', 5);
            chessFields[53] = new ChessField('G', 6);
            chessFields[54] = new ChessField('G', 7);
            chessFields[55] = new ChessField('G', 8);

            chessFields[56] = new ChessField('H', 1);
            chessFields[57] = new ChessField('H', 2);
            chessFields[58] = new ChessField('H', 3);
            chessFields[59] = new ChessField('H', 4);
            chessFields[60] = new ChessField('H', 5);
            chessFields[61] = new ChessField('H', 6);
            chessFields[62] = new ChessField('H', 7);
            chessFields[63] = new ChessField('H', 8);

            return chessFields;
        }
    }
}
