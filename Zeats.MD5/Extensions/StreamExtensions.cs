using System.IO;

namespace Zeats.MD5.Extensions;

public static class StreamExtensions
{
    public static byte[] ComputeHash(this Stream stream)
    {
        using var md5 = System.Security.Cryptography.MD5.Create();

        return md5.ComputeHash(stream);
    }
}