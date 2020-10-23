using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace UTF2_EJER8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = nombreTextBlock;
            ApellidosTextBox.Tag = apellidosTexBlock;
        }

        private void avisoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBlock mensaje = (sender as TextBox).Tag as TextBlock;

            if (e.Key == Key.F1)
            { 
                if (mensaje.Opacity==0)
                    mensaje.Opacity = 1;
                else             
                    mensaje.Opacity = 0;
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
