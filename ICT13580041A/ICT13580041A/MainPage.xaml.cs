using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ICT13580041A
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            okButton.Clicked += OkButton_Clicked;
            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            mySlider.ValueChanged += MySlider_ValueChanged;
            myStepper.ValueChanged += MyStepper_ValueChanged;

        }

         void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }

        void OkButton_Clicked(object sender, EventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;
        }
    }
}
