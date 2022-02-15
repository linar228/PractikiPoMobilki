using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.SQLITE;
using App1.Pages;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProjectPage : ContentPage
    {
        public EditProjectPage()
        {
            InitializeComponent();
        }

        private async void BRemove_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void BAddProjece_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert(" ", $"Вы хотите изменить {project.Name}?", "Изменить", "Отмена"))
            {
                if (!String.IsNullOrEmpty(project.Name))
                {
                    App.Db.SaveItem(project);
                }
                await Navigation.PushAsync(new ProjectPage());
            }
        }

        private async void TEditingProject_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert(" ", $"Вы точно хотите удалить {project.Name}?", "Удалить", "Отмена"))
            {
                App.Db.DeleteItem(project.Id);
                await Navigation.PushAsync(new ProjectPage());
            }
        }
    }
}