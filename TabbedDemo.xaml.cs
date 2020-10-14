using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwasemApp9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedDemo : TabbedPage
    {

        public TabbedDemo()
        {
            InitializeComponent();
            images.Source = ImageSource.FromUri(new Uri("https://pbs.twimg.com/profile_images/1229464423770787840/yLXLXE-0_400x400.jpg"));
        }

    }
}