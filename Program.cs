namespace animalLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] animalName = { "Koer", "Kass", "Jänes", "Sipelgasiil", "Lendorav" };

            string longestName = FindLongestAnimal(animalName);

            Console.WriteLine(longestName);
        }

        static string FindLongestAnimal(string[] animals)
        {
            string longest = animals[0];

            foreach (string animal in animals)
            {
                if (animal.Length > longest.Length)
                {
                    longest = animal;
                }
            }
            Console.WriteLine(longest + " " + longest.Length);

            return longest;
        }
    }
}
