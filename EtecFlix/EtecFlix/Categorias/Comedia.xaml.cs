using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("EtecFlix.Img.comedia.png");
            btnSeBeberNaoCase.Source = ImageSource.FromResource("EtecFlix.Posters.sebebernaocase.jpg");
            btnMeninasMalvadas.Source = ImageSource.FromResource("EtecFlix.Posters.meninasmalvadas.jpg");
            btnViagem2.Source = ImageSource.FromResource("EtecFlix.Posters.viagem2.jpg");
        }
    }
}