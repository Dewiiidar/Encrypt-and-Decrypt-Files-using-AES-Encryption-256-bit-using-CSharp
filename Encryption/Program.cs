using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "dewi";
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);
            EncryptionManager E = new EncryptionManager();
            E.FileEncrypt(@"C:\Users\Dev-Lap-Dewidar\Encryption\test.mp3", password);
            gch.Free();

        }
    }
}
