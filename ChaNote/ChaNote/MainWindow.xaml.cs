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
        
        private string filePath = "./note.txt"; // 笔记保存的文件路径
        public MainWindow()
        {
            InitializeComponent();
            // 获取当前屏幕的宽度和高度
            var screenWidth = SystemParameters.PrimaryScreenWidth;
            var screenHeight = SystemParameters.PrimaryScreenHeight;

            // 设置窗口位置在右上角
            this.Left = screenWidth - this.Width - 30; // 将窗口的左边设置在屏幕的右边缘
            this.Top = 30; // 将窗口的顶部设置在屏幕的顶端
            //LoadNote(); // 启动时加载笔记
        }
       


        // 在窗口关闭时自动保存笔记
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //SaveNote(); // 关闭窗口前保存笔记
        }

        // 保存笔记到文件
        private void SaveNote()
        {
            File.WriteAllText(filePath, NoteTextBox.Text);
        }


        // Handle window drag
        private void TitleBar_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
         // ToggleButton event handlers
        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ToggleButton is checked!");
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ToggleButton is unchecked!");
        }
        // 加载笔记内容
        private void LoadNote()
        {
            if (File.Exists(filePath))
            {
                NoteTextBox.Text = File.ReadAllText(filePath);
            }
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
