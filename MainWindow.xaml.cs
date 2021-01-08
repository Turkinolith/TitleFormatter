
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;




namespace TitleFormatter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static string appendAster = "*****";
        private string testAster;
        private string headerFooter;
        private string titleLine;
        private string combinedText;


        public MainWindow()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Clipboard.SetText(combinedText);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            // TODO Make Sure That I can't Memory Overflow
            // TODO Add An Error Message If String is Beyond Certain Length
            // TODO Ignore Input If String is Beyond Certain Length
            // Generates a top and bottom line consisting of 5 asterisks pre and post text length, with asterisks for each character 
            testAster = new string('*', textBox1.GetLineLength(0));
            headerFooter = string.Concat(appendAster, testAster, appendAster);
            titleLine = new string("**** " + textBox1.Text + " ****");
            combinedText = new string(headerFooter + "\n" + titleLine + "\n" + headerFooter + "\n\n");

            // Generates preview text
            textBlock1.Text = "Title: " + "\n" + combinedText;
        }
    }
}
