using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ubåtspill
{
    class HelperClass
    {
        /// <summary>
        /// Writes the given object instance to an XML file.
        /// <para>Only Public properties and variables will be written to the file. These can be any type though, even other classes.</para>
        /// <para>If there are public properties/variables that you do not want written to the file, decorate them with the [XmlIgnore] attribute.</para>
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the file.</typeparam>
        /// <param name="data">The object instance to write to the file.</param>
        public static void SkrivXmlFile<T>(T data) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(FilePath, false);
                serializer.Serialize(writer, data);
            }
            finally
            {
                writer?.Close();
            }
        }

        /// <summary>
        /// Reads an object instance from an XML file.
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object to read from the file.</typeparam>
        /// <returns>Returns a new instance of the object read from the XML file.</returns>
        public static T ReadFromXmlFile<T>() where T : new()
        {
            if (!File.Exists(FilePath))
            {
                var data = new List<Highscore>();
                SkrivXmlFile(data);
            }

            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(FilePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                reader?.Close();
            }
        }

        private static string FilePath
        {
            get
            {
                //string path = Directory.
                //    GetParent(Environment.
                //    GetFolderPath(Environment.SpecialFolder.ApplicationData)).;
                string mappe = Path.Combine(Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData), "ubåt");

                string filbane =  $@"{mappe}\data.xml";
                
                //Lager mappe om den ikke finnes fra før
                if(!Directory.Exists(mappe))
                {
                    Directory.CreateDirectory(mappe);
                }

                return filbane;
            }
        }
    }
}
