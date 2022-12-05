using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyboardTrainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        bool isUpper = false;
        Brush backHolder;
        static System.Timers.Timer timer = new System.Timers.Timer();
        char[] symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ12345667890_-=+!@#$%^&*()[]{};':,.<>/?|`~".ToCharArray();
        char[] numbersUnderShift = ")!@#$%^&*(".ToCharArray();
        char[] sideSymbolsUnderShift = ":?~{|}\"_+".ToCharArray();
        char[] sideSymbolsWithoutShift = ";/`[\\]'-=".ToCharArray();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = 60000;
            timer.Elapsed += Timer_Elapsed;
        }

        private string GetRandomString()
        {
            string res = "";
            Random rand = new Random();
            int allowedSymbols = (int)difficultySlider.Value;
            for (int i = 0; i < 40; i++)
            {
                res += symbols[rand.Next(0, allowedSymbols)];
            }
            int numberOfSpaces = res.Length / 7;
            for (int i = 0; i < numberOfSpaces; i++)
            {
                res = res.Insert(rand.Next(0, res.Length), " ");
            }
            return res;
        }
        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                speedCounter.Text = "0";
            });
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (startButton.IsEnabled) return;
            bool isAddable = true;
            string key = e.Key.ToString();
            if (e.SystemKey.ToString() != "None")
            {
                key = e.SystemKey.ToString();
                isAddable = false;
            }

            if (key == "Capital")
            {
                key = "Caps Lock";
                StackPanel keyboardToCheckLocal = UpperKeyboard;
                foreach (StackPanel childStack in keyboardToCheckLocal.Children)
                {
                    foreach (Grid childGrid in childStack.Children)
                    {
                        Border border = (Border)childGrid.Children[0];
                        if (((TextBlock)border.Child).Text == key)
                        {
                            border.Background = (border.Background == Brushes.DarkCyan) ? (Brush)new BrushConverter().ConvertFromString("#FFB5B5B5") : Brushes.DarkCyan;
                            UpperKeyboard.Visibility = (UpperKeyboard.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
                            LowerKeyboard.Visibility = (LowerKeyboard.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
                            isUpper = !isUpper;
                            return;
                        }
                    }
                }
            }
            else if (key == "Space") key = "SPACE";
            else if (key == "Tab") key = "TAB";
            else if (key == "Back") key = "BACKSPACE";
            else if (key.Contains("Shift"))
            {
                bool isRight = key.Contains("Right");
                key = "Shift";
                isUpper = true;
                StackPanel keyboardToCheckLocal = UpperKeyboard;
                foreach (StackPanel childStack in keyboardToCheckLocal.Children)
                {
                    foreach (Grid childGrid in childStack.Children)
                    {
                        Border border = (Border)childGrid.Children[0];
                        if (((TextBlock)border.Child).Text == key)
                        {
                            if (isRight) { isRight = false; continue; }
                            border.Background = Brushes.DarkCyan;
                            UpperKeyboard.Visibility = Visibility.Visible;
                            LowerKeyboard.Visibility = Visibility.Collapsed;
                            return;
                        }
                    }
                }
            }
            else if (key.Contains("Win"))
            {
                bool isRight = key.Contains("R");
                key = "Win";
                StackPanel keyboardToCheckLocal = isUpper ? UpperKeyboard : LowerKeyboard;
                foreach (StackPanel childStack in keyboardToCheckLocal.Children)
                {
                    foreach (Grid childGrid in childStack.Children)
                    {
                        Border border = (Border)childGrid.Children[0];
                        if (((TextBlock)border.Child).Text == key)
                        {
                            if (isRight) { isRight = false; continue; }
                            border.Background = Brushes.DarkCyan;
                            return;
                        }
                    }
                }
            }
            else if (key.Contains("Ctrl"))
            {
                bool isRight = key.Contains("Right");
                key = "Ctrl";
                StackPanel keyboardToCheckLocal = isUpper ? UpperKeyboard : LowerKeyboard;
                foreach (StackPanel childStack in keyboardToCheckLocal.Children)
                {
                    foreach (Grid childGrid in childStack.Children)
                    {
                        Border border = (Border)childGrid.Children[0];
                        if (((TextBlock)border.Child).Text == key)
                        {
                            if (isRight) { isRight = false; continue; }
                            border.Background = Brushes.DarkCyan;
                            return;
                        }
                    }
                }
            }
            else if (key.Contains("Alt"))
            {
                bool isRight = key.Contains("Right");
                key = "Alt";
                StackPanel keyboardToCheckLocal = isUpper ? UpperKeyboard : LowerKeyboard;
                foreach (StackPanel childStack in keyboardToCheckLocal.Children)
                {
                    foreach (Grid childGrid in childStack.Children)
                    {
                        Border border = (Border)childGrid.Children[0];
                        if (((TextBlock)border.Child).Text == key)
                        {
                            if (isRight) { isRight = false; continue; }
                            border.Background = Brushes.DarkCyan;
                            return;
                        }
                    }
                }
            }
            else if (key.Contains("Left"))
            {
                isAddable = false;
                key = key.Remove(0, 4);
            }
            else if (key.Contains("Right"))
            {
                isAddable = false;
                key = key.Remove(0, 5);
            }

            if ((e.KeyboardDevice.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
            {
                if (key.StartsWith("D") && key.Length > 1)
                {
                    key = key.Remove(0, 1);
                    key = numbersUnderShift[Convert.ToInt32(key)].ToString();
                }
                if (key.StartsWith("Oem"))
                {
                    if (key == "OemOpenBrackets") key = sideSymbolsUnderShift[3].ToString();
                    else if (key == "OemQuestion") key = "?";
                    else if (key == "OemQuotes") key = "\"";
                    else if (key == "OemComma") key = "<";
                    else if (key == "OemPeriod") key = ">";
                    else if (key == "OemMinus") key = sideSymbolsUnderShift[7].ToString();
                    else if (key == "OemPlus") key = sideSymbolsUnderShift[8].ToString();
                    else
                    {
                        key = key.Remove(0, 3);
                        key = sideSymbolsUnderShift[Convert.ToInt32(key) - 1].ToString();
                    }
                }
            }
            else
            {
                if (key.StartsWith("D") && key.Length > 1)
                {
                    key = key.Remove(0, 1);
                }
                if (key.StartsWith("Oem"))
                {
                    if (key == "OemOpenBrackets") key = sideSymbolsWithoutShift[3].ToString();
                    else if (key == "OemQuestion") key = "/";
                    else if (key == "OemQuotes") key = "'";
                    else if (key == "OemComma") key = ",";
                    else if (key == "OemPeriod") key = ".";
                    else if (key == "OemMinus") key = sideSymbolsWithoutShift[7].ToString();
                    else if (key == "OemPlus") key = sideSymbolsWithoutShift[8].ToString();
                    else
                    {
                        key = key.Remove(0, 3);
                        key = sideSymbolsWithoutShift[Convert.ToInt32(key) - 1].ToString();
                    }
                }
            }
            StackPanel keyboardToCheck = isUpper ? UpperKeyboard : LowerKeyboard;
            foreach (StackPanel childStack in keyboardToCheck.Children)
            {
                foreach (Grid childGrid in childStack.Children)
                {
                    Border border = (Border)childGrid.Children[0];
                    if (((TextBlock)border.Child).Text.ToUpper() == key)
                    {
                        backHolder = border.Background;
                        border.Background = Brushes.DarkCyan;
                        if (!isUpper) key = key.ToLower();
                        if (key == "space") key = " ";
                        else if (key == "tab") key = "\t";
                        else if (key == "backspace" || key == "BACKSPACE")
                        {
                            if (textAnswerWrong.Text.Length > 0)
                            {
                                textAnswerWrong.Text = textAnswerWrong.Text.Remove(textAnswerWrong.Text.Length - 1, 1);
                            }
                            return;
                        }
                        if (isAddable)
                        {
                            speedCounter.Text = (Convert.ToInt32(speedCounter.Text) + 1).ToString();
                            if (textAnswerWrong.Text.Length == 0)
                            {
                                if ((bool)isCaseSensative.IsChecked)
                                {
                                    if (textTask.Text[0] == key[0])
                                    {
                                        textTaskCorrect.Text += key[0];
                                        textAnswerCorrect.Text += key[0];
                                        textTask.Text = textTask.Text.Remove(0, 1);
                                    }
                                    else
                                    {
                                        textAnswerWrong.Text += key[0];
                                        failsCounter.Text = (Convert.ToInt32(failsCounter.Text) + 1).ToString();
                                    }
                                }
                                else
                                {
                                    if (textTask.Text[0] == key.ToLower()[0] || textTask.Text[0] == key.ToUpper()[0])
                                    {
                                        textTaskCorrect.Text += key.ToLower()[0];
                                        textAnswerCorrect.Text += key.ToLower()[0];
                                        textTask.Text = textTask.Text.Remove(0, 1);
                                    }
                                    else
                                    {
                                        textAnswerWrong.Text += key[0];
                                        failsCounter.Text = (Convert.ToInt32(failsCounter.Text) + 1).ToString();
                                    }
                                }
                            }
                            else
                            {
                                textAnswerWrong.Text += key[0];
                                failsCounter.Text = (Convert.ToInt32(failsCounter.Text) + 1).ToString();
                            }
                        }
                        return;
                    }
                }
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (startButton.IsEnabled) return;
            string key = e.Key.ToString();

            if (e.SystemKey.ToString() != "None")
            {
                key = e.SystemKey.ToString();
            }
            if (key == "Capital")
            {
                StackPanel keyboardToCheckLocal = UpperKeyboard;
                foreach (StackPanel childStack in keyboardToCheckLocal.Children)
                {
                    foreach (Grid childGrid in childStack.Children)
                    {
                        Border border = (Border)childGrid.Children[0];
                        if (((TextBlock)border.Child).Text.ToUpper() == key)
                        {
                            UpperKeyboard.Visibility = (UpperKeyboard.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
                            return;
                        }
                    }
                }
            }
            else if (key == "Space") key = "SPACE";
            else if (key == "Tab") key = "TAB";
            else if (key == "Back") key = "BACKSPACE";
            else if (key.Contains("Shift"))
            {
                bool isRight = key.Contains("Right");
                key = "Shift";
                isUpper = false;
                StackPanel keyboardToCheckLocal = UpperKeyboard;
                foreach (StackPanel childStack in keyboardToCheckLocal.Children)
                {
                    foreach (Grid childGrid in childStack.Children)
                    {
                        Border border = (Border)childGrid.Children[0];
                        if (((TextBlock)border.Child).Text == key)
                        {
                            if (isRight) { isRight = false; continue; }
                            border.Background = (Brush)new BrushConverter().ConvertFromString("#FFB5B5B5");
                            UpperKeyboard.Visibility = Visibility.Collapsed;
                            LowerKeyboard.Visibility = Visibility.Visible;
                            return;
                        }
                    }
                }
            }
            else if (key.Contains("Win"))
            {
                bool isRight = key.Contains("R");
                key = "Win";
                StackPanel keyboardToCheckLocal = isUpper ? UpperKeyboard : LowerKeyboard;
                foreach (StackPanel childStack in keyboardToCheckLocal.Children)
                {
                    foreach (Grid childGrid in childStack.Children)
                    {
                        Border border = (Border)childGrid.Children[0];
                        if (((TextBlock)border.Child).Text == key)
                        {
                            if (isRight) { isRight = false; continue; }
                            border.Background = (Brush)new BrushConverter().ConvertFromString("#FFB5B5B5");
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
            else if (key.Contains("Ctrl"))
            {
                bool isRight = key.Contains("Right");
                key = "Ctrl";
                StackPanel keyboardToCheckLocal = isUpper ? UpperKeyboard : LowerKeyboard;
                foreach (StackPanel childStack in keyboardToCheckLocal.Children)
                {
                    foreach (Grid childGrid in childStack.Children)
                    {
                        Border border = (Border)childGrid.Children[0];
                        if (((TextBlock)border.Child).Text == key)
                        {
                            if (isRight) { isRight = false; continue; }
                            border.Background = (Brush)new BrushConverter().ConvertFromString("#FFB5B5B5");
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
            else if (key.Contains("Alt"))
            {
                bool isRight = key.Contains("Right");
                key = "Alt";
                StackPanel keyboardToCheckLocal = isUpper ? UpperKeyboard : LowerKeyboard;
                foreach (StackPanel childStack in keyboardToCheckLocal.Children)
                {
                    foreach (Grid childGrid in childStack.Children)
                    {
                        Border border = (Border)childGrid.Children[0];
                        if (((TextBlock)border.Child).Text == key)
                        {
                            if (isRight) { isRight = false; continue; }
                            border.Background = (Brush)new BrushConverter().ConvertFromString("#FFB5B5B5");
                            return;
                        }
                    }
                }
            }
            else if (key.Contains("Left"))
            {
                key = key.Remove(0, 4);
            }
            else if (key.Contains("Right"))
            {
                key = key.Remove(0, 5);
            }

            if ((e.KeyboardDevice.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
            {
                if (key.StartsWith("D") && key.Length > 1)
                {
                    key = key.Remove(0, 1);
                    key = numbersUnderShift[Convert.ToInt32(key)].ToString();
                }
                if (key.StartsWith("Oem"))
                {
                    if (key == "OemOpenBrackets") key = sideSymbolsUnderShift[3].ToString();
                    else if (key == "OemQuestion") key = "?";
                    else if (key == "OemQuotes") key = "\"";
                    else if (key == "OemComma") key = "<";
                    else if (key == "OemPeriod") key = ">";
                    else if (key == "OemMinus") key = sideSymbolsUnderShift[7].ToString();
                    else if (key == "OemPlus") key = sideSymbolsUnderShift[8].ToString();
                    else
                    {
                        key = key.Remove(0, 3);
                        key = sideSymbolsUnderShift[Convert.ToInt32(key) - 1].ToString();
                    }
                }
            }
            else
            {
                if (key.StartsWith("D") && key.Length > 1)
                {
                    key = key.Remove(0, 1);
                }
                if (key.StartsWith("Oem"))
                {
                    if (key == "OemOpenBrackets") key = sideSymbolsWithoutShift[3].ToString();
                    else if (key == "OemQuestion") key ="/";
                    else if (key == "OemQuotes") key = "'";
                    else if (key == "OemComma") key = ",";
                    else if (key == "OemPeriod") key = ".";
                    else if (key == "OemMinus") key = sideSymbolsWithoutShift[7].ToString();
                    else if (key == "OemPlus") key = sideSymbolsWithoutShift[8].ToString();
                    else
                    {
                        key = key.Remove(0, 3);
                        key = sideSymbolsWithoutShift[Convert.ToInt32(key) - 1].ToString();
                    }
                }

            }



            StackPanel keyboardToCheck = isUpper ? UpperKeyboard : LowerKeyboard;
            foreach (StackPanel childStack in keyboardToCheck.Children)
            {
                foreach (Grid childGrid in childStack.Children)
                {
                    Border border = (Border)childGrid.Children[0];
                    if (((TextBlock)border.Child).Text.ToUpper() == key)
                    {
                        border.Background = backHolder;
                        if (textTask.Text.Length == 0)
                        {
                            stopButton_Click(null, null);
                        }
                        return;
                    }
                }
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            difficultyCounter.Text = ((int)Math.Round(difficultySlider.Value)).ToString();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            startButton.IsEnabled = false;
            stopButton.IsEnabled = true;
            failsCounter.Text = "0";
            speedCounter.Text = "0";
            textTask.Text = GetRandomString();
            textAnswerCorrect.Text = "";
            textTaskCorrect.Text = "";
            textAnswerWrong.Text = "";
            isCaseSensative.IsEnabled = false;
            difficultySlider.IsEnabled = false;
            timer.Start();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            startButton.IsEnabled = true;
            stopButton.IsEnabled = false;
            isCaseSensative.IsEnabled = true;
            difficultySlider.IsEnabled = true;
            timer.Stop();
        }
    }
}
