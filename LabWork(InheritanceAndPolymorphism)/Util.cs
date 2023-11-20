public static class Util
{
    public static List<string> GenerateRandomNumbers(int count, int min, int max, int length)
    {
        List<string> generatedNumbers = new List<string>();
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            // Generate a random n-digit number within the specified range 
            int randomValue = random.Next(min, max + 1);

            // Format the number as an n-digit string as specified by length 
            string formattedNumber = randomValue.ToString("D" + length);

            // Add the generated number to the list 
            generatedNumbers.Add(formattedNumber);
        }
        return generatedNumbers;
    }
}

