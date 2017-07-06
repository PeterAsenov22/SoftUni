namespace Copy_Binary_File
{
    using System.IO;

    public class CopyBinaryFile
    {
        private const string DoggoImagePath = "../../doggo.jpg";
        private const string DestitinationPath = "../../result.jpg";

        public static void Main()
        {
            using (var source = new FileStream(DoggoImagePath, FileMode.Open))
            {
                using (var destination = new FileStream(DestitinationPath, FileMode.Create))
                {
                    var buffer = new byte[4096];

                    while (true)
                    {
                        var readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer,0,readBytes);
                    }
                }
            }
        }
    }
}
