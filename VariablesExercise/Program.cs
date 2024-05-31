namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string personName = "Douglas";
            int personAge = 47;
            char personFirstName = 'D';
            char personLastName = 'B';
            bool personAgeOld = true;
            double myAge = 47.1;
            decimal myAgeD = 47.1m;


            Console.WriteLine($"Is {personName} with an age of {personAge}\n" +
                "older than you?");
            Console.WriteLine($"First letter of Name starts with {personFirstName}. Last letter of Name starts with {personLastName}.\n");
            Console.WriteLine($"Person is old: {personAgeOld}");
            Console.WriteLine($"His age is {myAge}");

        }

    }
}