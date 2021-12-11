using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Create the instance of the product class
            Product product = new Product(productId);

            // Temporary hard-coded values to return
            // a populated product
            if(productId == 4)
            {
                product.ProductName = "Mobile";
                product.ProductDescription = "Legendary Nokia 1200 model";
                product.CurrentPrice = 25.5M;
            }
            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Saves(Product product)
        {
            var success = true;

            if(product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {
                        // Call an instance stored procedure
                    }
                    else
                    {
                        // call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }   
            return success;
        }
    }
}
