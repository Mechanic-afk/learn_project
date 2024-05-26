using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp1.library;

namespace WinFormApp1.presenter
{
    interface IPresenter
    {
        Product getProductByName(string name);
        List<Product> getProductsByCategory(string selectedCategory);
        List<string> getCategories();
        List<string> getPaymentVariants();

        int sumPrices(ListBox listBox);
        int getCardAmount();
        int getCashAmount();
        bool Pay(int moneyAmount, string paymentVariant);

        void startNewSession();
    }
}
