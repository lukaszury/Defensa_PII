using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode : IOfferItem
    {
        private string code {get;set;}
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }

        public PromoCode(string code, int amount)
        {
            this.code = code;
            if(amount < 0)
            {
                this.amount = amount;
            }
            else
            {
                throw new ArgumentException();
            }
           
        }

        public void AddDiscount()
        {

        }
    }
}