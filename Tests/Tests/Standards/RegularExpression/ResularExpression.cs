namespace Tests.Standards.RegularExpression
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Summary description for WindowsFoldersTest
    /// </summary>
    [TestClass]
    public class RegularExpression

    {

        [TestMethod]
        public void GetWindowsKnownFolders()
        {

            string[] file = File.ReadAllLines(@"..\..\..\Tests\Standards\RegularExpression\File.txt");
            Regex rex = new Regex(@"[A-Za-z]*[^0-9]\.\w+\.\w+");

            List<string> newFile = new List<string>();
            for (int i = 0; i < file.Length; i++)
            {
                if (rex.IsMatch(file[i]))
                {
                    newFile.Add(file[i].Replace(rex.Match(file[i]).Value, "helo.helo.helo"));
                }
                else
                {
                    newFile.Add(file[i]);
                }
            }
            StringBuilder allText = new StringBuilder();

            
            foreach (string line in newFile)
            {

                allText.AppendLine(line.ToString());
            }

            File.WriteAllText(@"..\..\..\Tests\Standards\RegularExpression\File.txt", allText.ToString());
        }
    }
}
