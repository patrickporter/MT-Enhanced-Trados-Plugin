5 references must be placed in this folder to build the project:

Sdl.Core.Globalization.dll
Sdl.Core.PluginFramework.dll
Sdl.LanguagePlatform.Core.dll
Sdl.LanguagePlatform.TranslationMemory.dll
Sdl.LanguagePlatform.TranslationMemoryApi.dll

These can be any version, because there are MSBuild tasks in the project that will replace these with the correct ones, according to the build version selected in the Drop-Down.

The locations of the correct references are as follows:

Builds targeting Trados Studio 2011:
(ProgramFiles (x86))\SDL\SDL Trados Studio\Studio2

Builds targeting Trados Studio 2014:
(ProgramFiles (x86))\SDL\SDL Trados Studio\Studio3

Builds targeting Trados Studio 2015:
(ProgramFiles (x86))\SDL\SDL Trados Studio\Studio4

You must have the corresponding version of Trados Studio installed on your development machine for the build task to find these references in the above locations or the project won't build.