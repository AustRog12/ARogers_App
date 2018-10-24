using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ARogers_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SkillsPage : ContentPage
	{
        public ObservableCollection<string> Skills { get; set; }
		public SkillsPage ()
		{
			InitializeComponent ();

            this.Skills = new ObservableCollection<string>();

		}

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            this.Skills.Add(skillEntry.Text);

            skillEntry.Text = "";

            skillsListView.ItemsSource = this.Skills;
        }
    }
}