using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WinFormApp1.library;

namespace WinFormApp1.view
{
    interface IView
    {
        void displayCategory(string categoryName);
        void displayProduct();
        void addInCart();
        void removeFromCart();
        void clearCart();
        void showErrorPaymentMessage();
        void showSuccessPaymentMessage();
        void fillProductList();
        void fillCategories();
    }
}
