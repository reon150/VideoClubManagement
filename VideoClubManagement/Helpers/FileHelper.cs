using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VideoClubManagement.Helpers
{
    public static class FileHelper
    {        
        public static void ExportToCSV(string fileName, List<string> lines)
        {
            try
            {
                var directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "exportedfiles");
                var filePath = Path.Combine(directoryPath, fileName);

                Directory.CreateDirectory(directoryPath);

                using (StreamWriter streamWriter = new StreamWriter(filePath, false, Encoding.UTF32))
                {
                    streamWriter.WriteLine("sep=,");
                    foreach (string line in lines) streamWriter.WriteLine(line);
                    Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error intentando exportar el archivo { fileName }{ Environment.NewLine }{ ex.Message }",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }          
        }
    }
}
