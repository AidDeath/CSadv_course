using System;
using System.IO;
using System.Text.Json;

namespace SerializationDll
{
    public static class Serializer
    {
        public static string SerializeToFile<T>(T data, string path)
        {
            try
            {
                using (var fileStream = new FileInfo(path).Open(FileMode.OpenOrCreate))
                    JsonSerializer.SerializeAsync(fileStream, data);
                return "Serialization was successfull";
            }
            catch (Exception)
            {
                return "Serialization failed";
            }
        }
    }
}
