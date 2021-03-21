using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using LibCustomStory.Core.Entities;

namespace LibCustomStory.Core
{
    public static class AmnesiaResources
    {
        public static CustomStorySettings CustomStorySettingsFromFile(string path)
        {
            var serializer = new XmlSerializer(typeof(CustomStorySettings));
            return (CustomStorySettings)serializer.Deserialize(File.OpenRead(path));
        }

        public static LanguageResources LanguageResourcesFromFile(string path)
        {
            var serializer = new XmlSerializer(typeof(LanguageResources));
            return (LanguageResources)serializer.Deserialize(File.OpenRead(path));
        }

        public static Level LevelFromFile(string path)
        {
            var serializer = new XmlSerializer(typeof(Level));
            return (Level)serializer.Deserialize(File.OpenRead(path));
        }

        public static void WriteToFile(CustomStorySettings settings, string outputFile) => SerializePureXml(settings, outputFile);

        public static void WriteToFile(LanguageResources settings, string outputFile) => SerializePureXml(settings, outputFile);

        private static void SerializePureXml<T>(T value, string file)
        {
            var serializer = new XmlSerializer(typeof(T));
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            using(var writer = XmlWriter.Create(File.OpenWrite(file), settings))
            {
                serializer.Serialize(writer, value, emptyNamespaces);
            }
        }
    }
}
