using System.IO;

namespace Noobot.Core.MessagingPipeline.Response
{
    public class UploadMessage : ResponseMessage
    {
        public Stream Stream { get; }
        public string FileName { get; }
        public string FilePath { get; }
        public UploadType Type { get; set; }

        public UploadMessage(Stream stream, string fileName)
        {
            Stream = stream;
            FileName = fileName;
            Type = UploadType.Stream;
        }

        public UploadMessage(string filePath)
        {
            FilePath = filePath;
            Type = UploadType.Disk;
        }

        public enum UploadType
        {
            Disk,
            Stream
        }
    }
}