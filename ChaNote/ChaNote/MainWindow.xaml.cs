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
        
        public MainWindow()
        {
            InitializeComponent();

        }
        // 在窗口关闭时自动保存笔记
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            // 保存窗口位置
            Properties.Settings.Default.WindowPosition = new System.Drawing.Point((int)this.Left, (int)this.Top);
            Properties.Settings.Default.Save();

        }

       

       
       

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
