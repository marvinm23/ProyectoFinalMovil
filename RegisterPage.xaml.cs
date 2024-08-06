using Xamarin.Forms;

namespace YourAppNamespace
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;

            if (password != confirmPassword)
            {
                await DisplayAlert("Error", "Las contrase�as no coinciden", "OK");
                return;
            }

            // Aqu� puedes agregar la l�gica de registro
            bool isRegistered = RegisterUser(username, password);

            if (isRegistered)
            {
                await DisplayAlert("Registro", "Registro exitoso", "OK");
                await Navigation.PopAsync(); // Vuelve a la p�gina de login
            }
            else
            {
                await DisplayAlert("Error", "No se pudo completar el registro", "OK");
            }
        }

        private bool RegisterUser(string username, string password)
        {
            // Implementa tu l�gica de registro aqu� (por ejemplo, guardar el usuario en una base de datos)
            return true; // Devuelve true si el registro fue exitoso
        }
    }
}
