# MultiProjectConfig
How to set up a solution with multiple projects, each with their own settings



Problem - You might have a solution with many projects and some of those projects have settings.  However there can only be one .exe.config file that can be edited. The project settings need to go in there. 

Here’s how to do it:
In your project:
  -Add a custom settings file (Right-click project - then Add New… - then ‘Settings File’ - Give custom name
  -Add some settings to the settings file
  -Compile the project
  -You’ll then see an ‘app.config’ file for that project.  (see fig1 below)
  -Consider this ‘app.config’ as a copy source, that will be copied into the main apps ‘App.Config’

In the Main app:
  -Copy the contents of the ‘app.config’ from the project to the App.Config of the main app
  -(Pay attention to any section groups that might already be present)

