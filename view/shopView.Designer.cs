namespace WinFormApp1
{
    partial class shopView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dialog = new Label();
            product_listView = new ListView();
            products_label = new Label();
            categories_listBox = new ListBox();
            categories_label = new Label();
            product_pictureBox = new PictureBox();
            product_richTextBox = new RichTextBox();
            product_label = new Label();
            product_add_button = new Button();
            cart_label = new Label();
            cart_listBox = new ListBox();
            cart_delete_button = new Button();
            cart_clear_button = new Button();
            label1 = new Label();
            payment_variants_label = new Label();
            payment_variants_listBox = new ListBox();
            payment_buy_button = new Button();
            payment_textBox = new TextBox();
            sum_label = new Label();
            wallet_label = new Label();
            wallet_cash = new Label();
            cash_textBox = new TextBox();
            card_label = new Label();
            card_textBox = new TextBox();
            start_session_button = new Button();
            ((System.ComponentModel.ISupportInitialize)product_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // dialog
            // 
            dialog.AutoSize = true;
            dialog.Location = new Point(75, 28);
            dialog.Name = "dialog";
            dialog.Size = new Size(440, 40);
            dialog.TabIndex = 0;
            dialog.Text = "Добро пожаловать в магазин! Выберите категорию и товары\r\n\r\n";
            // 
            // product_listView
            // 
            product_listView.Location = new Point(75, 343);
            product_listView.Name = "product_listView";
            product_listView.Size = new Size(296, 311);
            product_listView.TabIndex = 1;
            product_listView.UseCompatibleStateImageBehavior = false;
            product_listView.View = View.Details;
            product_listView.SelectedIndexChanged += product_listView_SelectedIndexChanged;
            // 
            // products_label
            // 
            products_label.AutoSize = true;
            products_label.Location = new Point(75, 320);
            products_label.Name = "products_label";
            products_label.Size = new Size(120, 20);
            products_label.TabIndex = 2;
            products_label.Text = "Список товаров";
            // 
            // categories_listBox
            // 
            categories_listBox.FormattingEnabled = true;
            categories_listBox.ItemHeight = 20;
            categories_listBox.Location = new Point(75, 143);
            categories_listBox.Name = "categories_listBox";
            categories_listBox.Size = new Size(221, 144);
            categories_listBox.TabIndex = 3;
            categories_listBox.SelectedIndexChanged += categories_listBox_SelectedIndexChanged;
            // 
            // categories_label
            // 
            categories_label.AutoSize = true;
            categories_label.Location = new Point(75, 120);
            categories_label.Name = "categories_label";
            categories_label.Size = new Size(82, 20);
            categories_label.TabIndex = 4;
            categories_label.Text = "Категории";
            // 
            // product_pictureBox
            // 
            product_pictureBox.Location = new Point(403, 343);
            product_pictureBox.Name = "product_pictureBox";
            product_pictureBox.Size = new Size(229, 135);
            product_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            product_pictureBox.TabIndex = 5;
            product_pictureBox.TabStop = false;
            // 
            // product_richTextBox
            // 
            product_richTextBox.Location = new Point(403, 485);
            product_richTextBox.Name = "product_richTextBox";
            product_richTextBox.ReadOnly = true;
            product_richTextBox.Size = new Size(229, 109);
            product_richTextBox.TabIndex = 6;
            product_richTextBox.Text = "";
            // 
            // product_label
            // 
            product_label.AutoSize = true;
            product_label.Location = new Point(403, 321);
            product_label.Name = "product_label";
            product_label.Size = new Size(125, 20);
            product_label.TabIndex = 7;
            product_label.Text = "Карточка товара";
            // 
            // product_add_button
            // 
            product_add_button.Location = new Point(403, 600);
            product_add_button.Name = "product_add_button";
            product_add_button.Size = new Size(229, 54);
            product_add_button.TabIndex = 8;
            product_add_button.Text = "Добавить в корзину";
            product_add_button.UseVisualStyleBackColor = true;
            product_add_button.Click += product_add_button_Click;
            // 
            // cart_label
            // 
            cart_label.AutoSize = true;
            cart_label.Location = new Point(677, 120);
            cart_label.Name = "cart_label";
            cart_label.Size = new Size(69, 20);
            cart_label.TabIndex = 10;
            cart_label.Text = "Корзина";
            // 
            // cart_listBox
            // 
            cart_listBox.FormattingEnabled = true;
            cart_listBox.ItemHeight = 20;
            cart_listBox.Location = new Point(677, 143);
            cart_listBox.Name = "cart_listBox";
            cart_listBox.Size = new Size(229, 144);
            cart_listBox.TabIndex = 11;
            // 
            // cart_delete_button
            // 
            cart_delete_button.Location = new Point(927, 187);
            cart_delete_button.Name = "cart_delete_button";
            cart_delete_button.Size = new Size(179, 47);
            cart_delete_button.TabIndex = 12;
            cart_delete_button.Text = "Выложить товар";
            cart_delete_button.UseVisualStyleBackColor = true;
            cart_delete_button.Click += cart_delete_button_Click;
            // 
            // cart_clear_button
            // 
            cart_clear_button.Location = new Point(927, 240);
            cart_clear_button.Name = "cart_clear_button";
            cart_clear_button.Size = new Size(179, 47);
            cart_clear_button.TabIndex = 13;
            cart_clear_button.Text = "Очистить корзину";
            cart_clear_button.UseVisualStyleBackColor = true;
            cart_clear_button.Click += cart_clear_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(677, 320);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 14;
            label1.Text = "Касса";
            // 
            // payment_variants_label
            // 
            payment_variants_label.AutoSize = true;
            payment_variants_label.Location = new Point(677, 356);
            payment_variants_label.Name = "payment_variants_label";
            payment_variants_label.Size = new Size(133, 20);
            payment_variants_label.TabIndex = 15;
            payment_variants_label.Text = "Варианты оплаты";
            // 
            // payment_variants_listBox
            // 
            payment_variants_listBox.FormattingEnabled = true;
            payment_variants_listBox.ItemHeight = 20;
            payment_variants_listBox.Location = new Point(677, 379);
            payment_variants_listBox.Name = "payment_variants_listBox";
            payment_variants_listBox.Size = new Size(229, 104);
            payment_variants_listBox.TabIndex = 16;
            // 
            // payment_buy_button
            // 
            payment_buy_button.Location = new Point(927, 425);
            payment_buy_button.Name = "payment_buy_button";
            payment_buy_button.Size = new Size(179, 58);
            payment_buy_button.TabIndex = 17;
            payment_buy_button.Text = "Оплатить";
            payment_buy_button.UseVisualStyleBackColor = true;
            payment_buy_button.Click += payment_buy_button_Click;
            // 
            // payment_textBox
            // 
            payment_textBox.Location = new Point(927, 379);
            payment_textBox.Name = "payment_textBox";
            payment_textBox.ReadOnly = true;
            payment_textBox.Size = new Size(179, 27);
            payment_textBox.TabIndex = 18;
            // 
            // sum_label
            // 
            sum_label.AutoSize = true;
            sum_label.Location = new Point(927, 356);
            sum_label.Name = "sum_label";
            sum_label.Size = new Size(73, 20);
            sum_label.TabIndex = 19;
            sum_label.Text = "К оплате:";
            // 
            // wallet_label
            // 
            wallet_label.AutoSize = true;
            wallet_label.Location = new Point(676, 28);
            wallet_label.Name = "wallet_label";
            wallet_label.Size = new Size(70, 20);
            wallet_label.TabIndex = 20;
            wallet_label.Text = "Кошелек";
            // 
            // wallet_cash
            // 
            wallet_cash.AutoSize = true;
            wallet_cash.Location = new Point(852, 57);
            wallet_cash.Name = "wallet_cash";
            wallet_cash.Size = new Size(81, 20);
            wallet_cash.TabIndex = 21;
            wallet_cash.Text = "Наличные";
            // 
            // cash_textBox
            // 
            cash_textBox.Location = new Point(852, 80);
            cash_textBox.Name = "cash_textBox";
            cash_textBox.ReadOnly = true;
            cash_textBox.Size = new Size(133, 27);
            cash_textBox.TabIndex = 22;
            // 
            // card_label
            // 
            card_label.AutoSize = true;
            card_label.Location = new Point(675, 57);
            card_label.Name = "card_label";
            card_label.Size = new Size(49, 20);
            card_label.TabIndex = 23;
            card_label.Text = "Карта";
            // 
            // card_textBox
            // 
            card_textBox.Location = new Point(675, 80);
            card_textBox.Name = "card_textBox";
            card_textBox.ReadOnly = true;
            card_textBox.Size = new Size(135, 27);
            card_textBox.TabIndex = 24;
            // 
            // start_session_button
            // 
            start_session_button.Location = new Point(75, 64);
            start_session_button.Name = "start_session_button";
            start_session_button.Size = new Size(182, 43);
            start_session_button.TabIndex = 25;
            start_session_button.Text = "Я - новый покупатель";
            start_session_button.UseVisualStyleBackColor = true;
            start_session_button.Click += start_session_button_Click;
            // 
            // shopView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 756);
            Controls.Add(start_session_button);
            Controls.Add(card_textBox);
            Controls.Add(card_label);
            Controls.Add(cash_textBox);
            Controls.Add(wallet_cash);
            Controls.Add(wallet_label);
            Controls.Add(sum_label);
            Controls.Add(payment_textBox);
            Controls.Add(payment_buy_button);
            Controls.Add(payment_variants_listBox);
            Controls.Add(payment_variants_label);
            Controls.Add(label1);
            Controls.Add(cart_clear_button);
            Controls.Add(cart_delete_button);
            Controls.Add(cart_listBox);
            Controls.Add(cart_label);
            Controls.Add(product_add_button);
            Controls.Add(product_label);
            Controls.Add(product_richTextBox);
            Controls.Add(product_pictureBox);
            Controls.Add(categories_label);
            Controls.Add(categories_listBox);
            Controls.Add(products_label);
            Controls.Add(product_listView);
            Controls.Add(dialog);
            Name = "shopView";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)product_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dialog;
        private ListView product_listView;
        private Label products_label;
        private ListBox categories_listBox;
        private Label categories_label;
        private PictureBox product_pictureBox;
        private RichTextBox product_richTextBox;
        private Label product_label;
        private Button product_add_button;
        private Label cart_label;
        private ListBox cart_listBox;
        private Button cart_delete_button;
        private Button cart_clear_button;
        private Label label1;
        private Label payment_variants_label;
        private ListBox payment_variants_listBox;
        private Button payment_buy_button;
        private TextBox payment_textBox;
        private Label sum_label;
        private Label wallet_label;
        private Label wallet_cash;
        private TextBox cash_textBox;
        private Label card_label;
        private TextBox card_textBox;
        private Button start_session_button;
    }
}