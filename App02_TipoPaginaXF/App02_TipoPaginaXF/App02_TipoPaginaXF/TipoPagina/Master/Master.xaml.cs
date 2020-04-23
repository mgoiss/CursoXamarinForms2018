using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();            
		}

        private void MudarPagina1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Navegação.Pagina1() { Title = "Entrou pelo Master" });
            IsPresented = false; //Fechando o menu
        }
        private void MudarPagina2(object sender, EventArgs args)
        {
            Detail = new Navegação.Pagina2();
            IsPresented = false; //Fechando o menu
        }
        private void MudarPagina3(object sender, EventArgs args)
        {
            Detail = new Conteudo();
            IsPresented = false; //Fechando o menu
        }
    }
}