using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class Performance
    {
        [XmlAttribute("CamClipPlanes")]
        public string CamClipPlanes { get; set; }

        [XmlAttribute("LightsActive")]
        public bool LightsActive { get; set; }

        [XmlAttribute("PSActive")]
        public bool PsActive { get; set; }

        [XmlAttribute("ShowFog")]
        public bool ShowFog { get; set; }

        [XmlAttribute("ShowSkybox")]
        public bool ShowSkybox { get; set; }

        [XmlAttribute("WorldReflection")]
        public bool WorldReflection { get; set; }
    }
}