using System.Collections.Generic;
using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities
{
    [XmlRoot("Main")]
    public class CustomStorySettings
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Author")]
        public string Author { get; set; }

        [XmlAttribute("ImgFile")]
        public string ImgFile { get; set; }

        [XmlAttribute("MapsFolder")]
        public string MapsFolder { get; set; }

        [XmlAttribute("StartMap")]
        public string StartMap { get; set; }

        [XmlAttribute("StartPos")]
        public string StartPos { get; set; }

        [XmlAttribute("ExtraLangFilePrefix")]
        public string ExtraLangFilePrefix { get; set; }

        [XmlAttribute("DefaultExtraLangFile")]
        public string DefaultExtraLangFile { get; set; }
    }
}
