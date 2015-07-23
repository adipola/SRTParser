using System;
using System.Collections.ObjectModel;
using System.Windows;
using Microsoft.Win32;

namespace SRTParser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ISubtitleData> Subtitles = new ObservableCollection<ISubtitleData>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Create Open File dialog so the user will be able to select an SRT file.
            OpenFileDialog dlg = new OpenFileDialog();
            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".srt";
            dlg.Filter = "srt files (*.srt)|*.srt";
            Nullable<bool> result = dlg.ShowDialog();    // display the dialog to the user

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                FileName.Text = dlg.FileName; // this updates the FileName textbox

                // The file chosen in the dialog is available at: dlg.FileName
                // You should probably initiate the file parsing.

                // This updates the UI (the xaml binding) to read the Subtitle collection into the grid.
                lvProducts.ItemsSource = Subtitles;
            }
        }
    }
}
