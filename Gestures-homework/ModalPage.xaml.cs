using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gestures_homework
{
public partial class ModalPage : ContentPage
{
    public ModalPage(object sender)
    {
        InitializeComponent();
            var image = (Image)sender;
            img.Source = image.Source;
    }
        void OnPinched(object sender, PinchGestureUpdatedEventArgs e)
        {
            this.Navigation.PopModalAsync();
        }

    }
}