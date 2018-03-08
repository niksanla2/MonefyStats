using System;
using System.Globalization;

namespace MonefyStats.Bussines.Models 
{
    public class MonefyTransaction
    {
        private static IFormatProvider _formatProvider;
        static MonefyTransaction()
        {
            _formatProvider = new CultureInfo("ru-RU");
        }

        public static MonefyTransaction ConvertFromString(string str)
        {
            var style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign;
            
            var values = str.Split(';');
            var result = new MonefyTransaction
            {
                Date = DateTime.ParseExact(values[0], "dd/MM/yyyy", _formatProvider),
                Account = values[1],
                Category  = values[2],
                Price = new Price
                {
                    Value = decimal.Parse(values[3], style, _formatProvider),
                    Currency = values[4]
                },
                ConvertedPrice = new Price
                {
                    Value = decimal.Parse(values[5], style, _formatProvider),
                    Currency = values[6]
                },
                Description = values[7]
            };
            return result;
        }
        public DateTime Date { get; set; }
        public string Account { get; set; }
        public string Category { get; set; }
        public Price Price { get; set; }
        public Price ConvertedPrice { get; set; }
        public string Description { get; set; }       
    }
}
