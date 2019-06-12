using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DefuseBomb
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1, 4).ToString();
        static int scores = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        async void ButtonClicked(object sender, EventArgs e) {
            Button button = sender as Button;

            //Game Over
            if (button.Text == bomb)
            {
                await DisplayAlert("Bomb Exploded", "GAME OVER", "Retry");
                bomb = new Random().Next(1, 4).ToString();
                scores = 0;
            }
            else {
                scores += 1;
                await DisplayAlert("Bomb Defused!", "Scores:" + scores, "Continue");
                bomb = new Random().Next(1, 4).ToString();

            }
        }
    }
}
