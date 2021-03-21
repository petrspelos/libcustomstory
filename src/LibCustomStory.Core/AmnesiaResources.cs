using System;
using System.IO;
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
    }
}
