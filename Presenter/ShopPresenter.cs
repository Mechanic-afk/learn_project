using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp1.model;
using WinFormApp1.view;
using WinFormApp1.library;

namespace WinFormApp1.presenter
{
    class ShopPresenter: IPresenter
    {
        public IView view;
        public ShopModel model;
        public List<Product> allProducts;

        public ShopPresenter(IView view)
        {
            this.view = view;
            model = new ShopModel();
            allProducts = getAllProducts();
        }

        public List<Product> getAllProducts()
        {
            return model.getAllProducts();
        }

        public int getCardAmount()
        {
            return model.getCardAmount();
        }

        public int getCashAmount()
        {
            return (model.getCashAmount());
        }

        public List<string> getCategories()
        {
            return model.getCategories();
        }

        public List<string> getPaymentVariants()
        {
            return model.getPaymentVariants();
        }

        public Product getProductByName(string name)
        {
            foreach (Product product in allProducts)
            {
                if (product.description == name)
                {
                    return product;
                }
            }
            // Если продукт с таким именем не найден, вернуть null или бросить исключение
            return null;
        }

        public List<Product> getProductsByCategory(string selectedCategory)
        {
            List<Product> productsInCategory = new List<Product>();

            // Пройти по списку всех товаров
            foreach (Product product in allProducts)
            {
                // Если категория товара совпадает с выбранной категорией, добавить его в список
                if (product.category == selectedCategory || selectedCategory == "Все категории")
                {
                    productsInCategory.Add(product);
                }
            }

            return productsInCategory;
        }

        public bool Pay(int moneyAmount, string paymentVariant)
        {
            return model.Pay(moneyAmount, paymentVariant);
        }

        public void startNewSession()
        {
            model.createNewCLient();
        }

        public int sumPrices(ListBox listBox)
        {
            int sum = 0;
            if (listBox.Items.Count > 0)
            {
                foreach (Product product in listBox.Items)
                {
                    sum += product.price;
                }
            } else {
                sum = 0;
            }

            return sum;
        }
    }
}
