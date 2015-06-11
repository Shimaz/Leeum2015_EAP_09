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
    /// Interaction logic for ImageViewer.xaml
    /// </summary>
    public partial class ImageViewer : UserControl
    {
        public ImageViewer(int imgNo, bool direction)
        {

            // next, previous image 할 때 호출

            InitializeComponent();


            InitContent();
            InitAnimation(direction);

        }

        public ImageViewer(int imgNo)
        {

            // detail scene initialize 할 때 호출

            InitializeComponent();

            InitContent();
            OpenAnimation();

        }


        private void InitContent()
        {
            // 이미지 붙이기 

        }

        private void OpenAnimation()
        {
            // detail scene inatialize 호출. 방향성 없는 애니메이션


        }

        private void InitAnimation(bool dir)
        {




        }


        public void CloseImage(bool dir)
        {

        }

        private void Finish()
        {
            ((Canvas)this.Parent).Children.Remove(this);
        }

    }
}
