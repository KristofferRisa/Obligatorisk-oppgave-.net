using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Domain.Models;

namespace Domain.Data
{
    /*
     * I need to rethink this soultion. 
     * 
     */
    public class DataContext
    {
        public void GetBookings()
        {
            HelperClass.ReadFromXmlFile<List<Booking>>();
        }

        public void SaveBookings()
        {
            
        }

        public void GetAvailaleDates()
        {
            
        }

    }

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
        public static void WriteXmlFile<T>(T data) where T : new()
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
                WriteXmlFile(new List<Booking>());
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
                string filbane = $@".\data\bookings.xml";
                
                return filbane;
            }
        }
    }

}
