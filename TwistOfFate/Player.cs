using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

/*TO Do
 * Add a see deck method
 * Add a see map method 
 * 
 * 
 * 
 */

namespace TwistOfFate
{
    public class Player
    {
        public string Name { get; set; }
        public int PlayerLocationX { get; set; }
        public int PlayerLocationY { get; set; }

        public Deck PlayerDeck { get; set; }
      

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}