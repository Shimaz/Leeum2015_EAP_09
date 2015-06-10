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
    /// Interaction logic for SceneDetail.xaml
    /// </summary>
    public partial class SceneDetail : UserControl
    {

        
        private int detailLang;
        private int ShowingImageNumber;
        public SceneDetail(int lang, int imgNo)
        {
            InitializeComponent();
            this.detailLang = lang;
            this.ShowingImageNumber = imgNo;


            InitContent(detailLang, ShowingImageNumber);

        }


        private void InitContent(int lang, int imgNo)
        {
            TextBlock tmpTb = new TextBlock();
            tmpTb.FontSize = 50;
            tmpTb.Foreground = Brushes.White;
            Canvas.SetTop(tmpTb, 800);
            Canvas.SetLeft(tmpTb, 520);

            tmpTb.Text = "" + imgNo;



            _cvBaseDetail.Children.Add(tmpTb);


            Button btnTmp = new Button();
            btnTmp.Content = "close";
            btnTmp.Click += new RoutedEventHandler(btnCloseClicked);

            btnTmp.Width = 200;
            btnTmp.Height = 200;

            Canvas.SetTop(btnTmp, 50);
            Canvas.SetLeft(btnTmp, 50);

            _cvBaseDetail.Children.Add(btnTmp);



        }


        private void showNextImg(object sender, RoutedEventArgs e)
        {



        }

        private void showPrevImg(object sender, RoutedEventArgs e)
        {


        }

        


        private void setLanguage(int lang)
        {


        }

        private void btnCloseClicked(object sender, RoutedEventArgs e)
        {
            ((Canvas)this.Parent).Children.Remove(this);

        }
    }



}
