using System.IO;
using System.Linq;
using System.Xml.Serialization;
using LibCustomStory.Core;
using LibCustomStory.Core.Entities;
using Xunit;

namespace LibCustomStory.Tests
{
    public class XmlParseTests
    {
        private const string customStorySettingsFile = "samples/custom_story_settings.cfg";
        private const string sampleLanguageFile = "samples/extra_english.lang";
        private const string sampleMapFile = "samples/sample.map";

        [Fact]
        public void ConfigParseTest()
        {
            var settings = AmnesiaResources.CustomStorySettingsFromFile(customStorySettingsFile);

            Assert.NotNull(settings);
            Assert.Equal("My Custom Story", settings.Name);
            Assert.Equal("Author's Name", settings.Author);
            Assert.Equal("image.png", settings.ImgFile);
            Assert.Equal("maps/", settings.MapsFolder);
            Assert.Equal("mapname.map", settings.StartMap);
            Assert.Equal("PlayerStartArea_1", settings.StartPos);
            Assert.Equal("extra_", settings.ExtraLangFilePrefix);
            Assert.Equal("english.lang", settings.DefaultExtraLangFile);
        }

        [Fact]
        public void LanguageFileParseTest()
        {
            var lang = AmnesiaResources.LanguageResourcesFromFile(sampleLanguageFile);

            Assert.NotNull(lang);
            Assert.NotNull(lang.Resources);
            Assert.Equal(5, lang.Categories.Count);
            Assert.Equal("Description", lang.Categories.First(c => c.Name == "CustomStoryMain").Entries.First().Name);
            Assert.Equal("Custom Story Description", lang.Categories.First(c => c.Name == "CustomStoryMain").Entries.First().Content);
        }

        [Fact]
        public void MapFileParseTest()
        {
            var map = AmnesiaResources.LevelFromFile(sampleMapFile);

            Assert.NotNull(map);
            
            Assert.Equal("0.05 1000", map.EditorSession.Performance.CamClipPlanes);
            Assert.True(map.EditorSession.Performance.LightsActive);
            Assert.True(map.EditorSession.Performance.PsActive);
            Assert.True(map.EditorSession.Performance.ShowFog);
            Assert.True(map.EditorSession.Performance.ShowSkybox);
            Assert.True(map.EditorSession.Performance.WorldReflection);

            Assert.Equal("0.2 0.2 0.2 1", map.EditorSession.ViewportConfig.BgColor);
            Assert.False(map.EditorSession.ViewportConfig.GAmbientLight);
            Assert.False(map.EditorSession.ViewportConfig.GPointLight);
            Assert.False(map.EditorSession.ViewportConfig.GridSnap);
            Assert.Equal(0.25f, map.EditorSession.ViewportConfig.GridSnapSeparation, 2);

            Assert.Equal(4, map.EditorSession.ViewportConfig.Viewports.Count);

            Assert.Equal("38.75 0 179.5", map.EditorSession.ViewportConfig.Viewports[0].CameraPosition);
            Assert.Equal("218.75 0 -0.5", map.EditorSession.ViewportConfig.Viewports[1].CameraPosition);
            Assert.Equal("38.75 180 -0.5", map.EditorSession.ViewportConfig.Viewports[2].CameraPosition);
            Assert.Equal("40.6974 6.80259 1.38992", map.EditorSession.ViewportConfig.Viewports[3].CameraPosition);

            Assert.Single(map.EditorSession.Groups);
            Assert.Equal(0, map.EditorSession.Groups[0].Id);
            Assert.Equal("None", map.EditorSession.Groups[0].Name);
            Assert.True(map.EditorSession.Groups[0].Visible);

            Assert.False(map.MapData.FogActive);
            Assert.Equal("1 1 1 1", map.MapData.FogColor);
            Assert.Equal(20.0f, map.MapData.FogEnd, 2);
            Assert.False(map.MapData.SkyBoxActive);

            Assert.Equal(56, map.MapData.MapContents.StaticObjectsFileIndex.NumOfFiles);
            Assert.Equal(56, map.MapData.MapContents.StaticObjectsFileIndex.Files.Count);
            Assert.Equal(2, map.MapData.MapContents.StaticObjectsFileIndex.Files[2].Id);
            Assert.Equal("static_objects/decals/rose_petals.dae", map.MapData.MapContents.StaticObjectsFileIndex.Files[2].Path);

            Assert.Equal(55, map.MapData.MapContents.EntitiesFileIndex.NumOfFiles);
            Assert.Equal(55, map.MapData.MapContents.EntitiesFileIndex.Files.Count);

            Assert.Equal(8, map.MapData.MapContents.DecalsFileIndex.NumOfFiles);
            Assert.Equal(8, map.MapData.MapContents.DecalsFileIndex.Files.Count);

            Assert.Equal(707, map.MapData.MapContents.StaticObjects.Count);
            Assert.Equal(2382, map.MapData.MapContents.StaticObjects.Last().Id);
            Assert.Equal("wall_welder_stone_53", map.MapData.MapContents.StaticObjects.Last().Name);

            Assert.Equal(33, map.MapData.MapContents.Primitives.Count);
            Assert.Equal(2256, map.MapData.MapContents.Primitives.Last().Id);
            Assert.Equal("Plane_39", map.MapData.MapContents.Primitives.Last().Name);
            Assert.Equal("51.75 0 22.5", map.MapData.MapContents.Primitives.Last().WorldPos);

            Assert.Equal(46, map.MapData.MapContents.Decals.Count);
            Assert.Equal(2261, map.MapData.MapContents.Decals.Last().Id);
            Assert.Equal("dirt_stain_large_26", map.MapData.MapContents.Decals.Last().Name);
            Assert.Equal("57.3169 0.438897 29.1563", map.MapData.MapContents.Decals.Last().WorldPos);

            Assert.Equal("PathNode", map.MapData.MapContents.Entities.Areas.Last().AreaType);
            Assert.Equal(2380, map.MapData.MapContents.Entities.Areas.Last().Id);
        }
    }
}
