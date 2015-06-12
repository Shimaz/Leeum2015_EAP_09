using System;
using System.Collections.Generic;
using System.Collections;
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

        public EventHandler setLanguageEvent;

        private SceneHome scParent;
        
        private int detailLang;
        private int ShowingImageNumber;

       
        private static int IMG_MAX = 17;
        public SceneDetail(int lang, int imgNo, SceneHome parent)
        {
            InitializeComponent();
            this.detailLang = lang;
            this.ShowingImageNumber = imgNo;
            this.scParent = parent;

            InitContent(detailLang, ShowingImageNumber);

        }


        private void InitContent(int lang, int imgNo)
        {
            //TextBlock tmpTb = new TextBlock();
            _tbTmp.FontSize = 50;
            _tbTmp.Foreground = Brushes.White;
            Canvas.SetTop(_tbTmp, 800);
            Canvas.SetLeft(_tbTmp, 520);

            _tbTmp.Text = "" + imgNo;

            ImageViewer iv = new ImageViewer(ShowingImageNumber, scParent);
            _cvImageViewer.Children.Add(iv);
            //_cvBaseDetail.Children.Add(_tbTmp);


            Button btnClose = new Button();
            btnClose.Content = "HOME";
            btnClose.Click += new RoutedEventHandler(btnCloseClicked);

            btnClose.Width = 100;
            btnClose.Height = 100;

            Canvas.SetTop(btnClose, 1500);
            Canvas.SetLeft(btnClose, 490);

            _cvBaseDetail.Children.Add(btnClose);


            Button btnNext = new Button();
            btnNext.Content = "NEXT";
            btnNext.Click += new RoutedEventHandler(showNextImg);
            

            btnNext.Width = 100;
            btnNext.Height = 100;

            Canvas.SetTop(btnNext, 1500);
            Canvas.SetLeft(btnNext, 620);

            _cvBaseDetail.Children.Add(btnNext);


            Button btnPrev = new Button();
            btnPrev.Content = "PREV";
            btnPrev.Click += new RoutedEventHandler(showPrevImg);

            btnPrev.Width = 100;
            btnPrev.Height = 100;

            Canvas.SetTop(btnPrev, 1500);
            Canvas.SetLeft(btnPrev, 360);

            _cvBaseDetail.Children.Add(btnPrev);
            
            


        }


        private void showNextImg(object sender, RoutedEventArgs e)
        {

            ShowingImageNumber++;
            if (ShowingImageNumber >= IMG_MAX) ShowingImageNumber = 0;

            showImage(GlobalValues.DIR_RIGHT);
        }

        private void showPrevImg(object sender, RoutedEventArgs e)
        {

            ShowingImageNumber--;
            if (ShowingImageNumber < 0) ShowingImageNumber = IMG_MAX - 1;

            showImage(GlobalValues.DIR_LEFT);
        }

        private void showImage(bool direction)
        {
            _tbTmp.Text = "" + ShowingImageNumber;


            //foreach (UserControl child in _cvImageViewer.Children)
            //{
            //    ImageViewer tmp = (ImageViewer)child; // (ImageViewer)child;
            //    if (!tmp.IsClosing) tmp.CloseImage(direction);

            //}


            UIElement ele = null;

            for (int i = 0; i < _cvImageViewer.Children.Count; i++)
            {
                if (((ele = _cvImageViewer.Children[i]) is ImageViewer) && !((ImageViewer)ele).IsClosing)
                {
                    ((ImageViewer)ele).CloseImage(direction);
                }


            }

            ImageViewer iv = new ImageViewer(ShowingImageNumber, direction, scParent);

            _cvImageViewer.Children.Add(iv);


        }
        


        private void setLanguage(int lang)
        {

            if (detailLang == GlobalValues.LANG_KOR)
            {
                detailLang = GlobalValues.LANG_ENG;
                this.Tag = GlobalValues.LANG_ENG;
            }
            else
            {
                detailLang = GlobalValues.LANG_KOR;
                this.Tag = GlobalValues.LANG_KOR;
            }

            /// 컨텐츠 언어 처리 
            /// 

        }

        private void btnCloseClicked(object sender, RoutedEventArgs e)
        {

            /// 현재 scene을 종료하며 home으로 복귀할 때 
            /// home의 언어값을 변경, 컨텐츠 업데이트. 
            languagePassEventMethod();
            ((Canvas)this.Parent).Children.Remove(this);

        }


        protected virtual void languagePassEventMethod()
        {
            if (setLanguageEvent != null)
            {
                setLanguageEvent(this, EventArgs.Empty);
            }

        }
    }



}
