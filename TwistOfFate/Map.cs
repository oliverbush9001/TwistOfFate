using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*TO DO:
 * 
 * 
 * 
 * 
 */

namespace TwistOfFate
{
    public class Map
    {
        //X and Y coordinates for Map 
        public int Rows = 2;
        public int Columns = 3;
        public string[,] MapGrid;

        public Map()
        {
            MapGrid = new string[Rows, Columns];
            InitializeMap();
        }

        private void InitializeMap()
        {
            //Hard coded map for now, will improve later
            MapGrid = new string[,]
            {
                {"1,0", "1,1", "1,2" },
                {"0,0", "0,1", "0,2" }
            };
        }
        public string DisplayMap(int PlayerLocationX, int PlayerLocationY)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                    if (i == PlayerLocationX && j == PlayerLocationY)
                    {
                        sb.Append("  X    ");
                    }
                    else
                    {
                        sb.Append(MapGrid[i, j] + "    ");
                    }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}