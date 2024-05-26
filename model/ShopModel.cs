using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp1.library;

namespace WinFormApp1.model
{

    class ShopModel
    {
        List<Product> allProducts;
        List<string> categories;
        List<string> paymentVariants;
        Client client;
        public ShopModel() 
        {
            allProducts = generateProducts();
            categories = generateCategories();
            paymentVariants = generatePaymentVariants();
            client = new Client(); 
        }
        public bool Pay(int moneyAmount, string paymentVariant)
        {
            return client.Pay(moneyAmount, paymentVariant);
        }
        public List<Product> getAllProducts()
        {
            return allProducts;
        }
        public List<string> getCategories()
        {
            return categories;
        }
        public List<string> getPaymentVariants()
        {
            return paymentVariants;
        }

        public void createNewCLient()
        { 
            this.client = new Client();
        }
        public int getCashAmount()
        {
            return client.cashAmount;
        }
        public int getCardAmount()
        {
            return client.cardAmount;
        }
        private static List<Product> generateProducts()
        {
            List<Product> products = new List<Product>();

            // Категория 1: Электроника
            products.Add(new Product
            {
                category = "Электроника",
                description = "Смартфон Samsung Galaxy S21",
                picture = Image.FromFile("C:/Users/genna/Курсовая 4 семестр/WinFormApp1/WinFormApp1/resources/samsung.jpg"),
                price = 800
            });
            products.Add(new Product
            {
                category = "Электроника",
                description = "Ноутбук Apple MacBook Pro",
                picture = Image.FromFile("C:\\Users\\genna\\Курсовая 4 семестр\\WinFormApp1\\WinFormApp1\\resources\\Macbook.jpg"),
                price = 1500
            });

            // Категория 2: Одежда
            products.Add(new Product
            {
                category = "Одежда",
                description = "Футболка Adidas Originals",
                picture = Image.FromFile("C:\\Users\\genna\\Курсовая 4 семестр\\WinFormApp1\\WinFormApp1\\resources\\adidas.jpg"),
                price = 30
            });
            products.Add(new Product
            {
                category = "Одежда",
                description = "Джинсы Levi's 501",
                picture = Image.FromFile("C:\\Users\\genna\\Курсовая 4 семестр\\WinFormApp1\\WinFormApp1\\resources\\jeans.jpg"),
                price = 70
            });

            // Категория 3: Косметика
            products.Add(new Product
            {
                category = "Косметика",
                description = "Помада MAC Ruby Woo",
                picture = Image.FromFile("C:\\Users\\genna\\Курсовая 4 семестр\\WinFormApp1\\WinFormApp1\\resources\\lipstick.jpg"),
                price = 25
            });
            products.Add(new Product
            {
                category = "Косметика",
                description = "Тушь Maybelline Lash Sensational",
                picture = Image.FromFile("C:\\Users\\genna\\Курсовая 4 семестр\\WinFormApp1\\WinFormApp1\\resources\\brows.jpg"),
                price = 10
            });

            // Категория 4: Кухонная утварь
            products.Add(new Product
            {
                category = "Кухонная утварь",
                description = "Набор сковородок Tefal",
                picture = Image.FromFile("C:\\Users\\genna\\Курсовая 4 семестр\\WinFormApp1\\WinFormApp1\\resources\\tefal.jpg"),
                price = 100
            });
            products.Add(new Product
            {
                category = "Кухонная утварь",
                description = "Мультиварка Philips",
                picture = Image.FromFile("C:\\Users\\genna\\Курсовая 4 семестр\\WinFormApp1\\WinFormApp1\\resources\\multi.jpg"),
                price = 80
            });

            // Категория 5: Книги
            products.Add(new Product
            {
                category = "Книги",
                description = "Роман \"Мастер и Маргарита\"",
                picture = Image.FromFile("C:\\Users\\genna\\Курсовая 4 семестр\\WinFormApp1\\WinFormApp1\\resources\\master.jpg"),
                price = 15
            });
            products.Add(new Product
            {
                category = "Книги",
                description = "Научно-популярная книга \"Космос\"",
                picture = Image.FromFile("C:\\Users\\genna\\Курсовая 4 семестр\\WinFormApp1\\WinFormApp1\\resources\\cosmos.jpg"),
                price = 20
            });

            return products;
        }
        private List<string> generateCategories()
        {
            List<string> categories = new List<string>();

            // Добавляем категории
            categories.Add("Электроника");
            categories.Add("Одежда");
            categories.Add("Косметика");
            categories.Add("Кухонная утварь");
            categories.Add("Книги");

            return categories;
        }
        private List<string> generatePaymentVariants()
        {
            List<string> paymentVariants = new List<string>();
            paymentVariants.Add("Оплата по карте");
            paymentVariants.Add("Оплата наличными");
            return paymentVariants;
        }
    }
}
