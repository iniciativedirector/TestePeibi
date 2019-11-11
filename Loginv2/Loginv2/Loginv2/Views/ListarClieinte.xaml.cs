using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loginv2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Loginv2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarClieinte : ContentPage
    {
        public ListarClieinte()
        {
            InitializeComponent();
        }

        internal static List<Cliente> ItemsSource { get; set; }

      
    }
}