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
    public partial class TabsPage : TabbedPage
    {
        public TabsPage()
        {
            InitializeComponent();
        }

        

        private async void Edit_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            EditProjectPage projectPage = new EditProjectPage();
            projectPage.BindingContext = project;
            await Navigation.PushAsync(projectPage);
        }
    }
}