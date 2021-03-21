using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    [XmlType("Plane")]
    public class Plane
    {
        [XmlAttribute("Active")]
        public bool Active { get; set; }

        [XmlAttribute("AlignToWorldCoords")]
        public bool AlignToWorldCoords { get; set; }

        [XmlAttribute("CastShadows")]
        public bool CastShadows { get; set; }

        [XmlAttribute("Collides")]
        public bool Collides { get; set; }

        [XmlAttribute("Corner1UV")]
        public string Corner1Uv { get; set; }

        [XmlAttribute("Corner2UV")]
        public string Corner2Uv { get; set; }

        [XmlAttribute("Corner3UV")]
        public string Corner3Uv { get; set; }

        [XmlAttribute("Corner4UV")]
        public string Corner4Uv { get; set; }

        [XmlAttribute("EndCorner")]
        public string EndCorner { get; set; }

        [XmlAttribute("Group")]
        public int Group { get; set; }

        [XmlAttribute("ID")]
        public int Id { get; set; }

        [XmlAttribute("Material")]
        public string Material { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Rotation")]
        public string Rotation { get; set; }

        [XmlAttribute("Scale")]
        public string Scale { get; set; }

        [XmlAttribute("StartCorner")]
        public string StartCorner { get; set; }

        [XmlAttribute("Tag")]
        public string Tag { get; set; }

        [XmlAttribute("TextureAngle")]
        public float TextureAngle { get; set; }

        [XmlAttribute("TileAmount")]
        public string TileAmount { get; set; }

        [XmlAttribute("TileOffset")]
        public string TileOffset { get; set; }

        [XmlAttribute("WorldPos")]
        public string WorldPos { get; set; }
    }
}
