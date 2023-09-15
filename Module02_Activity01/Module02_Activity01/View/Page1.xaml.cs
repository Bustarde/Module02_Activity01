using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Module02_Activity01.ViewModel;

namespace Module02_Activity01.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    // Add 'using (project name).ViewModel;
    // Add BindingContext = new TaskViewModel();
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new TaskViewModel();
        }
    }
}