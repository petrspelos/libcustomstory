using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    [XmlType("StaticObject")]
    public class StaticObject
    {
        [XmlAttribute("CastShadows")]
        public bool CastShadows { get; set; }

        [XmlAttribute("Collides")]
        public bool Collides { get; set; }

        [XmlAttribute("FileIndex")]
        public int FileIndex { get; set; }

        [XmlAttribute("Group")]
        public int Group { get; set; }

        [XmlAttribute("ID")]
        public int Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Rotation")]
        public string Rotation { get; set; }

        [XmlAttribute("Scale")]
        public string Scale { get; set; }

        // @verify
        [XmlAttribute("Tag")]
        public string Tag { get; set; }

        [XmlAttribute("WorldPos")]
        public string WorldPos { get; set; }
    }
}
