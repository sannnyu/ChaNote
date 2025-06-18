using System;
using System.Collections.Generic;
using System.IO;
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

namespace ChaNote
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
<<<<<<< HEAD
        public MainWindow()
        {
            InitializeComponent();
=======
        
        public MainWindow()
        {
            InitializeComponent();

>>>>>>> loving
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
<<<<<<< HEAD
            // 保存窗口位置
            Properties.Settings.Default.WindowPosition = new System.Drawing.Point((int)this.Left, (int)this.Top);
            Properties.Settings.Default.Save();
        }
        // Handle window drag
        private void TitleBar_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
=======

            // 保存窗口位置
            Properties.Settings.Default.WindowPosition = new System.Drawing.Point((int)this.Left, (int)this.Top);
            Properties.Settings.Default.Save();

        }

       

       
       

>>>>>>> loving
        // 监听按键事件，按下Esc键时关闭窗口
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close(); // 按下Esc键时关闭窗口
        }
        }
    }
}
