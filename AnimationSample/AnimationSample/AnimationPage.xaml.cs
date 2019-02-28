using System;
using Xamarin.Forms;

namespace AnimationSample
{
    public partial class AnimationPage : ContentPage
    {

        public AnimationPage()
        {
            InitializeComponent();
        }
        bool b1Visible = true;
        bool b2Visible = true;
        double filterHeight = 150;

        private async void FadeB1_Clicked(object sender, EventArgs e)
        {
            await box1.FadeTo(b1Visible ? 0 : 1);
            b1Visible = !b1Visible;
        }
        private void AniomateHeightB2_Clicked(object sender, EventArgs e)
        {
            Animation animation;
            if (b2Visible)
            {
                animation = new Animation(v => box2.HeightRequest = v, filterHeight, 0, easing: Easing.SinOut);
                box2.Animate("b2", animation);
            }
            else
            {
                animation = new Animation(v => box2.HeightRequest = v, 0, filterHeight, easing: Easing.SinIn);
                box2.Animate("b2", animation);
            }

            b2Visible = !b2Visible;

        }
    }
}
