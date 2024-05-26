using System;
using System.Collections.Generic;
using System.Drawing;

namespace WinFormApp1.library
{
    class Product
    {
        public string category { get; set; }
        public string description { get; set; }
        public Image picture { get; set; }
        public int price { get; set; }

        public override string ToString()
        {
            return this.description;
        }
    }

}
