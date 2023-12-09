namespace ParamsExample.Models
{
    public class User
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        private string Password { get; set; }
        private double Balance { get; set; }
        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }
        public double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }
        public User(string name, string email, string password)
        {
            Name = name;
            EmailAddress = email;
            Password = password;
            Balance = 0;
        }

        public bool ValidatePassword(string password)
        {
            return Password == password;
        }

        public bool ValidateEmail(string email)
        {
            return EmailAddress == email;
        }

        public bool ValidateUser(string email, string password)
        {
            return ValidateEmail(email) && ValidatePassword(password);
        }

        public bool ValidateUser(User user)
        {
            return ValidateUser(user.EmailAddress, user.Password);
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}