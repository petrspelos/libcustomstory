# libcustomstory

libcustomstory is a C# wrapper for Amnesia: The Dark Descent's XML resources

## Usage

> For more detailed usage, checkout `src/LibCustomStory.Tests`

```cs
// Example: Read from file
var customStorySettings = AmnesiaResources.CustomStorySettingsFromFile("custom_story_settings.cfg");

// Example: Modify a value
customStorySettings.Name = "New Custom Story Name";

// Example: Write modified value
AmnesiaResources.WriteToFile(customStorySettings, "custom_story_settings.cfg");
```

## Known issues

- Read > Write does not preserve the original blank lines. _(not a big deal, but you should know it)_
