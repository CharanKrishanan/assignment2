using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Product
    {
        private static int nextProductId = 1;
        public int _productid;
        public string _productname;
        public object _productprice;
        public string _unitofmeasure;
        public int _qty;
       
        public int Productid { get { return _productid; } set { _productid = value; } }
        public string Productname { get { return _productname;} set { _productname = value; } }
        public object Productprice { get { return _productprice; } set { _productprice = value; } }
        public string Unitofmeasurement {  get { return _unitofmeasure;} set {  _unitofmeasure = value; } }
        public int Quantity
        {
            get { return _qty; }
            set { _qty = value; }
        }

        public Product()
        {
            
            _productid = nextProductId;
            nextProductId++; 
        }
    }
}
