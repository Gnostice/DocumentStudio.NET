using System.Data;
using Gnostice.MailMerge;

namespace WinForms_CS_MailMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMerge mailMerge = new MailMerge();  

            #region DataTable Preparation
            DataTable dataSource = new DataTable();
            dataSource.Columns.Add("SenderName", typeof(string));
            dataSource.Columns.Add("ToName", typeof(string));

            dataSource.Rows.Add("me", "Alice");
            dataSource.Rows.Add("me", "Bob");
            dataSource.Rows.Add("me", "John");
            #endregion

            // Input document template
             mailMerge.TemplateFileName = @"..\..\04. Mail-Merge\Console Application\input\Letter.docx";

            // Input datasource
            mailMerge.DataSource = dataSource;

            // Set cleanup options
            mailMerge.MailMergeCleanupOptions = MailMergeCleanupOptions.RemoveUnmappedFields;

            // Set save action
            SaveToFileAction action = new SaveToFileAction(@".\", 
                "Letter to <<ToName>>");

            // Perform the mail merge
            mailMerge.Merge(action);
        }
    }
}
