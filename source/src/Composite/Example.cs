namespace Zbw.DesignPatterns.Composite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Example
    {
        public void FileSystemShowCase()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\data");
            FileInfo fileInfo = new FileInfo(@"C:\data\my-file.txt");
        }
    }
}
