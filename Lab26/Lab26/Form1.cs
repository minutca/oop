using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Lab26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string templatePath = @"C:\Lab26\gramota.docx";

                Word.Application wordApp = new Word.Application();

                Word.Document document =
                    wordApp.Documents.Add(templatePath);

                FindAndReplace(wordApp, "<<NAME>>", txtName.Text);
                FindAndReplace(wordApp, "<<REASON>>", txtReason.Text);
                FindAndReplace(wordApp, "<<DATE>>", txtDate.Text);

                wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Помилка: " + ex.Message,
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void FindAndReplace(
            Word.Application wordApp,
            object findText,
            object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(
                ref findText,
                ref matchCase,
                ref matchWholeWord,
                ref matchWildCards,
                ref matchSoundsLike,
                ref matchAllWordForms,
                ref forward,
                ref wrap,
                ref format,
                ref replaceWithText,
                ref replace
            );
        }
    }
}