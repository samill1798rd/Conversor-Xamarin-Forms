
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menuprincipal : ContentPage
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void btniniciar_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Convertir());
        }
    }

}