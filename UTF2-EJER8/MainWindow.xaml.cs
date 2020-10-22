using System;
using System.Windows;
using System.Windows.Input;


namespace UTF2_EJER8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void nombreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           

            if (e.Key == Key.F1)
            { 
                if (nombreTextBlock.Opacity==0)
                    nombreTextBlock.Opacity = 1;
                else             
                    nombreTextBlock.Opacity = 0;
            }
        }
        private void apellidosTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if (apellidosTexBlock.Opacity == 0)
                    apellidosTexBlock.Opacity = 1;
                else
                    apellidosTexBlock.Opacity = 0;
            }
        }
        private void edadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                try
                {
                    Convert.ToInt32(edadTextBox.Text);
                    edadTextBlock.Opacity = 0;
                }
                catch
                {
                    edadTextBlock.Opacity = 1;
                }
            }
        }
    }
}
