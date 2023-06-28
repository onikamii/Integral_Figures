using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using exportWord = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
//using Novacode;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace Integral_Figures
{
    public partial class oneFunction : Form
    {
        private readonly string FileName = @"C:\Users\Huawei\source\repos\Integral_Figures\Result.docx";
        double a; double b; double c; double borderA; double borderB; double Fa; double Fb; double Integral;
        public oneFunction()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= 9)) { return; }
            if (e.KeyChar == '.') { e.KeyChar = ','; }
            if (e.KeyChar == ',')
            {
                if (textBoxA.Text.IndexOf(',') != -1) { e.Handled = true; }
                return;
                if (textBoxB.Text.IndexOf(',') != -1) { e.Handled = true; }
                return;
                if (textBoxC.Text.IndexOf(',') != -1) { e.Handled = true; }
                return;
                if (textBoxBorderA.Text.IndexOf(',') != -1) { e.Handled = true; }
                return;
                if (textBoxBorderB.Text.IndexOf(',') != -1) { e.Handled = true; }
                return;
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
                c = Convert.ToDouble(textBoxC.Text);
                borderA = Convert.ToDouble(textBoxBorderA.Text);
                borderB = Convert.ToDouble(textBoxBorderB.Text);

                if (borderA == borderB) { MessageBox.Show("Нельзя определить фигуру так как границы фигуры равны"); }
                else if (borderA > borderB) { MessageBox.Show("Некорректный ввод данных"); }
                else
                {
                    double Fa = (a * (Math.Pow(borderA, 3) / 3)) + (b * (Math.Pow(borderA, 2) / 2)) + (c * borderA);
                    double Fb = (a * (Math.Pow(borderB, 3) / 3)) + (b * (Math.Pow(borderB, 2) / 2)) + (c * borderB);
                    Integral = Math.Abs(Fb - Fa);

                    label7.Text = Integral.ToString() + " ед";
                }
            }
            catch { MessageBox.Show("Некорректный ввод данных"); }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)  // ImportWord
        {
            //    Word.Application wordApp = new Word.Application();
            //    wordApp.Visible = false;
            //    Word.Document doc = wordApp.Documents.Add();
            //    //results doc = results.Load(@"C:\Users\Huawei\source\repos\Integral_Figures\Result1.docx");
            //    //string[] arr = doc.Text.Split(new char[] { ' ' });

            try
            {
                // Создание экземпляра приложения Word
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = false;

                // Открытие документа Word
                object fileName = @"C:\Users\Huawei\source\repos\Integral_Figures\data.docx";
                Word.Document doc = wordApp.Documents.Open(fileName);

                //doc = DocX.Load(@"C:\Users\Huawei\source\repos\Integral_Figures\data.docx");
                //string[] arr = doc.Text.Split(new char[] { ' ' });

                //textBoxA.Text = arr[0];
                //textBoxB.Text = arr[1];
                //textBoxC.Text = arr[2];
                //textBoxBorderA.Text = arr[3];
                //textBoxBorderB.Text = arr[4];
            }
            catch { MessageBox.Show("Ошибка импорта"); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Functions form2 = new Functions();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a != 0 && b != 0 && c != 0)
            {
                MessageBox.Show(String.Format("Этап 1: Находим первообразную функции \n\n" +
                    "∫(" + a + "x^2" + " + " + b + "x" + " + " + c + ")dx    при а = " + borderA + " и b = " + borderB + "\n" +
                    "∫(" + a + "x^2" + " + " + b + "x" + " + " + c + ")dx = (" + a + " * x^3) / 3 + (" + b + " * x^2) / 2 + " + c + "x \n" +
                    "\nЭтап 2: Подставляем в первообразную верхний и нижний пределы \n\n" +
                    "(" + a + " * " + borderA + "^3) / 3 + (" + b + " * " + borderA + "^2) / 2 + " + c + borderA + " = " + Fa + "\n" +
                    "(" + a + " * " + borderB + "^3) / 3 + (" + b + " * " + borderB + "^2) / 2 + " + c + borderB + " = " + Fb + "\n" +
                    "\nЭтап 3: Вычисляем интеграл \n\n" +
                    Fb + " - " + Fa + " = " + Integral + "\n" +
                    Integral + " и является площадью заданной фигуры"));
            }
            else if (a != 0 && b == 0 && c == 0)
            {
                MessageBox.Show(String.Format("Этап 1: Находим первообразную функции \n\n" +
                    "∫" + a + "x^2" + "dx    при а = " + borderA + " и b = " + borderB + "\n" +
                    "∫" + a + "x^2" + "dx = (" + a + " * x^3) / 3 \n" +
                   "\nЭтап 2: Подставляем в первообразную верхний и нижний пределы \n\n" +
                    "(" + a + " * " + borderA + "^3) / 3 = " + Fa + "\n" +
                    "(" + a + " * " + borderB + "^3) / 3 = " + Fb + "\n" +
                     "\nЭтап 3: Вычисляем интеграл \n\n" +
                    Fb + " - " + Fa + " = " + Integral + "\n" +
                    Integral + " и является площадью заданной фигуры"));
            }
            else if (a == 0 && b != 0 && c == 0)
            {
                MessageBox.Show(String.Format("Этап 1: Находим первообразную функции \n\n" +
                    "∫" + b + "x" + "dx    при а = " + borderA + " и b = " + borderB + "\n" +
                    "∫" + b + "x" + "dx = " + b + " * x^2) / 2 \n" +
                    "\nЭтап 2: Подставляем в первообразную верхний и нижний пределы \n\n" +
                    "(" + b + " * " + borderA + "^2) / 2 = " + Fa + "\n" +
                    "(" + b + " * " + borderB + "^2) / 2 = " + Fb + "\n" +
                    "\nЭтап 3: Вычисляем интеграл \n\n" +
                    Fb + " - " + Fa + " = " + Integral + "\n" +
                    Integral + " и является площадью заданной фигуры"));
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                MessageBox.Show(String.Format("Этап 1: Находим первообразную функции \n\n" +
                    "∫" + c + "dx    при а = " + borderA + " и b = " + borderB + "\n" +
                    "∫" + c + "dx = " + c + "x \n" +
                    "\nЭтап 2: Подставляем в первообразную верхний и нижний пределы \n\n" +
                    c + borderA + " = " + Fa + "\n" +
                    c + borderB + " = " + Fb + "\n" +
                   "\nЭтап 3: Вычисляем интеграл \n\n" +
                    Fb + " - " + Fa + " = " + Integral + "\n" +
                    Integral + " и является площадью заданной фигуры"));
            }
            else if (a != 0 && b != 0 && c == 0)
            {
                MessageBox.Show(String.Format("Этап 1: Находим первообразную функции \n\n" +
                    "∫(" + a + "x^2" + " + " + b + "x" + ")dx    при а = " + borderA + " и b = " + borderB + "\n" +
                    "∫(" + a + "x^2" + " + " + b + "x" + ")dx = (" + a + " * x^3) / 3 + (" + b + " * x^2) / 2 \n" +
                    "\nЭтап 2: Подставляем в первообразную верхний и нижний пределы \n\n" +
                    "(" + a + " * " + borderA + "^3) / 3 + (" + b + " * " + borderA + "^2) / 2" + " = " + Fa + "\n" +
                    "(" + a + " * " + borderB + "^3) / 3 + (" + b + " * " + borderB + "^2) / 2" + " = " + Fb + "\n" +
                    "\nЭтап 3: Вычисляем интеграл \n\n" +
                    Fb + " - " + Fa + " = " + Integral + "\n" +
                    Integral + " и является площадью заданной фигуры"));
            }
            else if (a != 0 && b == 0 && c != 0)
            {
                MessageBox.Show(String.Format("Этап 1: Находим первообразную функции \n\n" +
                    "∫(" + a + "x^2" + " + " + c + ")dx    при а = " + borderA + " и b = " + borderB + "\n" +
                    "∫(" + a + "x^2" + " + " + c + ")dx = (" + a + " * x^3) / 3 + " + c + "x \n" +
                    "\nЭтап 2: Подставляем в первообразную верхний и нижний пределы \n\n" +
                    "(" + a + " * " + borderA + "^3) / 3 + " + c + borderA + " = " + Fa + "\n" +
                    "(" + a + " * " + borderB + "^3) / 3 - " + c + borderB + " = " + Fb + "\n" +
                    "\nЭтап 3: Вычисляем интеграл \n\n" +
                    Fb + " - " + Fa + " = " + Integral + "\n" +
                    Integral + " и является площадью заданной фигуры"));
            }
            else if (a == 0 && b != 0 && c != 0)
            {
                MessageBox.Show(String.Format("Этап 1: Находим первообразную функции \n\n" +
                    "∫(" + b + "x" + " + " + c + ")dx    при а = " + borderA + " и b = " + borderB + "\n" +
                    "∫(" + b + "x" + " + " + c + ")dx = (" + b + " * x^2) / 2 + " + c + "x \n" +
                    "\nЭтап 2: Подставляем в первообразную верхний и нижний пределы \n\n" +
                    "(" + b + " * " + borderA + "^2) / 2 + " + c + borderA + " = " + Fa + "\n" +
                    "(" + b + " * " + borderB + "^2) / 2 + " + c + borderB + " = " + Fb + "\n" +
                    "\nЭтап 3: Вычисляем интеграл \n\n" +
                    Fb + " - " + Fa + " = " + Integral + "\n" +
                    Integral + " и является площадью заданной фигуры"));
            }
            else { MessageBox.Show("Некорректный ввод данных"); }
        }

        public void ExpWord_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Word.Application wordApp = new Word.Application();
            //    wordApp.Visible = true;
            //    Word.Document doc = wordApp.Documents.Add();
            //    Word.Paragraph xs = doc.Content.Paragraphs.Add();
            //    xs.Range.Text = Convert.ToString(Integral);
            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка при экспорте");
            //}

            try
            {
                // Создание экземпляра приложения Word
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = true;

                // Создание нового документа Word
                Word.Document doc = wordApp.Documents.Add();


                Word.Paragraph integral = doc.Content.Paragraphs.Add();
                integral.Range.Text = $"текст";
                integral.Range.Text = Convert.ToString(Integral);



                // Сохранение документа
                object fileName = @"C:\Users\Huawei\source\repos\Integral_Figures\solve.docx";
                doc.SaveAs2(fileName);
                doc.Close();

                // Освобождение ресурсов
                System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
            }
            catch { MessageBox.Show("Ошибка экспорта"); }
        }
        private void ExpExcel_Click(object sender, EventArgs e)
        {
            //Excel.Application excelApp = new Excel.Application();
            //excelApp.Visible = true;
            //excelApp.Workbooks.Add();
            //Excel.Workbook workbook = excelApp.Workbooks.Add();
            //Excel.Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;
            //

            try
            {
                // Создание экземпляра приложения Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                // Создание новой книги Excel
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

                // Запись данных в ячейку
                worksheet.Cells[1, 1] = Integral;

                // Проверка на невырожденность системы
                //integral.Value = $"Площадь равна {Integral}";

                // Сохранение книги
                object fileName = @"C:\Users\Huawei\source\repos\Integral_Figures\solve.xlsx";
                workbook.SaveAs(fileName);
                workbook.Close();

                // Освобождение ресурсов
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
            catch { MessageBox.Show("Ошибка экспорта"); }
        }

        private void ImpExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //Excel.Application excelApp = new Excel.Application();
                //excelApp.Visible = true;

                //// Создание новой книги Excel
                //Excel.Workbook workbook = excelApp.Workbooks.Add();
                //Excel.Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

                // Создание экземпляра приложения Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;

                // Открытие книги Excel
                object fileName = @"C:\Users\Huawei\source\repos\Integral_Figures\data.xlsx";
                Excel.Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\Huawei\source\repos\Integral_Figures\data.xlsx");
                Excel.Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

                // Чтение значения из ячейки
                //Excel.Range A = worksheet.Cells[1, 1];
                //Excel.Range B = worksheet.Cells[1, 2];
                //Excel.Range C = worksheet.Cells[1, 3];
                //Excel.Range BorderA = worksheet.Cells[1, 4];
                //Excel.Range BorderB = worksheet.Cells[2, 1];

                //string Aw = A.Value?.ToString();
                //string Bw = B.Value?.ToString();
                //string Cw = C.Value?.ToString();
                //string BorderAw = BorderA.Value?.ToString();
                //string BorderBw = BorderB.Value?.ToString();

                // Закрытие книги
                workbook.Close();

                // Освобождение ресурсов
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                // Отображение импортированного текста в TextBox
                //textBoxA.Text = Aw;
                //textBoxB.Text = Bw;
                //textBoxC.Text = Cw;
                //textBoxBorderA.Text = BorderAw;
                //textBoxBorderB.Text = BorderBw;
            }
            catch { MessageBox.Show("Ошибка импорта"); }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
