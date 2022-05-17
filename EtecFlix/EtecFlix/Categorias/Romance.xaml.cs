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
    public partial class Romance : ContentPage
    {
        public Romance()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("EtecFlix.Img.logo_romance.png");
            btnCincoPassos.Source = ImageSource.FromResource("EtecFlix.Posters.cinco_passos.jpg");
            btnSimplesmenteAcontece.Source = ImageSource.FromResource("EtecFlix.Posters.simplesmenteacontece.jpg");
        }
    }
}