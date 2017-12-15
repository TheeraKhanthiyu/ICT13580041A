using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580041A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPage2 : ContentPage
    {
        public MyPage2()
        {
            InitializeComponent();
            nextButton.Clicked += NextButton_Clicked;
            backButton.Clicked += BackButton_Clicked;
        }

        

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPage3());
        }
        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}