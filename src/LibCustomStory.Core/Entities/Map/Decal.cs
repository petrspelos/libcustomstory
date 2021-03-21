using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    [XmlType("Decal")]
    public class Decal
    {
        [XmlAttribute("Active")]
        public bool Active { get; set; }

        [XmlAttribute("Color")]
        public string Color { get; set; }

        [XmlAttribute("CurrentSubDiv")]
        public int CurrentSubDiv { get; set; }

        [XmlAttribute("Group")]
        public int Group { get; set; }

        [XmlAttribute("ID")]
        public int Id { get; set; }

        [XmlAttribute("MaterialIndex")]
        public int MaterialIndex { get; set; }

        [XmlAttribute("MaxTriangles")]
        public int MaxTriangles { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Offset")]
        public float Offset { get; set; }

        [XmlAttribute("OnEntity")]
        public bool OnEntity { get; set; }

        [XmlAttribute("OnPrimitive")]
        public bool OnPrimitive { get; set; }

        [XmlAttribute("OnStatic")]
        public bool OnStatic { get; set; }

        [XmlAttribute("Rotation")]
        public string Rotation { get; set; }

        [XmlAttribute("Scale")]
        public string Scale { get; set; }

        [XmlAttribute("SubDiv")]
        public string SubDiv { get; set; }

        [XmlAttribute("Tag")]
        public string Tag { get; set; }

        [XmlAttribute("WorldPos")]
        public string WorldPos { get; set; }

        [XmlElement("DecalMesh")]
        public DecalMesh DecalMesh { get; set; }
    }
}
