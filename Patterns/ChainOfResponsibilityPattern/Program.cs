using System;
namespace ChainOfResponsibilityPattern
{
    public class Customer
    {
        public int AccountValue { get; set; }
        public bool Active { get; set; }
        public int MaxDateValue { get; set; }
        public string Password { get; set; }
    }
    public class RequestContex
    {
        public string Password { get; set; }
        public int Value { get; set; }
        public Customer From { get; set; }
        public Customer To { get; set; }
    }

    public class ResponseContex
    {
        public string Message { get; set; }
    }

    public abstract class TransferMoney
    {
        protected readonly TransferMoney _successor;

        protected TransferMoney(TransferMoney successor)
        {
            _successor = successor;
        }

        public abstract ResponseContex Execute(RequestContex requestContex);
    }
    public class CheckPassword : TransferMoney
    {
        public CheckPassword(TransferMoney transferMoney) : base(transferMoney)
        {

        }
        public override ResponseContex Execute(RequestContex requestContex)
        {
            if (requestContex.From.Password == requestContex.Password)
            {
                return _successor.Execute(requestContex);
            }
            return new ResponseContex()
            {
                Message = "Incorrect Password!"
            };
        }
    }

    public class AccountValueChecker : TransferMoney
    {
        public AccountValueChecker(TransferMoney transferMoney) : base(transferMoney)
        {

        }
        public override ResponseContex Execute(RequestContex requestContex)
        {
            if (requestContex.From.AccountValue >= requestContex.Value)
            {
                return _successor.Execute(requestContex);
            }
            return new ResponseContex()
            {
                Message = "value Not enough!"
            };
        }
    }

    public class FinalExecute : TransferMoney
    {
        public FinalExecute(TransferMoney transferMoney) : base(transferMoney)
        {

        }
        public override ResponseContex Execute(RequestContex requestContex)
        {
            requestContex.From.AccountValue -= requestContex.Value;
            requestContex.To.AccountValue += requestContex.Value;
            return new ResponseContex { Message = "Success!" };

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer from = new Customer()
            {
                AccountValue = 1000,
                Active = false,
                MaxDateValue = 100,
                Password = "1234"
            };
            Customer to = new Customer()
            {
                AccountValue = 10000,
                Active = false,
                MaxDateValue = 2000,
                Password = "1234"
            };

            CheckPassword transfer = new CheckPassword(new AccountValueChecker(new FinalExecute(null)));
            var result = transfer.Execute(new RequestContex()
            {
                Value = 10110,
                From = from,
                Password = "1234",
                To = to
            });
            Console.WriteLine(result.Message);
            Console.ReadKey();

        }
    }
}