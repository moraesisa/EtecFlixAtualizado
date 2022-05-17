using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using EtecFlix.Categorias;

namespace EtecFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("EtecFlix.Img.logo.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async void Btn_Open_Comedia(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Comedia());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }
        private async void Btn_Open_Romance(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Romance());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }
        private async void Btn_Open_Acao(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Acao());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

    }
}
