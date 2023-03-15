using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.IO;
namespace Homework1_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Task 1
        private string text;
        private int numSentences;
        private int numChars;
        private int numWords;
        private int numQuestions;
        private int numExclamations;
        private bool performedOperation = false;
        private bool outputToMessage = false;
        private CancellationTokenSource sourceAnalyzing;
        private CancellationToken tokenAnalyzing;
        private CancellationTokenSource sourceWriting;
        private CancellationToken tokenWriting;
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(edText.Text)) 
            {
                MessageBox.Show("Text field is empty!");
                return;
            }
            btnStart.IsEnabled = false;
            performedOperation = false;
            text = edText.Text;
            if (cbCountSentences.IsChecked != true) numSentences = -1;
            if (cbCountSymbols.IsChecked != true) numChars = -1;
            if (cbCountWords.IsChecked != true) numWords = -1;
            if (cbCountQuestions.IsChecked != true) numQuestions = -1;
            if (cbCountExlamations.IsChecked != true) numExclamations = -1;
            sourceAnalyzing = new CancellationTokenSource();
            tokenAnalyzing = sourceAnalyzing.Token;
            sourceWriting = new CancellationTokenSource();
            tokenWriting = sourceAnalyzing.Token;
            outputToMessage = rbOutputMessage.IsChecked == true;
            Task taskAnalyze = new Task(AnalyzeText, tokenAnalyzing);
            Task taskDoOutput = taskAnalyze.ContinueWith((t) => WriteAnalysis(),tokenWriting);
            taskAnalyze.Start();
            taskDoOutput.Wait();
            btnStart.IsEnabled = true;
            performedOperation = true;
        }

        private void AnalyzeText()
        {
            string[] sentences = text.Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
             if(numSentences != -1)
                numSentences = sentences.Length;

             if (numChars != -1)
                numChars = text.Length;

             if (tokenAnalyzing.IsCancellationRequested)
                {
                    MessageBox.Show("Operation canceled");
                    return;
                }
             if (numWords != -1)
                numWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count();

             if (numQuestions != -1)
                numQuestions = sentences.Select(c => c.EndsWith('?')).Count();

             if (numExclamations != -1)
                numExclamations = sentences.Select(c => c.EndsWith('!')).Count();
        }

        private void WriteAnalysis()
        {
            List<string> analysisMessages = new List<string>();

            if (numSentences != -1) analysisMessages.Add($"Number of sentences: {numSentences}");
            if (numChars != -1) analysisMessages.Add($"Number of symbols: {numChars}");

            if (tokenWriting.IsCancellationRequested)
            {
                MessageBox.Show("Operation canceled");
                return;
            }

            if (numWords != -1) analysisMessages.Add($"Number of words: {numWords}");
            if (numQuestions != -1) analysisMessages.Add($"Number of questions: {numQuestions}");
            if (numExclamations != -1) analysisMessages.Add($"Number of exclamations: {numExclamations}");

            analysisMessages.Add($"Analysis done: {DateTime.Now}");
            if (outputToMessage)
            {
                foreach (var msg in analysisMessages)
                {
                    if (tokenWriting.IsCancellationRequested)
                    {
                        MessageBox.Show("Operation canceled");
                        return;
                    }
                    MessageBox.Show(msg);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("Analysis.txt"))
                {
                    foreach (var item in analysisMessages)
                    {
                        if (tokenWriting.IsCancellationRequested)
                        {
                            MessageBox.Show("Operation canceled");
                            return;
                        }
                        writer.WriteLine(item);
                    }
                }
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            sourceAnalyzing.Cancel();
            sourceWriting.Cancel();

        }

        private void btnOpenFileText_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
