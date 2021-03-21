using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class Viewport
    {
        [XmlAttribute("CameraPosition")]
        public string CameraPosition { get; set; }

        [XmlAttribute("CameraTarget")]
        public string CameraTarget { get; set; }

        [XmlAttribute("CameraZoom")]
        public float CameraZoom { get; set; }

        [XmlAttribute("GridHeight")]
        public float GridHeight { get; set; }

        [XmlAttribute("GridPlane")]
        public int GridPlane { get; set; }

        [XmlAttribute("Preset")]
        public int Preset { get; set; }

        [XmlAttribute("RenderMode")]
        public int RenderMode { get; set; }

        [XmlAttribute("ShowAxes")]
        public bool ShowAxes { get; set; }

        [XmlAttribute("ShowGrid")]
        public bool ShowGrid { get; set; }

        [XmlAttribute("UsingLTCam")]
        public bool UsingLtCam { get; set; }
    }
}
