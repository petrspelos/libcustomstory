# libcustomstory

libcustomstory is a C# wrapper for Amnesia: The Dark Descent's XML resources

⚠ This software is still in development, **MAKE SURE TO BACKUP THE FILES YOU EDIT WITH THIS LIBRARY**.

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

- Read > Write does not preserve the original blank lines. _(not a big deal, but you should know about it)_

## Can I help?

Yes, Pull Requests are welcomed.

There is plenty of things to improve. You can do one of two things:

- Value Type Verification

There are `// @verify` comments throughout the entities before attributes that are assumed to be a certain type, but it's unclear wheter they can be a different type.

This can be figured out by viewing the [LevelEditor source code](https://github.com/FrictionalGames/AmnesiaTheDarkDescent/tree/master/HPL2/tools/editors/leveleditor) and looking for this value.

- Helper Methods

You can also write extension methods on top of entities for ease of use.

For example to change a position while ensuring the format stays correct, or adding an item into a collection without having to invoke a constructor of the target entity...
