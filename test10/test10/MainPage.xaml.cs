using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace test10
{
    public partial class MainPage : ContentPage
    {
       
        DataAPI da = new DataAPI();
        public MainPage()
        {

            IList<Product> product = da.getProducts();

            InitializeComponent();

            productDetail.ItemsSource = product;
            //string productName = product[0].Name;
            //string productDescription = product[0].Description;

            //string productName = "Zohaib";
            //string productDescription = "Detail";





        }
    }
}
