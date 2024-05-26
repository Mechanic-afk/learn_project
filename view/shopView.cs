using WinFormApp1.presenter;
using WinFormApp1.view;
using WinFormApp1.library;
using WinFormApp1.model;
using System;

namespace WinFormApp1
{
    public partial class shopView : Form, IView
    {
        ShopPresenter controller;
        public shopView()
        {
            controller = new ShopPresenter(this);
            InitializeComponent();
            fillCategories();
            fillProductList();
            fillPaymentVariants();
            fillWallet();
        }

        public void addInCart()
        {
            if (product_listView.SelectedItems.Count > 0)
            {
                string productName = product_listView.SelectedItems[0].Text;
                Product selectedProduct = controller.getProductByName(productName);
                cart_listBox.Items.Add(selectedProduct);
                payment_textBox.Text = (controller.sumPrices(cart_listBox)).ToString() + " $";
            }
        }

        public void removeFromCart()
        {
            if (cart_listBox.SelectedIndex != -1) // ���������, ��� ������� ������
            {
                cart_listBox.Items.RemoveAt(cart_listBox.SelectedIndex); // ������� ��������� ������� �� listBox
            }
            payment_textBox.Text = (controller.sumPrices(cart_listBox)).ToString() + " $";
        }

        public void clearCart()
        {
            cart_listBox.Items.Clear();
            payment_textBox.Text = (controller.sumPrices(cart_listBox)).ToString() + " $";
        }

        public void displayCategory(string categoryName)
        {
            string selectedCategory = categories_listBox.SelectedItem.ToString();

            // ������� ������ ������� ����� ��������� �����
            product_listView.Items.Clear();

            // �������� ������ ��������� ��������� ���������
            List<Product> productsInCategory = controller.getProductsByCategory(selectedCategory);

            foreach (Product product in productsInCategory)
            {
                ListViewItem item = new ListViewItem(new[] { product.description, product.price.ToString() });
                product_listView.Items.Add(item);
            }
        }

        public void displayProduct()
        {
            if (product_listView.SelectedItems.Count > 0)
            {
                string productName = product_listView.SelectedItems[0].Text;
                Product selectedProduct = controller.getProductByName(productName);

                // ��������� ����������� ������ � PictureBox
                product_pictureBox.Image = selectedProduct.picture;

                // ���������� ���������� � ������ � RichTextBox
                product_richTextBox.Text = selectedProduct.description;
            }
        }

        public void showErrorPaymentMessage()
        {
            // ������� ���������� ���� � ���������� �� ������
            MessageBox.Show("������ ������! ��������� ���� ������ ��� ������� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void showSuccessPaymentMessage()
        {
            // ������� ���������� ���� � ���������� �� �������� ������
            MessageBox.Show("������ ������� ���������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void categories_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayCategory(categories_listBox.SelectedItem.ToString());
        }

        private void product_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayProduct();
        }

        private void product_add_button_Click(object sender, EventArgs e)
        {
            addInCart();
        }

        private void cart_delete_button_Click(object sender, EventArgs e)
        {
            removeFromCart();
        }

        private void cart_clear_button_Click(object sender, EventArgs e)
        {
            clearCart();
        }

        private void payment_buy_button_Click(object sender, EventArgs e)
        {
            string paymentVariant = "";
            if (payment_variants_listBox.SelectedItem == "������ �� �����")
            {
                paymentVariant = "card";
            }
            else if (payment_variants_listBox.SelectedItem == "������ ���������")
            {
                paymentVariant = "cash";
            }
            else
            {
                MessageBox.Show("������ ��� ������ �������� ������");
            }

            bool payment_success = controller.Pay(controller.sumPrices(cart_listBox), paymentVariant);
            if (payment_success)
            {
                showSuccessPaymentMessage();
                fillWallet();
            }
            else
            {
                showErrorPaymentMessage();
            }
        }

        public void fillProductList()
        {
            // ������� ������ ������� ����� �����������
            product_listView.Items.Clear();

            // ��������� ������� � ListView
            product_listView.Columns.Add("�������� ������", 200);
            product_listView.Columns.Add("����", 100);

            List<Product> products = controller.getAllProducts();

            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(new[] { product.description, product.price.ToString() });
                product_listView.Items.Add(item);
            }
        }

        public void fillCategories()
        {
            categories_listBox.Items.Clear();

            // ���������� ���������
            List<string> categories = controller.getCategories();
            categories_listBox.Items.Add("��� ���������");
            foreach (string category in categories)
            {
                categories_listBox.Items.Add(category);
            }
        }

        public void fillPaymentVariants()
        {
            payment_variants_listBox.Items.Clear();

            // ���������� ��������� ������
            List<string> categories = controller.getPaymentVariants();
            foreach (string category in categories)
            {
                payment_variants_listBox.Items.Add(category);
            }
        }

        public void fillWallet()
        {
            cash_textBox.Text = (controller.getCashAmount()).ToString() + " $";
            card_textBox.Text = (controller.getCardAmount()).ToString() + " $";
        }

        private void start_session_button_Click(object sender, EventArgs e)
        {
            controller.startNewSession();
            clearCart();
            fillCategories();
            fillProductList();
            fillPaymentVariants();
            fillWallet();
        }
    }
}