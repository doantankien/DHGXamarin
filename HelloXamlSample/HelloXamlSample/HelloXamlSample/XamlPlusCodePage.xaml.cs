using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamlSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XamlPlusCodePage : ContentPage
	{
		public XamlPlusCodePage ()
		{
			InitializeComponent ();
		}

        async void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked!", "Show text button " + button.Text,"OK");
        }

        private void OnSlickerValueChange(object sender, ValueChangedEventArgs e)
        {
            valueLabel.Text = ((Slider)sender).Value.ToString("F3");
        }
    }
}