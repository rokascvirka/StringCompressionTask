using System;

namespace StringCompressionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var compress = new Compress();

            var word = compress.CompressString("kkkktttrrrrrrrrrr");
        }
    }
}
