namespace RegistroEstudiante
{
    public partial class MainPage : ContentPage
    {
        public Estudiante MiEstudiante { get; set; }

        public MainPage()
        {
            InitializeComponent();
            MiEstudiante = new Estudiante();

            BindingContext = MiEstudiante;

        }

        private void ConfirmarBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Registro",
                MiEstudiante.Nombres +
                " sus datos se ingresaron correctamente.", "Ok");

        }
    }
}