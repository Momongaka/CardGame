using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossCardGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeckChoice : ContentPage
    {
        public DeckChoice()
        {
            InitializeComponent();
        }

        private void DrawCard(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}