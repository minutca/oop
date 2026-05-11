using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Lab22
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // заповнення списку шрифтів
            foreach (FontFamily font in Fonts.SystemFontFamilies)
                fontFamilyBox.Items.Add(font);

            // розміри шрифтів
            fontSizeBox.ItemsSource = new double[]
            { 8, 10, 12, 14, 16, 18, 20, 24, 28, 32 };
        }

        // відкрити файл
        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == true)
            {
                TextRange range = new TextRange(
                    textBox.Document.ContentStart,
                    textBox.Document.ContentEnd);

                using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open))
                {
                    range.Load(fs, DataFormats.Rtf);
                }
            }
        }

        // зберегти файл
        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == true)
            {
                TextRange range = new TextRange(
                    textBox.Document.ContentStart,
                    textBox.Document.ContentEnd);

                using (FileStream fs = new FileStream(dlg.FileName, FileMode.Create))
                {
                    range.Save(fs, DataFormats.Rtf);
                }
            }
        }

        // шрифт
        private void fontFamilyBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fontFamilyBox.SelectedItem != null)
            {
                textBox.Selection.ApplyPropertyValue(
                    TextElement.FontFamilyProperty,
                    fontFamilyBox.SelectedItem);
            }
        }

        // розмір тексту
        private void fontSizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fontSizeBox.SelectedItem != null)
            {
                textBox.Selection.ApplyPropertyValue(
                    TextElement.FontSizeProperty,
                    fontSizeBox.SelectedItem);
            }
        }
    }
}