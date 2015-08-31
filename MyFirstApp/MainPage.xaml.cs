using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PassingDataInNavigation
{
    public sealed partial class MainPage : Page
    {
        Datos myData = new Datos();
        public MainPage()
        {
            InitializeComponent();           
        }

        private void btn_Avanzar_Click(object sender, RoutedEventArgs e)
        {
            myData.myName = tb_Name.Text;
            myData.myLastName = tb_LastName.Text;
            Frame.Navigate(typeof(Page2), myData);
        }
    }
}
