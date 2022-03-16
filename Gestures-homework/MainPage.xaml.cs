using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gestures_homework
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            var imagen = (Image)sender;
           await this.Navigation.PushModalAsync(new ModalPage(imagen));
        }
        async void OnTapGestureRecognizerTapped2(object sender, EventArgs args)
        {
            var imagen = (Image)sender;
            await this.Navigation.PushModalAsync(new ModalPage2(imagen));
        }
    }
}
