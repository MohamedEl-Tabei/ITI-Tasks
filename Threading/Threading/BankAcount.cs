using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    internal class BankAcount
    {
        private decimal Balance { get; set; } = 0;
        private object obj = new object();

        public BankAcount(decimal balance)
        {
            Balance = balance;
        }
        public async Task DepositAsync(decimal amount) {
            await Task.Run(() =>
            {
                lock (obj)
                {
                    Balance = Balance + amount;
                    Console.WriteLine($"Success: +{amount} Your balance {Balance}");
                }
            });
        } 
        async public Task WithdrawAsync(decimal amount) {
            await Task.Run(() =>
            {
                lock (obj)
                {

                    if (Balance >= amount)
                    {
                        var obj = new object();
                        Balance = Balance - amount;
                        Console.WriteLine($"Success: -{amount} Your balance {Balance}");
                    }
                    else Console.WriteLine($"Fail: Your balance {Balance}");
                }
            });
        }
        public decimal GetBalance() => Balance; 
    }
}
