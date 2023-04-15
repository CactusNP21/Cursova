namespace Cursova
{
    internal class Tools
    {
        public static void CountBullsAndCows(string digits, string secretNumber, Player player)
        {
            int bulls = 0;
            int cows = 0;
            var d = digits.Distinct().Select((p, i) => p.ToString()).ToList();
            var s = d.Select((d, i) =>
            {
                int pos = secretNumber.IndexOf(d);
                var _ = pos > -1 ? pos == i ? bulls += 1 : cows += 1 : 0;
                return d;
            });
            s.ToList();
            player.bulls = bulls.ToString();
            player.cows = cows.ToString();
        }

        public static bool Validate(string input, string secretNumber, Player player)
        {
            try
            {
                bool unique = input.Distinct().Count() == 4;
                bool digits = input.All(d => d >= '0' && d <= '9');
                if (unique && input.Length == 4 && digits)
                {
                    string pa = player.prevAns;
                    int num = int.Parse(input);
                    pa += input;
                    CountBullsAndCows(input, secretNumber, player);
                    pa += "  Бики: " + player.bulls + "  " + "Корови: " + player.cows + "\n";
                    player.prevAns = pa;
                    return true;
                }
                else
                {
                    MessageBox.Show("Неправильне число");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("INCORRECT INPUT");
                return false;
            }
        }
        public static bool Uniqueness(string input)
        {
            bool zero = input.StartsWith("0");
            bool len = input.Length == 4;
            bool unique = input.Distinct().Count() == 4;
            bool digits = input.All(d => d >= '0' && d <= '9');
            return !zero && len && unique && digits;
        }
        public static void IncorrectInput()
        {
            MessageBox.Show("Неправильне число " +
                    "\n" +
                    "Число повинно складатися з різних цифр, не починатися з 0 і бути 4-ох значним"
                    );
        }

    }
}
