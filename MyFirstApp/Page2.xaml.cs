using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace PassingDataInNavigation
{ 
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Datos passedData = e.Parameter as Datos;
            string myName = passedData.myName;
            string myLastName = passedData.myLastName;

            if (!string.IsNullOrWhiteSpace(myName)) 
            {
                tb_passedName.Text = "Bien hecho! " + myName;
                tb_passedLastName.Text = myLastName;
            }
            else
            {
                tb_passedName.Text = "Algo malo pasó :( inténtalo de nuevo!";
                tb_passedLastName.Text = "No ingresaste apellido :(";
            }
        }

        private void btn_Volver_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
