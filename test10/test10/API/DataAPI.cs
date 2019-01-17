using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace test10
{
    public class DataAPI
    {
        public IList<Product> getProducts()
        {
            using (var webClient = new WebClient())
            {
                IList<Product> product=null;
                try
                {
                    String json = webClient.DownloadString("https://fulda-buyandsell.herokuapp.com/api/products");
                    ProductsApi data = JsonConvert.DeserializeObject<ProductsApi>(json);

                   product = data.Product;
                    return product;
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
                return product;
            }
        }
    }
}