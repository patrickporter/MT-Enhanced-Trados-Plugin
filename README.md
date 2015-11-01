# MT Enhanced Trados Plugin

A plugin for SDL Trados Studio that allows connecting to Google Translate or Microsoft Translator, with additional features like batch find/replace in both directions.

To build, <b>it is necessary to add a strong name key file</b> to the project, and that key file <b>must</b> be named 'myKey.snk' (or otherwise change the name pointed to in the project properties, under 'Signing')

Also add the necessary SDL references to the SDL_references folder (see references_readme.txt in that folder)

The solution and project target 3 versions of SDL Trados Studio (2011, 2014, and 2015) with one Visual Studio project.  The code is the same for all versions, but the plugin must be built against different library versions and different .NET framework versions.

Read <a href="http://www.linguisticproductions.com/target-all-versions-of-trados-studio-with-a-single-plugin-project" target="_blank">here</a> for more info on targeting multiple versions of Trados Studio with a single Visual Studio project.
