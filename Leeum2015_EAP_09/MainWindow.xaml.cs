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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /// 남은 작업
    /// 
    /// 애니메이션 관련
    /// 1. home -> detail, detail -> home 전환 애니메이션 
    /// 2. detail open, closea animation
    /// 3. next image, prev image animation
    /// 
    /// 기능 관련
    /// 1. home 언어 변경 
    /// 2. detail 언어 변경
    /// 3. detail close -> home 언어 전달 및 변경 
    /// 4. detail dispatcher timer ( detail scene 종료 및 한국어로 변경)
    /// 5. home scene dispatcher timer ( 한국어로 언어 변경)
    /// 





    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            SceneHome scHome = new SceneHome(GlobalValues.LANG_KOR);
            Canvas.SetTop(scHome, 0);
            Canvas.SetLeft(scHome, 0);

            _cvBase.Children.Add(scHome);


        }
    }
}
