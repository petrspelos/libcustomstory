using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities
{
    public class LanguageEntry
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlText]
        public string Content { get; set; }
    }
}
