/*
You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, 
return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

Example 1:
    Input: flowerbed = [1,0,0,0,1], n = 1
    Output: true

Example 2:
    Input: flowerbed = [1,0,0,0,1], n = 2
    Output: false
*/
namespace Assignment_5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed = [1, 0, 0, 0, 1];
            int n = 1;

            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            n = 2;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            flowerbed = [0, 0, 0, 0, 0];
            n = 3;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            n = 4;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            flowerbed = new int[] { 0 };
            n = 1;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            flowerbed = new int[] { 1 };
            n = 1;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            flowerbed = new int[0];
            n = 1;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            flowerbed = new int[] { 0, 0, 0, 0, 0 };
            n = 2;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            n = 4;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            flowerbed = new int[] { 0, 1, 0, 1, 0, 1, 0 };
            n = 1;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            flowerbed = new int[] { 0, 1, 0, 0, 0, 1, 0 };
            n = 1;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            flowerbed = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            n = 3;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            flowerbed = new int[] { 1, 0, 0, 0, 0, 0, 1 };
            n = 2;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

            flowerbed = new int[] { 1, 0, 0, 0, 0, 0, 1 };
            n = 3;
            Console.WriteLine($"Input: flowerbed = [{String.Join(", ", flowerbed)}], n = {n}");
            Console.WriteLine($"Output: {CanBePlanted(flowerbed, n)}\n");

        }

        static bool CanBePlanted(int[] flowerbed, int numFlowers)
        {
            // If array length is 0, return false; can't plant flowers without a flowerbedf
            if (flowerbed.Length == 0) return false;

            // If array length is 1
            if (flowerbed.Length == 1)
                return (flowerbed[0] == 0 && numFlowers <= 1);
            
            // If array length > 1
            int plantableFlowers = 0;
            int[] tempArray = (int[])flowerbed.Clone();
            
           
            for (int i = 0; i < tempArray.Length-1; i++)
            {
                // Change first element if necessary
                if (i == 0 && (tempArray[i] + tempArray[i + 1] == 0))
                {
                    tempArray[i] = 1;
                    plantableFlowers++;
                    i++; // Do not need to check the element we just changed, it will always return false
                }

                // Check every other element
                if (tempArray[i] + tempArray[i + 1] == 0)
                {
                    tempArray[i + 1] = 1;
                    plantableFlowers++;
                    i++; // Do not need to check the element we just changed, it will always return false
                }
                if (plantableFlowers >= numFlowers) return true; 
            }
            return false;
        }
    }
}
