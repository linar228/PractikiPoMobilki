using App1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectPage : ContentPage
    {
        public List<string> Projects { get; set; }
        public ProjectPage()
        {
            InitializeComponent();
            Projects = new List<string>();
            FillList();
            this.BindingContext = this;
        }
        public void FillList()
        {
            for (int i = 0; i < 20; i++)
            {
                Projects.Add($"Проект {i + 1}");
            }
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProjectPage());
        }

        private async void lwProjects_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new TabsPage(lwProjects.SelectedItem.ToString()));
        }
    }
}