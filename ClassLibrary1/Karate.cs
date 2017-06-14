using System.Linq;

namespace KarateChop
{
    public class Karate
    {
       public int Chop(int target, int[] numberArray)
        {
            var index = numberArray.ToList().IndexOf(target);
             
            return index;
        }
    }
}
