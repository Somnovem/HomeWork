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
using System.Text.RegularExpressions;
using System.Diagnostics;
using WinForms = System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using ListBox = System.Windows.Controls.ListBox;
using MessageBox = System.Windows.MessageBox;
using Path = System.IO.Path;
using System.Windows.Media.Animation;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
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
            if (!outputToMessage) performedOperation = false;
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
            if(!outputToMessage)performedOperation = true;
        }

        private void AnalyzeText()
        {
            string[] sentences = text.Split(".?!");
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
                numQuestions = sentences.Where(c => c.EndsWith('?')).Count();

             if (numExclamations != -1)
                numExclamations = sentences.Where(c=>c.EndsWith('!')).Count();
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
            if (!performedOperation)return;
            var p = new Process();
            p.StartInfo = new ProcessStartInfo("Analysis.txt")
            {
                UseShellExecute = true
            };
            p.Start();
        }
        #endregion
        #region Task 2

        private static string destinationPath;
        private static List<string> sourceFiles = new List<string>();
        private static List<string> newFilesInDestinaton = new List<string>();
        private void FillListBox(ListBox lb) 
        {
            string fillingPath;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != WinForms.DialogResult.OK) return;
            fillingPath = dialog.SelectedPath;
            lb.Items.Clear();
            var files = Directory.GetFiles(fillingPath, "*.*", SearchOption.AllDirectories);
            if (lb.Name == "lbSourceFiles") sourceFiles = files.ToList();
            else destinationPath = fillingPath;
            foreach (var file in files)
            {
                lb.Items.Add(file);
            }
        }

        private void RunProcessFromListbox(ListBox lb) 
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo((string)lb.SelectedItem)
            {
                UseShellExecute = true
            };
            p.Start();
        }

        private static bool IsFileCopy(string file1Path, string file2Path)
        {
            using (var file1 = new FileStream(file1Path, FileMode.Open,FileAccess.Read))
            using (var file2 = new FileStream(file2Path, FileMode.Open,FileAccess.Read))
            {
                if (file1.Length != file2.Length)
                {
                    return false;
                }

                int b1, b2;
                do
                {
                    b1 = file1.ReadByte();
                    b2 = file2.ReadByte();
                } while (b1 == b2 && b1 != -1);

                return b1 == b2;
            }
        }

        private void btnChangeSource_Click(object sender, RoutedEventArgs e)
        {
            FillListBox(lbSourceFiles);
        }

        private void btnChangeDestination_Click(object sender, RoutedEventArgs e)
        {
            FillListBox(lbDestinationFiles);
            lblDestination.Content = destinationPath;
        }

        private void btnTransferFiles_Click(object sender, RoutedEventArgs e)
        {
            if (lbSourceFiles.Items.Count == 0 || string.IsNullOrEmpty(destinationPath))
            {
                MessageBox.Show("Source or destination folder wan't chosen","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }

            Dictionary<string, string> filesSent = new Dictionary<string, string>();
            int numberOfFilesChecked = 0;
            int sameNameFilesFound = 0;
            int copiesFound = 0;
            Task taskSearching = Task.Run(() => 
            {
                foreach (string file in sourceFiles)
                {
                    FileInfo f = new FileInfo(file);
                    string pathToAlreadyExsistingName;
                    if (filesSent.TryGetValue(f.Name, out pathToAlreadyExsistingName))
                    {
                        if (!IsFileCopy(file, pathToAlreadyExsistingName))
                        {
                            string newFileName = f.Name.Split('.')[0];
                            while (File.Exists(Path.Combine(destinationPath, newFileName + f.Extension)))
                            {
                                newFileName += "-Copy";
                            }
                            CopyFileWithNewName(file, newFileName + f.Extension);
                            filesSent.Add(newFileName + f.Extension, file);
                        }
                        else
                        {
                            //Found the exact copy of a file
                            copiesFound++;
                        }
                        //Found a file with a not-unique name
                        sameNameFilesFound++;
                    }
                    else
                    {
                        CopyFileWithNewName(file, f.Name);
                        filesSent.Add(f.Name, file);
                    }
                    //Found a file
                    numberOfFilesChecked++;
                }
            });

            Task taskWriting = null;
            if (cbGenerateAnalysis.IsChecked == true) 
            {
                taskWriting = taskSearching.ContinueWith((t) => 
                {
                    using (StreamWriter writer = new StreamWriter(new FileStream(Path.Combine(destinationPath, "TransferringResults.txt"), FileMode.Create)))
                    {
                        writer.WriteLine($"These files were added/overwritten with the last transfer made {DateTime.Now}");
                        writer.WriteLine("------------------------------------------------------------------");
                        foreach (var item in newFilesInDestinaton)
                        {
                            writer.WriteLine(new FileInfo(item).Name);
                        }
                        writer.WriteLine("------------------------------------------------------------------");
                        writer.WriteLine($"Number of files proccesed: {numberOfFilesChecked}");
                        writer.WriteLine($"Number of files with same names proccesed: {sameNameFilesFound}");
                        writer.WriteLine($"Number of copies found: {copiesFound}");
                    }
                });
            }

            MessageBox.Show("Started transferring!","Status",MessageBoxButton.OK,MessageBoxImage.Information);
            taskSearching.Wait();
            MessageBox.Show("Transfer complete!", "Status", MessageBoxButton.OK, MessageBoxImage.Information);
            if (cbGenerateAnalysis.IsChecked == true) 
            {
                MessageBox.Show("Started writing results!", "Status", MessageBoxButton.OK, MessageBoxImage.Information);
                taskWriting.Wait();
                MessageBox.Show("Finished writing results!", "Status", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            //Enlist all new items in the destination folder 
            var files = Directory.GetFiles(destinationPath, "*.*", SearchOption.AllDirectories);
            if(!lbDestinationFiles.Items.IsEmpty)lbDestinationFiles.Items.Clear();
            foreach (var file in files)
            {
                lbDestinationFiles.Items.Add(file);
            }
        }

        private void CopyFileWithNewName(string sourcePath,string newName) 
        {
            string newPath = Path.Combine(destinationPath, newName);
            newFilesInDestinaton.Add(newPath);
            File.Copy(sourcePath, newPath,true);
        }

        #endregion

        private void lbSourceFiles_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lbSourceFiles.SelectedItem == null) return;
            if (rbDeleteFile.IsChecked == true) 
            {
                sourceFiles.Remove((string)lbSourceFiles.SelectedItem);
                if (!lbSourceFiles.Items.IsEmpty) lbSourceFiles.Items.Clear();
                foreach (var item in sourceFiles)
                {
                    lbSourceFiles.Items.Add(item);
                }
            }
            else RunProcessFromListbox(lbSourceFiles);

        }

        private void lbDestinationFiles_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lbDestinationFiles.SelectedItem == null) return;
            RunProcessFromListbox(lbDestinationFiles);
        }
    }
}
