using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Leeum2015_EAP_09
{
    /// <summary>
    /// Interaction logic for SceneHome.xaml
    /// </summary>
    public partial class SceneHome : UserControl
    {

        private int lang_detail;

        public SceneHome(int lang)
        {
            InitializeComponent();

            this.lang_detail = lang;

            InitContents(lang_detail);
        }

        private void InitContents(int lang)
        {




        }


        private void btnClicked(object sender, RoutedEventArgs e)
        {



        }
    }
}
