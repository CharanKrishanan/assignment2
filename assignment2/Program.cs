using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Program
    {
        
    static void Main(string[] args)
      {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

            }

            Console.WriteLine(sum);

            Product[] product = new Product[5];


            //Product product1 = new Product
            product[0] = new Product
            {
                
                _productname = "Widget",
                _productprice = 10.99m,
                _unitofmeasure = "Each",
                _qty = 100
            };
            //Product product2 = new Product
            product[1] = new Product
            {
                
                _productname = "Gadget",
                _productprice = 19.99m,
                _unitofmeasure = "Piece",
                _qty = 50
            };

            //Product product3 = new Product
            product[2] = new Product
            {
                
                _productname = "Tool",
                _productprice = 7.49m,
                _unitofmeasure = "Each",
                _qty = 75
            };

            //Product product4 = new Product
            product[3] = new Product
            {
                
                _productname = "Appliance",
                _productprice = 299.99m,
                _unitofmeasure = "Piece",
                _qty = 20
            };

            //Product product5 = new Product
            product[4] = new Product
            {
                
                _productname = "Accessory",
                _productprice = 4.99m,
                _unitofmeasure = "Each",
                _qty = 200
            };
            for (int i = 0; i < product.Length; i++)
            {

                Console.WriteLine($"Product ID: {product[i]._productid}");
                Console.WriteLine($"Product Name: {product[i]._productname}");
                Console.WriteLine($"Productprice: ${product[i]._productprice}");
                Console.WriteLine($"Unit of Measurement: {product[i]._unitofmeasure}");
                Console.WriteLine($"Quantity: {product[i]._qty}");
            }

            //Console.WriteLine("---------");

            //Console.WriteLine($"Product ID: {product1._productid}");
            //Console.WriteLine($"Product Name: {product1._productname}");
            //Console.WriteLine($"Productprice: ${product1._productprice}");
            //Console.WriteLine($"Unit of Measurement: {product1._unitofmeasure}");
            //Console.WriteLine($"Quantity: {product1._qty}");
            //Console.WriteLine("--------------------------");

            //Console.WriteLine($"Product ID: {product2._productid}");
            //Console.WriteLine($"Product Name: {product2._productname}");
            //Console.WriteLine($"Productprice: ${product2._productprice}");
            //Console.WriteLine($"Unit of Measurement: {product2._unitofmeasure}");
            //Console.WriteLine($"Quantity: {product2._qty}");
            //Console.WriteLine("--------------------------");

            //Console.WriteLine($"Product ID: {product3._productid}");
            //Console.WriteLine($"Product Name: {product3._productname}");
            //Console.WriteLine($"Productprice: ${product3._productprice}");
            //Console.WriteLine($"Unit of Measurement: {product3._unitofmeasure}");
            //Console.WriteLine($"Quantity: {product3._qty}");
            //Console.WriteLine("--------------------------");

            //Console.WriteLine($"Product ID: {product4._productid}");
            //Console.WriteLine($"Product Name: {product4._productname}");
            //Console.WriteLine($"Productprice: ${product4._productprice}");
            //Console.WriteLine($"Unit of Measurement: {product4._unitofmeasure}");
            //Console.WriteLine($"Quantity: {product4._qty}");
            //Console.WriteLine("--------------------------");

            //Console.WriteLine($"Product ID: {product5._productid}");
            //Console.WriteLine($"Product Name: {product5._productname}");
            //Console.WriteLine($"Productprice: ${product5._productprice}");
            //Console.WriteLine($"Unit of Measurement: {product5._unitofmeasure}");
            //Console.WriteLine($"Quantity: {product5._qty}");
            Console.Read();


        }
    }
}
