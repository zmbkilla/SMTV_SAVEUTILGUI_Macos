using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Reactive.Subjects;

namespace SMTV_SAVEUTILGUI
{
    public partial class MainWindow : Window
    {

        string pathsave = "";
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private async void onbtn1clickk(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            var getpath = await ofd.ShowAsync(this);

            if (getpath != null)
            {
                pathsave =  getpath[0];

                SaveCrypt.CryptFile(getpath[0]);
                
            }

            this.Get<TextBlock>("txt1").Text = pathsave;
            
        }

    }
}