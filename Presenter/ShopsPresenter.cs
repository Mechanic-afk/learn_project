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
    class ShopPresenter : IPresenter
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