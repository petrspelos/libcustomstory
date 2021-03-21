using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class Entity
    {
        [XmlAttribute("Active")]
        public bool Active { get; set; }

        [XmlAttribute("ID")]
        public int Id { get; set; }
    }
}
