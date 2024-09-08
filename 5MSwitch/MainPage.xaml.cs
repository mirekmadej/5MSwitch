namespace _5MSwitch
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void onSwitchToggled(object sender, EventArgs e)
        {
            if (swToggler.IsToggled)
                lblStan.Text = "stan przełącznika: włączony";
            else
                lblStan.Text = "stan przełącznika: wyłączony";
        }


    }

}
