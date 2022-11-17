using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WF_CW.Editor;

namespace WF_CW
{
    public partial class Editor : Form
    {
        Student[] students =
{
            new Student()
            {
                FirstName = "Olga",
                LastName = "Petrova",
                BirthDay = new DateTime(2000, 10, 15),
                StudentCard = new StudentCard()
                {
                    Series = "AB",
                    Number = 123456
                }
            },
            new Student()
            {
                FirstName = "Valery",
                LastName = "Matveev",
                BirthDay = new DateTime(2001, 11, 5),
                StudentCard = new StudentCard()
                {
                    Series = "AB",
                    Number = 123400
                }
            },
            new Student()
            {
                FirstName = "Petro",
                LastName = "Alekseev",
                BirthDay = new DateTime(2000, 10, 14),
                StudentCard = new StudentCard()
                {
                    Series = "AC",
                    Number = 123489
                }
            },
            new Student()
            {
                FirstName = "Irina",
                LastName = "Fadeeva",
                BirthDay = new DateTime(1999, 2, 24),
                StudentCard = new StudentCard()
                {
                    Series = "AC",
                    Number = 123455
                }
            }
        };
        public Editor()
        {
            InitializeComponent();
            openToolStripMenuItem.Text = Resources.Resource1.Open;
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            newToolStripMenuItem1.Click += NewToolStripMenuItem_Click;
            listView1.Columns.Add("FirstName");
            listView1.Columns.Add("LastName");
            listView1.Columns.Add("Date");
            listView1.Columns[2].Width = 100;
            listView1.Columns.Add("Series");
            listView1.Columns.Add("Number");
            listView1.SmallImageList = imageList1;
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].TextAlign = HorizontalAlignment.Center;
            }
            for (int i = 0; i < students.Length; i++)
            {
                listView1.Items.Add(students[i].FirstName);
                listView1.Items[i].SubItems.Add(students[i].LastName);
                listView1.Items[i].SubItems.Add(students[i].BirthDay.ToShortDateString());
                listView1.Items[i].SubItems.Add(students[i].StudentCard.Series);
                listView1.Items[i].SubItems.Add(students[i].StudentCard.Number.ToString());
            }
            listView1.View = View.Details;

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            treeView1.SelectedNode.Nodes.Add(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "rtf";
            openFileDialog1.Filter = "All files(*.*)|(*.*)|RTF files(*.rtf)|(*.rtf)||";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = stream.ReadToEnd();
                stream.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All files(*.*)|(*.*)|RTF files(*.rtf)|(*.rtf)||";
            saveFileDialog1.FilterIndex = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            PrintDialog pg = new PrintDialog();
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            pd.DocumentName = "fileName";
            pg.Document = pd;

            if(pg.ShowDialog() == DialogResult.OK)pd.Print();
        }
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = color.Color;
            }
        }

        int i = 0;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (i >= richTextBox1.Text.Length)
            {
                i = 0;
            }
            while (richTextBox1.Text.IndexOf("double", i) != -1) {
                i = richTextBox1.Text.IndexOf("double", i);
                richTextBox1.Select(i, 6);
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.Select(richTextBox1.Text.Length, 0);
                richTextBox1.SelectionColor = Color.Black;
                i += "double".Length;
            }
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
            }

        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        [Serializable]
        public class StudentCard : IComparable, ICloneable
        {

            public string Series { get; set; }
            public int Number { get; set; }

            public object Clone()
            {
                return this.MemberwiseClone();
            }

            public int CompareTo(object obj)
            {
                StudentCard st1 = obj as StudentCard;
                if (Series == st1.Series)
                {
                    return Number.CompareTo(st1.Number);
                }
                else
                {
                    return Series.CompareTo(st1.Series);
                }
                throw new NotImplementedException();
            }

            public override string ToString()
            {
                return $"{Series} #{Number}";
            }
        }

        class GroupName
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public class Student : IComparable<Student>, ICloneable
        {
            int id = 100;
            public int GroupName { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public DateTime BirthDay { get; set; }
            public StudentCard StudentCard { get; set; }




            public override int GetHashCode()
            {
                return $"{StudentCard.Series} #{StudentCard.Number}".GetHashCode();
            }

            public int CompareTo(Student obj) => LastName.CompareTo(obj.LastName);


            public override string ToString()
            {
                return $"{FirstName.PadRight(10)} {LastName.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
            }

            public object Clone()
            {
                Student student = (Student)this.MemberwiseClone();
                student.StudentCard = (StudentCard)this.StudentCard.Clone();
                return student;
            }

            public void Exam(DateTime date)
            {
                Console.WriteLine($"Екзамен для {FirstName} {LastName} назначений на {date.ToShortDateString()}");
            }

        }

        class ExamEventArgs : EventArgs
        {
            public DateTime Date { get; set; }
        }

        private int lastIndex = -1;
        private int lastColumn = -1;
        private bool spamming = false;
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int ind = e.Column;
            if (ind == lastIndex && spamming)
            {
                spamming = false;
                listView1.Columns[ind].ImageIndex = 1;
                switch (ind)
                {

                    case 0:
                        students = (from st in students
                                    orderby st.FirstName descending
                                    select st).ToArray();
                        break;
                    case 1:
                        students = (from st in students
                                    orderby st.LastName descending
                                    select st).ToArray();
                        break;
                    case 2:
                        students = (from st in students
                                    orderby st.BirthDay descending
                                    select st).ToArray();
                        break;
                    case 3:
                        students = (from st in students
                                    orderby st.StudentCard.Series descending
                                    select st).ToArray();
                        break;
                    case 4:
                        students = (from st in students
                                    orderby st.StudentCard.Number descending
                                    select st).ToArray();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                spamming = true;
                listView1.Columns[ind].ImageIndex = 0;
                switch (ind)
                {

                    case 0:
                        students = (from st in students
                                    orderby st.FirstName
                                    select st).ToArray();
                        break;
                    case 1:
                        students = (from st in students
                                    orderby st.LastName
                                    select st).ToArray();
                        break;
                    case 2:
                        students = (from st in students
                                    orderby st.BirthDay
                                    select st).ToArray();
                        break;
                    case 3:
                        students = (from st in students
                                    orderby st.StudentCard.Series
                                    select st).ToArray();
                        break;
                    case 4:
                        students = (from st in students
                                    orderby st.StudentCard.Number
                                    select st).ToArray();
                        break;
                    default:
                        break;
                }
            }
            lastIndex = ind;
            if (lastColumn == -1)
            {
                lastColumn = ind;
            }
            else if (lastColumn != ind)
            {
                listView1.Columns[lastColumn].ImageIndex = -1;
                listView1.Columns[lastColumn].TextAlign = HorizontalAlignment.Center;
                lastColumn = ind;
            }
            listView1.Items.Clear();
            for (int i = 0; i < students.Length; i++)
            {
                listView1.Items.Add(students[i].FirstName);
                listView1.Items[i].SubItems.Add(students[i].LastName);
                listView1.Items[i].SubItems.Add(students[i].BirthDay.ToShortDateString());
                listView1.Items[i].SubItems.Add(students[i].StudentCard.Series);
                listView1.Items[i].SubItems.Add(students[i].StudentCard.Number.ToString());
            }
            listView1.Columns[ind].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}

