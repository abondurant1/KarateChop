namespace KarateChop
{
    public class Karate
    {
       public int Chop(int target, int[] numberArray)
        {
            for(int index = 0; index < numberArray.Length; index++)
                if (target == numberArray[index]) 
                    return index;
             
            return -1;
        }
    }
}
