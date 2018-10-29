using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ARogers_App
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void aboutMeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMe());
        }

        private void skillsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }

        private void contactMeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactMe());
        }
    }
}
