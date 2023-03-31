using ELeaguesProj;
using System;
using System.Xml;
using Xamarin.Forms;
namespace ELeagues
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            var entry = new Entry { Placeholder = "Nick", PlaceholderColor = Color.DarkGreen };
            string txt = entry.Text;

           
        }

        private void Save(object sender, EventArgs e)
        {
            var Nick = "";
            var Pass = "";
            try
            {
                Nick = Convert.ToString(NickName.Text);
                Pass = Convert.ToString(Password.Text);
            }
            catch (FormatException ex)
            {
                Nick = "";
                Pass = "";
            }

            
        }
    }
}
