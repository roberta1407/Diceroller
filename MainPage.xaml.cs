using System;
using Microsoft.Maui.Controls;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RollButton_Clicked(object sender, EventArgs e)
        {
            int picker = DicePicker.SelectedIndex == 0 ? 6 : 10;
            int result = new Random().Next(1, picker + 1);
            ResultLabel.Text = $"Rolando: {result}";
        }
    }
}

