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


            string Name = "test product";
            string Description = "this is a product for only testing purpose";
            myLabel1.Text = "My first Product";
            myLabel2.Text = "Detail of my first product";

            InitializeComponent();
          
            
           


        }
    }
}
