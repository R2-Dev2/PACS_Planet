using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Model;
using SoftwareCentral;

namespace FileUtils
{
    public class FileGenerator
    {
        readonly object sumTotalLock = new object();
        long sumTotal;

        public EncodingConfig config { get; set; }
        public Dictionary<string, string> codifications { get; set; }

        Thread tFiles, tZip, tEncoded, tCount;

        public void GenerateAndZipFiles()
        {
            tFiles = new Thread(GenerateFiles);
            tZip = new Thread(ZipFolder);

            tZip.Start();
            tFiles.Start();
        }

        public void EncodeFilesAndSum()
        {
            tEncoded = new Thread(GenerateEncodedFiles);
            tCount = new Thread(SumTotal);

            tCount.Start();
            tEncoded.Start();
        }

        private void GenerateFiles()
        {
            MyFileUtils.CreateOrEmptyDirectory(config.OriginalFilesPath);
            Parallel.For(0, config.NumFiles,
                index =>
                {
                    string originalPath = $@"{config.OriginalFilesPath}fitxer{index + 1}";
                    MyFileUtils.CreateAndWriteToTxt(originalPath, RandomCodeGenerator.GenerateRandomLetters(config.NumChars));
                });
        }

        private void GenerateEncodedFiles()
        {
            MyFileUtils.CreateOrEmptyDirectory(config.EncodedFilesPath);
            Parallel.For(0, config.NumFiles,
                index =>
                {
                    string originalPath = $"{config.OriginalFilesPath}fitxer{index + 1}";
                    string encodedPath = $"{config.EncodedFilesPath}fitxer{index + 1}";
                    ReadAndWriteCodification(originalPath, encodedPath);
                });
        }

        private void SumTotal()
        {
            if (tEncoded != null && tFiles.ThreadState != ThreadState.Unstarted)
            {
                tEncoded.Join();
            }
            sumTotal = 0;
            Parallel.For(0, config.NumFiles,
                index =>
                {
                    string encodedPath = $"{config.EncodedFilesPath}fitxer{index + 1}";
                    long sumFile = ReadAndSum(encodedPath);
                    lock (sumTotalLock)
                    {
                        sumTotal += sumFile;
                    }

                });

            OnSumFinished(sumTotal);
        }

        private void ReadAndWriteCodification(string originalPath, string encodedPath)
        {
            char letter;
            using (FileStream iStream = new FileStream($"{originalPath}.txt", FileMode.Open))
            using (FileStream oStream = new FileStream($"{encodedPath}.txt", FileMode.Create))
            using (StreamReader sr = new StreamReader(iStream))
            using (StreamWriter sw = new StreamWriter(oStream))
            {
                while ((letter = (char)sr.Read()) != '\r')
                {
                    sw.Write(codifications[letter.ToString()]);
                }
                sw.WriteLine();
            }
        }

        private long ReadAndSum(string filePath)
        {
            long sum = 0;
            int number;
            using (FileStream iStream = new FileStream($"{filePath}.txt", FileMode.Open))
            using (StreamReader sr = new StreamReader(iStream))
            {
                while ((number = sr.Read()) != '\r')
                {
                    sum += number;
                }
            }
            return sum;
        }

        private void ZipFolder()
        {
            if (tFiles != null && tFiles.ThreadState != ThreadState.Unstarted)
            {
                tFiles.Join();
            }

            string zipFile = $"{config.OriginalFilesPath}/files.zip";
            var files = Directory.GetFiles(config.OriginalFilesPath.ToString());

            if (File.Exists(zipFile))
            {
                File.Delete(zipFile);
            }

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                foreach (var fPath in files)
                {
                    archive.CreateEntryFromFile(fPath, Path.GetFileName(fPath));
                }
            }
            OnZipFinished(zipFile);
        }

        public class ZipFinishedEventArgs : System.EventArgs
        {
            public string path;
        }

        public event EventHandler ZipFinished;

        protected virtual void OnZipFinished(string path)
        {
            if (null != ZipFinished)
            {
                ZipFinishedEventArgs e = new ZipFinishedEventArgs();
                e.path = path;
                ZipFinished(this, e);
            }
        }

        public class SumFinishedEventArgs : System.EventArgs
        {
            public long sum;
        }

        public event EventHandler SumFinished;

        protected virtual void OnSumFinished(long sum)
        {
            if (null != SumFinished)
            {
                SumFinishedEventArgs e = new SumFinishedEventArgs();
                e.sum = sum;
                SumFinished(this, e);
            }
        }
    }
}
