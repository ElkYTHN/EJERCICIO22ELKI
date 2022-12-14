using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EJERCICIO222ELK.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarFirmas : ContentPage
    {
        public ListarFirmas()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listaFirmas.ItemsSource = await App.BaseDatosObject.GetFirmasList();
        }
    }
}