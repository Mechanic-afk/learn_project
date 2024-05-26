using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp1.library
{
    class Client
    {
        public bool Pay(int moneyAmount, string paymentVariant)
        {
            bool pay_success = false;
            if (paymentVariant == "cash")
            {
                if (cashAmount > moneyAmount)
                {
                    cashAmount -= moneyAmount;
                    pay_success = true;
                }
                else
                {
                    pay_success = false;
                }
            } else if (paymentVariant == "card")
            {
                if (cardAmount > moneyAmount)
                {
                    cardAmount -= moneyAmount;
                    pay_success = true;
                }
                else
                {
                    pay_success = false;
                }
            } else
            {
                MessageBox.Show("Ошибка при оплате в Клиенте");
            }
            return pay_success;
        }
        public int cashAmount { get; set; }
        public int cardAmount { get; set; }
        public Client()
        {
            this.cashAmount = getRandomNumber(1000, 5000);
            this.cardAmount = getRandomNumber(1000, 5000);
        }
        private int getRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
