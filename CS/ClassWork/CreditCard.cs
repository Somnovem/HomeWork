using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class CreditCard
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CVV { get; set; }
        public decimal Balance { get; set; }
        public CreditCard(string number,string name,DateTime expire,int cvv,decimal balance)
        {
        Number = number;
        Name = name;
        ExpirationDate = expire;
        CVV = cvv;
        Balance = balance;
        }
        public decimal this[string mode]
         {
            get
            {
                if (mode == "USD")
                {
                    return Balance / 42;
                }
                else if (mode == "EUR")
                {
                    return Balance / (decimal)41.5;
                }
                else
                {
                    return Balance;
                }
            }
            set
            {
                if (mode == "USD")
                {
                    Balance = value*42;
                }
                else if (mode == "EUR")
                {
                    Balance = value*(decimal)41.5;
                }
                else
                {
                    Balance = value;
                }
            }
         }
        public static CreditCard operator ++(CreditCard card)
        {
            card.Balance+= 100;
            return card;
        }
        public static CreditCard operator --(CreditCard card)
        {
            if (card.Balance > 100) card.Balance += 100;
            return card;
        }
        public static CreditCard operator+(CreditCard card,int n)
        {
            card.Balance += n;
            return card;
        }
        public static CreditCard operator -(CreditCard card, int n)
        {
            if (n <= card.Balance)
            {
                card.Balance -= n;
            }
            return card;
        }
        public static bool operator ==(CreditCard card1, CreditCard card2) { return card1.CVV == card2.CVV; }
        public static bool operator !=(CreditCard card1, CreditCard card2) { return card1.CVV != card2.CVV; }
        public static bool operator <(CreditCard card1, CreditCard card2) { return card1.Balance < card2.Balance; }
        public static bool operator >(CreditCard card1, CreditCard card2) { return card1.Balance > card2.Balance; }
        public override bool Equals(object obj)
        {
            if (!(obj is CreditCard))
            {
                return false;
            }
            CreditCard other = (CreditCard)obj;
            if (this.Number != other.Number)
            {
                return false;
            }
            if (this.Name != other.Name)
            {
                return false;
            }
            if (this.ExpirationDate != other.ExpirationDate)
            {
                return false;
            }
            if (this.CVV != other.CVV)
            {
                return false;
            }
            if (this.Balance != other.Balance)
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            string res = "";
            res += "Name: "+Name + "\n";
            res += "Number: " + Number + "\n";
            res += "Expiration Date: " + ExpirationDate + "\n";
            res += "CVV code: " + CVV + "\n";
            res += "Balance: " + Balance + " UAH\n";
            return res;
        }
    }
}
