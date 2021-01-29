using System;
using System.IO.Compression;

namespace _6.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            using ZipArchive zipFile = ZipFile.Open("../../../newzip.zip", ZipArchiveMode.Create);
            ZipArchiveEntry entry = zipFile.CreateEntryFromFile("../../../copyMe.png", "copyMe.png");
        }
    }
}
