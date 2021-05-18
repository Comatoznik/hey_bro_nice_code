using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Submit_Clicked(object sender, EventArgs e)
        {
            try
            {
                float a = Convert.ToSingle(First.Text);
                float b = Convert.ToSingle(Second.Text);

                float result = a * b;

                Page1 secondpage = new Page1();
                Navigation.PushAsync(secondpage);
                secondpage.Calculator(a,b,result);
            }
            catch (FormatException)
            {
                DisplayAlert("Ошибка", "Ошибка введенных данных!", "Ввести заново");
                
            }
            

        }
    }
   
    }

    
