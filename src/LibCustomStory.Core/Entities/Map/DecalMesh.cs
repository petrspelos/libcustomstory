using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class DecalMesh
    {
        [XmlAttribute("NumInds")]
        public int NumInds { get; set; }

        [XmlAttribute("NumVerts")]
        public int NumVerts { get; set; }

        [XmlElement("Positions")]
        public ArrayProperty Positions { get; set; }

        [XmlElement("Normals")]
        public ArrayProperty Normals { get; set; }

        [XmlElement("Tangents")]
        public ArrayProperty Tangents { get; set; }

        [XmlElement("TexCoords")]
        public ArrayProperty TexCoords { get; set; }

        [XmlElement("Indicies")]
        public ArrayProperty Indicies { get; set; }
    }
}
