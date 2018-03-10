using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonefyStats.Bussines.Models
{
    public class MonefyProfile
    {
        private readonly IEnumerable<MonefyTransaction> _transactions;
        private IEnumerable<MonefyAccount> _accounts;
        private IEnumerable<string> _categories;

        public MonefyProfile(IEnumerable<MonefyTransaction> transactions)
        {
            _transactions = transactions;
        }
        public IEnumerable<MonefyAccount> Accounts
        {
            get
            {
                _accounts = _transactions
                    .GroupBy(el => el.Account)
                    .Select(gr => new MonefyAccount(gr, gr.Key));
                return _accounts;
            }
        }
        public IEnumerable<string> Categories
        {
            get
            {
                _categories = _transactions
                    .GroupBy(el => el.Category)
                    .Select(el => el.Key);
                return _categories;
            }
        }
    }
    
}
