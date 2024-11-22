using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void OnAddEducationClicked(object sender, EventArgs e)
        {
            var educationStack = new StackLayout
            {
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label { Text = "Grado:", WidthRequest = 120, FontSize = 18 },
                            new Entry { Placeholder = "Ingrese su grado", HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = 16 }
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label { Text = "Institución:", WidthRequest = 120, FontSize = 18 },
                            new Entry { Placeholder = "Ingrese su institución", HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = 16 }
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label { Text = "Año:", WidthRequest = 120, FontSize = 18 },
                            new Entry { Placeholder = "Ingrese el año de graduación", Keyboard = Keyboard.Numeric, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = 16 }
                        }
                    }
                }
            };

            SeccionFormacion.Children.Add(educationStack);
        }

        private void OnAddWorkExperienceClicked(object sender, EventArgs e)
        {
            var workExperienceStack = new StackLayout
            {
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label { Text = "Empresa:", WidthRequest = 120, FontSize = 18 },
                            new Entry { Placeholder = "Ingrese el nombre de la empresa", HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = 16 }
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label { Text = "Puesto:", WidthRequest = 120, FontSize = 18 },
                            new Entry { Placeholder = "Ingrese su puesto", HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = 16 }
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label { Text = "Años:", WidthRequest = 120, FontSize = 18 },
                            new Entry { Placeholder = "Ingrese los años trabajados", HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = 16 }
                        }
                    }
                }
            };

            SeccionExperienciaLaboral.Children.Add(workExperienceStack);
        }

        private void OnAddSkillClicked(object sender, EventArgs e)
        {
            var skillStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new CheckBox(),
                    new Entry { Placeholder = "Ingrese habilidad", HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = 16 }
                }
            };

            SeccionHabilidades.Children.Add(skillStack);
        }


        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;
            string correo = CorreoEntry.Text;
            string telefono = TelefonoEntry.Text;
            string direccion = DireccionEntry.Text;
            string perfil = PerfilEditor.Text;

            var formacion = SeccionFormacion;
            var experienciaLaboral = SeccionExperienciaLaboral;
            var habilidades = SeccionHabilidades;

            var cvPreviewPage = new CvPreviewPage(nombre, correo, telefono, direccion, perfil, formacion, experienciaLaboral, habilidades);
            Navigation.PushAsync(cvPreviewPage);
        }
    }
}