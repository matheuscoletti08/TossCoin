namespace Prova
{
    public partial class MainPage : ContentPage
    {
        int randomSide = 0;

        public MainPage()
        {
            InitializeComponent();
            SidesPicker.SelectedIndex = 0;
        }
        private void CoinButton(object sender, EventArgs e)
        {
            
            Random sideDraw = new Random();
            randomSide = sideDraw.Next(0, 3);
            
            if (randomSide % 2 == 0)
            {
                ResultLabel.Text = "Cara";
                CoinResult.Source = ImageSource.FromFile("cara.png");
            }
            else 
            { 
                ResultLabel.Text = "Coroa";
                CoinResult.Source = ImageSource.FromFile("coroa.png");
            }

        }
    }

}
