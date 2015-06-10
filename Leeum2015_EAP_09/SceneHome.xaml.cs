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

        private int lang_home;

        public SceneHome(int lang)
        {
            InitializeComponent();

            this.lang_home = lang;

            InitContents(lang_home);
        }

        private void InitContents(int lang)
        {
            for (int i = 0; i < 11; i++)
            {
                string num = string.Format("{0:00}", i + 1);
                ImageButton btn = new ImageButton();
                btn.NormalImage = new BitmapImage(new Uri("pack://application:,,,/Resources/btn_" + num + "_normal.png"));
                btn.PushedImage = new BitmapImage(new Uri("pack://application:,,,/Resources/btn_" + num + "_pressed.png"));

                if (i < 6)
                {
                    Canvas.SetLeft(btn, 100 + (i * 150));
                    Canvas.SetTop(btn, 1400);


                }
                else
                {
                    Canvas.SetLeft(btn, 100 + (( i - 6) * 150));
                    Canvas.SetTop(btn, 1600);

                }


                btn.Click += new RoutedEventHandler(btnClicked);

                btn.Tag = 100 + i;
                _cvBaseHome.Children.Add(btn);
                
            }



        }


        private void btnClicked(object sender, RoutedEventArgs e)
        {
            int imgNo = (int)((ImageButton)sender).Tag - 100;

            SceneDetail scn = new SceneDetail(lang_home, imgNo);

            Canvas.SetTop(scn, 0);
            Canvas.SetLeft(scn, 0);

            _cvBaseHome.Children.Add(scn);

        }
    }
}
