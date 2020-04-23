using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Carrossel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}

        private void MudarPagina(object sender, EventArgs args)
        {
            //Chamando a pagina1 dentro da pasta navegação, colocando essas paginas dentro de um navigation e mudando a cor da barra de navegação
            //App.Current.MainPage = new NavigationPage(new Navegação.Pagina1()) { BarBackgroundColor= Color.Red };

            App.Current.MainPage = new Tabbed.Abas();
        }
	}
}