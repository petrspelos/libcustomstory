using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class MapData
    {
        [XmlAttribute("FogActive")]
        public bool FogActive { get; set; }

        [XmlAttribute("FogColor")]
        public string FogColor { get; set; }

        [XmlAttribute("FogCulling")]
        public bool FogCulling { get; set; }

        // @verify
        [XmlAttribute("FogEnd")]
        public float FogEnd { get; set; }

        // @verify
        [XmlAttribute("FogFalloffExp")]
        public float FogFalloffExp { get; set; }

        // @verify
        [XmlAttribute("FogStart")]
        public float FogStart { get; set; }

        // @verify
        [XmlAttribute("GlobalDecalMaxTris")]
        public int GlobalDecalMaxTris { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("SkyBoxActive")]
        public bool SkyBoxActive { get; set; }

        [XmlAttribute("SkyBoxColor")]
        public string SkyBoxColor { get; set; }

        [XmlAttribute("SkyBoxTexture")]
        public string SkyBoxTexture { get; set; }

        [XmlElement("MapContents")]
        public MapContents MapContents { get; set; }
    }
}
