using System;
using System.Linq;

namespace LuigiChallenge
{
    public class Luigi
    {
        public Luigi()
        {
        }


//Guide Luigi home by following the trail of "0"s from left to right and top to bottom in the 2D matrix.

//Give him directions with two commands:

//"Down" or "Right";

//Example:
//input:

//        [4,0,4]
//        [5,0,0]
//        [6,9,0]
//        [8,3,0]

//        output:

//String "Down Right Down Down"

//(Note: In all the tests Luigi will have clear path.So there will only be a "0" below or to the right of each other.No isolated "0"s or "0"s moving back left.)


        public string GoHome2D(int[][] map)
        {
            var direction = "";
            for(int i = 0; i < map.Length; i++ )
            {
                
                for(int n = 0; n < map[i].Length; n++)
                
                
                    {
                    if (n < map[i].Length -1)
                    {

                        if (map[i][n] == 0 && map[i][n + 1] == 0)
                        {


                            direction += " Right";

                        }


                    }
                       

                    }
                if (i < map.Length -1)
                {
                    direction += " Down";
                }
            }
            return direction.TrimStart();
        }
               
    }
}
    

