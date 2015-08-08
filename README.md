# MT Enhanced Trados Plugin

A plugin for SDL Trados Studio that allows connecting to Google Translate or Microsoft Translator, with additional features like batch find/replace in both directions.

To build, add a strongly-named key file to the project called 'myKey.snk'

Also add the necessary SDL references to the SDL_references folder (see references_readme.txt in that folder)

The solution and project target 3 versions of SDL Trados Studio (2011, 2014, and 2015) with one Visual Studio project.  The code is the same for all versions, but the plugin must be build against different library versions and different .NET framework versions.

Read [here](http://www.linguisticproductions.com/target-all-versions-of-trados-studio-with-a-single-plugin-project) for more info on targeting multiple versions of Trados Studio with a single Visual Studio project.
