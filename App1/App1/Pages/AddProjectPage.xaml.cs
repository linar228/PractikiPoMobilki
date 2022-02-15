using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Pages;
using App1.SQLITE;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProjectPage : ContentPage
    {
        public AddProjectPage()
        {
            InitializeComponent();
        }

        private async void BRemove_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void BAddProjece_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите добавить {PName.Text}?", "Да", "Нет");
            if (result == true)
            {
                Project project = new Project();
                project.Name = PName.Text;
                project.PTitle = Title.Text;
                project.Email = Email.Text;
                project.Phone = PhoneOne.Text;
                project.Address = Address.Text;
                App.Db.SaveItem(project);
                Navigation.PopAsync();
            }
        }
    }
}