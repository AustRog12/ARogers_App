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
        public ObservableCollection<Skill> Skills { get; set; }
        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<Skill>();
            this.Skills.Add(new Skill { Name = "C# Coding", Description = "Mobile development with Xamarin forms" });
            this.Skills.Add(new Skill { Name = "Speaking", Description = "Public Speaking" });

            skillsListView.ItemsSource = this.Skills;
		}

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public class Skill
        {

            public string Name { get; set; }
            public string Description { get; set; }

        }
    }
}