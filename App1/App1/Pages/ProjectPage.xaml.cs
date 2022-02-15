using App1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.SQLITE;


namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectPage : ContentPage
    {
       
        public List<string> Projects { get; set; }
        public ProjectPage()
        {
            InitializeComponent();
            
        }
        private void UpdateList()
        {
            lwProject.ItemsSource = App.Db.GetItems();
        }
        protected override void OnAppearing()
        {
            lwProject.ItemsSource = App.Db.GetItems();
            base.OnAppearing();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProjectPage());
        }

        private async void AddProject_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProjectPage());
        }

       

        private async void lwProject_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Project selectedProject = (Project)e.SelectedItem;
            TabsPage selectedProjectPage = new TabsPage();
            selectedProjectPage.BindingContext = selectedProject;
            await Navigation.PushAsync(selectedProjectPage);
        }
    }
}