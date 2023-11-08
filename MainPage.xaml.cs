namespace RegistroEstudiante
{
    public partial class MainPage : ContentPage
    {
         private  string titulo = "Registro";
        public Estudiante MiEstudiante { get; set; }

        public MainPage()
        {
            InitializeComponent();
            MiEstudiante = new Estudiante();

            BindingContext = MiEstudiante;

        }

        private void ConfirmarBtn_Clicked(object sender, EventArgs e)
        {
            // DisplayAlert("Registro", MiEstudiante.Nombres +
            //    " sus datos se ingresaron correctamente.", "Ok");

            if (IsValid() ==true)
            {
                var mensaje = $"{MiEstudiante.Nombres} sus datos se ingresaron correctamente";
                string titulo = "Registro";
                DisplayAlert(titulo, mensaje, "ok");
            }
        }
         private bool IsValid()
        {
            
            if (string.IsNullOrEmpty (MiEstudiante.Nombres)) 
            { 
                DisplayAlert(titulo, "Debe Ingresar los Nombres", "ok");
                    return false;
            }
            if (string.IsNullOrEmpty(MiEstudiante.Apellidos))
            {
                DisplayAlert(titulo, "Debe Ingresar los Apellidos", "ok");
                return false;
            }
            if (string.IsNullOrEmpty(MiEstudiante.Materia))
            {
                DisplayAlert(titulo, "Debe Ingresar la Materia", "ok");
                return false;
            }
            return true;

        }
    }
}