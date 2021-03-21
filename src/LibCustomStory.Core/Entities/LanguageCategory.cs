using System.Xml.Serialization;
using System.Collections.Generic;

namespace LibCustomStory.Core.Entities
{
    public class LanguageCategory
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        
        [XmlElement("Entry")]
        public List<LanguageEntry> Entries { get; set; }
    }
}