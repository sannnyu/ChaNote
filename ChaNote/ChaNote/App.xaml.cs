using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace ChaNote
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
<<<<<<< HEAD
=======



>>>>>>> loving
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // 恢复窗口位置
            if (ChaNote.Properties.Settings.Default.WindowPosition != System.Drawing.Point.Empty)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Left = ChaNote.Properties.Settings.Default.WindowPosition.X;
                mainWindow.Top = ChaNote.Properties.Settings.Default.WindowPosition.Y;
                mainWindow.Show();
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Left = 0;
                mainWindow.Top = 0;
                mainWindow.Show();

            }
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            // 保存窗口位置
            if (MainWindow != null)
            {
                ChaNote.Properties.Settings.Default.WindowPosition = new System.Drawing.Point((int)MainWindow.Left, (int)MainWindow.Top);
                ChaNote.Properties.Settings.Default.Save();
            }
        }
<<<<<<< HEAD
=======

>>>>>>> loving
    }
}
