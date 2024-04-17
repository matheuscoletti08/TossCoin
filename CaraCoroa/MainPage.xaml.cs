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
            randomSide = sideDraw.Next(1, 2);
            
            if (randomSide == 1)
            {
                ResultLabel.Text = "Cara";
            }
            else if (randomSide == 2) 
            { 
                ResultLabel.Text = "Coroa"; 
            }

        }
    }

}
