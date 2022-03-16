using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gestures_homework
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ModalPage2 : ContentPage
{
    public ModalPage2(object sender)
    {
        InitializeComponent();
        var image = (Image)sender;
        img.Source = image.Source;
    }
        void OnSwipeGesture(object sender, SwipedEventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
        
}