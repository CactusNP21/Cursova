namespace Cursova
{
    public class BullsAndCowsAI
    {
        public string generateRnd()
        {
            Random rnd = new();
            int num;
            do
            {
                num = rnd.Next(1000, 10000);
            } while (num.ToString().Distinct().Count() != 4);
            return num.ToString();
        }
    }
}
