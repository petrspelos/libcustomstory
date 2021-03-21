using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class File
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }

        [XmlAttribute("Path")]
        public string Path { get; set; }
    }
}
