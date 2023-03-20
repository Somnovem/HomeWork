using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ExternFunctions
{
    public static class ExternAreaFunctions
    {
        /// <summary>
        /// Get area of a square with side a
        /// </summary>
        /// <param name="a">Side length</param>
        /// <returns></returns>
        public static double AreaSquare(double a) 
        {
            return a * a;
        }
        /// <summary>
        /// Get the are of a rectangular with sides a and b
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        /// <returns></returns>
        public static double AreaRectangular(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// Get the are of a triangle with sides a,b and c
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        /// <param name="c">Third side</param>
        /// <returns></returns>
        public static double AreaTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            try
            {
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// Get the are of a triangle with side a and height to it
        /// </summary>
        /// <param name="a">Side</param>
        /// <param name="h">Height to this side</param>
        /// <returns></returns>
        public static double AreaTriangle(double a, double h)
        {
            return 0.5 * a * h;
        }

    }

    public static class ExternTextFunctions
    {
        /// <summary>
        /// Checks if input text is a palindrome
        /// </summary>
        /// <param name="text">Text to check</param>
        /// <returns></returns>
        public static bool IsTextPalindrome(string text)
        {
            int length = text.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (text[i] != text[length - i - 1])
                    return false;
            }
            return true;
        }


        /// <summary>
        /// Counts number of sentences in input text
        /// </summary>
        /// <param name="text"><Text to check/param>
        /// <returns></returns>
        public static int CountSentences(string text)
        {
            return text.Split(".?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Count();
        }


        /// <summary>
        /// Returns copy of reversed input text
        /// </summary>
        /// <param name="text">Text to reverse</param>
        /// <returns></returns>
        public static string ReverseText(string text)
        {
            string res = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                res += text[i];
            }
            return res;
        }
    }

    public static class ExternContactFunctions
    {
        /// <summary>
        /// Checks if passed names only consist of letters
        /// </summary>
        /// <param name="names">Names to check</param>
        /// <returns>-1 if no arguments were given,0 if true for all arguments, non-zero - index of the first encountered error</returns>
        public static int NameContainsOnlyLetters(params string[] names) 
        {
            if (names.Length == 0) return -1;
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                if (string.IsNullOrEmpty(name)) return i + 1;
                for (int j = 0; j < name.Length; j++)
                {
                    if (!Char.IsLetter(name[j]))
                        return i + 1;
                }
            }
            return 0;
        }

        /// <summary>
        /// Checks if input age in string format consists obly of digits
        /// </summary>
        /// <param name="age">Age in string format</param>
        /// <returns></returns>
        public static bool AgeContainsOnlyDigits(string age)
        {
            if (string.IsNullOrEmpty(age)) return false;
            int num;
            return int.TryParse(age, out num);
        }

        /// <summary>
        /// Checks if input phone number is in correct format
        /// </summary>
        /// <param name="phoneNumber">Phone number in string format</param>
        /// <returns></returns>
        public static bool NumberInCorrectFormat(string phoneNumber)
        {
            Regex regex = new Regex("^[0-9\\-\\+]{9,15}$");
            return regex.IsMatch(phoneNumber);
        }
        /// <summary>
        /// Checks if input email is in correct format
        /// </summary>
        /// <param name="email">Email to check</param>
        /// <returns></returns>
        public static bool EmailInCorrectFormat(string email)
        {
            try
            {
                var temp = new MailAddress(email).Address;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }

    public static class ExternFileFunctions
    {
        /// <summary>
        /// Copy file from one path to another
        /// </summary>
        /// <param name="sourcePath">Path to copy from</param>
        /// <param name="destinationPath">Path to copy to</param>
        /// <param name="overwrite">Enable overwriting</param>
        public static bool CopyFile(string sourcePath, string destinationPath, bool overwrite = true)
        {
            if (!File.Exists(sourcePath) || !File.Exists(destinationPath)) return false;
            try
            {
                File.Copy(sourcePath, destinationPath, overwrite);
                return true;
            }
            catch
            {
                return false;
            }

        }
        /// <summary>
        /// Executed deep cloning of one directory to another
        /// </summary>
        /// <param name="sourcePath">Directory to copy from</param>
        /// <param name="destinationPath">Directory to copy to</param>
        public static void CopyDirectory(string sourcePath, string destinationPath)
        {
            var currentDirectory = new DirectoryInfo(sourcePath);

            DirectoryInfo[] directories = currentDirectory.GetDirectories();

            Directory.CreateDirectory(destinationPath);

            foreach (FileInfo file in currentDirectory.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationPath, file.Name);
                file.CopyTo(targetFilePath);
            }

            foreach (DirectoryInfo subDirectory in directories)
            {
                string newDestinationDir = Path.Combine(destinationPath, subDirectory.Name);
                CopyDirectory(subDirectory.FullName, newDestinationDir);
            }
        }

        /// <summary>
        /// Deletes  file from directory if it exists
        /// </summary>
        /// <param name="directoryPath">Path to directory</param>
        /// <param name="filename">Name of file to be deleted</param>
        public static bool DeleteFileFromDirectory(string directoryPath, string filename)
        {
            string path = $"{directoryPath}\\{filename}";
            if (File.Exists(path))
            {
                File.Delete(path);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Deletes all files from directory if they exist
        /// </summary>
        /// <param name="directoryPath">Path to directory</param>
        /// <param name="filenames">Array of names of files to be deleted</param>
        /// <returns>-1 if directory didn't exist, -2 if array of names was null or empty, 0 if operation was successfull</returns>
        public static int DeleteFilesFromDirectory(string directoryPath, IEnumerable<string> filenames)
        {
            if (!Directory.Exists(directoryPath)) return -1;
            if (filenames == null || !filenames.Any()) return -2;
            string path = "";
            foreach (var filename in filenames)
            {
                path = $"{directoryPath}\\{filename}";
                if (File.Exists(path)) File.Delete(path);
            }
            return 0;
        }

        /// <summary>
        /// Deletes all files with INPUT extension from INPUT directory
        /// </summary>
        /// <param name="directoryPath">Path to directory</param>
        /// <param name="extension">Extension to search for("*.exe","*.txt","*.bin",etc)</param>
        /// <returns> -1 if directory didn't exist, -2 if invalid extensions was inputted, 0 if operation was successfull</returns>
        public static int DeleteFilesWithExtension(string directoryPath, string extension)
        {
            if (!Directory.Exists(directoryPath)) return -1;
            Regex regex = new Regex("^[a-z0-9]*\\*?\\.[a-z]+$");
            if (!regex.IsMatch(extension)) return -2;
            foreach (var item in Directory.GetFiles(directoryPath, extension, SearchOption.AllDirectories))
            {
                File.Delete(item);
            }
            return 0;
        }
    }
    public static class ExternSearchInFilesFunctions
    {
        /// <summary>
        /// Counts appearences of the word in the file and logs result 
        /// </summary>
        /// <param name="word">Word to search for</param>
        /// <param name="sourcePath">Path to the file to search in</param>
        /// <param name="logfilePath">Path to the file to log to</param>
        /// <returns>-1 if source didn't exist, -2 if logFilePath was invalid,0 and bigger as number of appearences</returns>
        public static int SearchWordInFile(string word, string sourcePath, string logfilePath)
        {
            if (!File.Exists(sourcePath)) return -1;
            if (logfilePath.Length < 5 || !logfilePath.EndsWith(".txt")) return -2;
            int count = File.ReadAllLines(sourcePath).Count(c => c.Contains(word));
            using (StreamWriter writer = new StreamWriter(File.Create(logfilePath))) //ensures file is created, or cleared
            {
                writer.WriteLine($"File scanned: {sourcePath}");
                writer.WriteLine($"Word(s) scanned for: {word}");
                writer.WriteLine($"Number of appearences: {count}");
                writer.WriteLine($"Date of search: {DateTime.Now}");
            }
            return count;
        }
        /// <summary>
        /// Counts appearences of the word in every txt file in directory and logs result 
        /// </summary>
        /// <param name="word">Word to search for</param>
        /// <param name="sourcePath">Path to the file to search in</param>
        /// <param name="logfilePath">Path to the file to log to</param>
        /// <returns>-1 if source didn't exist, -2 if logFilePath was invalid,0 and bigger as number of appearences</returns>
        public static int SearchWordInDirectory(string word, string sourceDirectory, string logfilePath) 
        {
            if (!Directory.Exists(sourceDirectory)) return -1;
            if (logfilePath.Length < 5 || !logfilePath.EndsWith(".txt")) return -2;
            int count = 0;
            using (StreamWriter writer = new StreamWriter(File.Create(logfilePath))) //ensures file is created, or cleared
            {
                writer.WriteLine($"Word(s) scanned for: {word}");
                writer.WriteLine($"Date of search: {DateTime.Now}");
                writer.WriteLine("------------------------------------------------------------------------------");
                foreach (var filename in Directory.GetFiles(sourceDirectory, "*.txt", SearchOption.AllDirectories))
                {
                    int appearences = File.ReadAllLines(filename).Count(c => c.Contains(word));
                    writer.WriteLine($"File scanned: {filename}");
                    writer.WriteLine($"Number of appearences: {appearences}");
                    count += appearences;
                }
            }
            return count;
        }
    }
}