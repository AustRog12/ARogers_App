using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ARogers_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactMe : ContentPage
	{
		public ContactMe ()
		{
			InitializeComponent ();
		}

        private void Button_OnClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text))
            {
                DisplayAlert("Error", "Please Enter Name", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Error", "Please Enter Email", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(messageEditor.Text))
            {
                DisplayAlert("Error", "Please Enter Message", "Ok");
                return;
            }
            DisplayAlert("Success!", "Thank you for your time", "Ok");
        }
    }
}