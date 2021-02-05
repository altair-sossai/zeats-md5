namespace Zeats.MD5.Extensions
{
    public static class ByteExtensions
    {
        public static byte[] ComputeHash(this byte[] bytes)
        {
            using var md5 = System.Security.Cryptography.MD5.Create();

            return md5.ComputeHash(bytes);
        }
    }
}