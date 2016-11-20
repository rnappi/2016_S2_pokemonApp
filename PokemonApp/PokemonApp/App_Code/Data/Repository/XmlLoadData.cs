using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PokemonApp.App_Code.Data.Repository
{
    public static class XmlLoadData
    {
        public static List<T> LoadXmlData<T>(string file)
        {
            List<T> list = new List<T>();
            if (File.Exists(file) && new FileInfo(file).Length > 0)
            {
                try
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<T>));
                    TextReader textReader = new StreamReader(file);
                    list = (List<T>)deserializer.Deserialize(textReader);
                    textReader.Close();
                }
                catch (Exception error)
                {
                    throw new Exception(error.Message);
                }
            }
            return list;
        }

        public static void SaveXmlData<T>(List<T> list, string file)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                TextWriter textWriter = new StreamWriter(file);
                serializer.Serialize(textWriter, list);
                textWriter.Close();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
    }
}