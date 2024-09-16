namespace LibraryApp.EanGenertor
{
    public class EanGenerator
    {
        public string GenerateEan()
        {
            Random random = new Random();

            // Generujemy pierwsze 12 cyfr
            string eanWithoutChecksum = "";
            for (int i = 0; i < 12; i++)
            {
                eanWithoutChecksum += random.Next(0, 10).ToString();
            }

            // Obliczamy cyfrę kontrolną
            int checksum = CalculateChecksum(eanWithoutChecksum);

            // Zwracamy pełny kod EAN-13
            return eanWithoutChecksum + checksum.ToString();
        }

        private int CalculateChecksum(string eanWithoutChecksum)
        {
            int sum = 0;
            for (int i = 0; i < eanWithoutChecksum.Length; i++)
            {
                int digit = int.Parse(eanWithoutChecksum[i].ToString());
                sum += (i % 2 == 0) ? digit : digit * 3;
            }

            int checksum = 10 - (sum % 10);
            return checksum == 10 ? 0 : checksum;
        }
    }

}
