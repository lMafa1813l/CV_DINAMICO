using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms
{
    public partial class CvPreviewPage : ContentPage
    {
        public CvPreviewPage(string nombre, string correo, string telefono, string direccion, string perfil,
                             StackLayout formacion, StackLayout experienciaLaboral, StackLayout habilidades)
        {
            InitializeComponent();

         
            NombreLabel.Text = $"Nombre: {nombre}";
            CorreoLabel.Text = $"Correo Electrónico: {correo}";
            TelefonoLabel.Text = $"Teléfono: {telefono}";
            DireccionLabel.Text = $"Dirección: {direccion}";
            PerfilLabel.Text = perfil;

            FormacionLayout.Children.Add(CloneStackLayout(formacion));
            ExperienciaLaboralLayout.Children.Add(CloneStackLayout(experienciaLaboral));
            HabilidadesLayout.Children.Add(CloneStackLayout(habilidades));
        }

        private StackLayout CloneStackLayout(StackLayout original)
        {
            var clone = new StackLayout();
            foreach (var child in original.Children)
            {
                if (child is Label label)
                {
                    clone.Children.Add(new Label { Text = label.Text, FontSize = label.FontSize, Margin = label.Margin });
                }
                else if (child is Entry entry)
                {
                    clone.Children.Add(new Entry { Text = entry.Text, Placeholder = entry.Placeholder, FontSize = entry.FontSize });
                }
                else if (child is StackLayout stackLayout)
                {
                    clone.Children.Add(CloneStackLayout(stackLayout));
                }
                
            }
            return clone;
        }
    }
}