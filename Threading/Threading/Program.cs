namespace Threading
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var account = new BankAcount(1000);
            var tasks=new List<Task>()
            {
                account.DepositAsync(500),
                account.WithdrawAsync(200),
                account.WithdrawAsync(1000),
                account.DepositAsync(300),
                account.WithdrawAsync(400),
            };
            await Task.WhenAll(tasks);
            Console.WriteLine($"Final balance {account.GetBalance()}");
        }
    }
}
