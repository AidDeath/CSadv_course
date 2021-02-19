using System;
using System.IO;
using System.Text.Json;

namespace SerializationDll
{
    public static class Deserializer
    {
        public static T DeserializeFromFileFile<T>(string path) where T : class
        {
            try
            {
                using (var fileStream = new FileInfo(path).Open(FileMode.Open))
                return JsonSerializer.Deserialize<T>(new StreamReader(fileStream).ReadToEnd());
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
