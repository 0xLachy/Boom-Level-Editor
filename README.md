# Boom Level Editor
This project is a way for making custom levels for the app "Boom!" by Happy Sprites which is an ios game [Boom Fandom Wiki](https://boomhappysprites.fandom.com/wiki/BOOM!_Wiki)

For help or to show us your level join our discord! 😄

[![Boom Community](https://discordapp.com/api/guilds/314722622422384640/widget.png?style=banner2)](https://discord.gg/EhEjNhu)

<!--
![https://www.happysprites.com/wp-content/uploads/2013/05/boom_feature.jpg](https://www.happysprites.com/wp-content/uploads/2013/05/boom_feature.jpg) 
-->
## Installation Guide
1. Download Unity Hub from [https://store.unity.com/download](https://store.unity.com/download)

2. clone this repository or download as a zip (then unzip) and put it in a folder where you want to keep your Unity projects e.g \<yourname>\Unity\Projects

3. In Unity Hub on the projects tab, click on *add* then go to wherever you saved this repo and double click on the repo folder, then press enter.
4. Once it is added, it may tell you that you are missing the unity version required, choose any version that is above 2020, if you don't have any, unity hub will help you download one, or go to the installs tab on the left, then click on *add* and then choose a 2020 version, you don't *need* any extra modules, but having visual studio may come in handy.
5. Now that you have all the requirements ready, double click on the project in the projects window in unity hub and you should be good to go! 😀
   
---

## How To Use
if you haven't used unity before I recommend watching a quick tutorial on how the unity layout works, you won't need to do any coding with the C# scripts though.

Every scene we make is a different level, there are quite a few on the github already so they can be pretty good examples.
### Creating A New Level
<!-- I'm not sure if the right click is right-->
To get started and to make your own level, in the scenes folder (in the bottom window) right click, then choose "create new scene"
it will create a new scene, for you, but before you click make sure to name it, so type in a new name and press enter.
![Create Scene](Assets/Resources/Github%20Guide%20Images/Create%20scene.png)
### Adding the sprites to the level
Down the bottom, if you go to the resources/textures folder, there is the sprites for the game, they are in a few seperate groups, to use a specific sprite, expand the group (press the small triangle on the right of the group image) It will look something like this:
![Expand Sprite Example](Assets/Resources/Github%20Guide%20Images/Expand%20Sprite%20Group.png)

To add the sprite, just drag it into the scene/level.

### Prefabs
>Knowing what A [Unity Prefab](https://docs.unity3d.com/Manual/Prefabs.html) is will help you understand this

Some sprites need a script added to them so they can be added to boom properly, or you can combine multiple into a shape you like so then you can create the shape quickly also some that you use heaps like the cage and wheel are added there to get them quicker.
Drag them in just like you would the other sprites.
![Prefabs](Assets/Resources/Github%20Guide%20Images/Prefabs.png)

### Ground
Adding ground to the level is a bit different to using other sprites. The SpriteShapeController that we use to make it in the scene is a bit buggy and if your points are too close together it will cause the export script to infinitely load the Unity Editor and you will have to stop Unity using task manager (ctrl+shift+escape, right click on unity and then end task)

To preven losing your progress, save before you export the level if you are using the SpriteShapeController in your level. If it exports fine, which it usually does, you don't have to save untill the next time you edit the spline again

To use the ground, drag in one of the ground prefabs, then to resize the ground **don't use the rect tool** but instead click on the button next to "Edit Spline" in the inspector window, then click on a point to move it, or click on the line between two points to create a new point. If you want to delete a point, click on the point, then press delete on your keyboard

### Physics Modifier
We have created a script that can create custom physics for objects, in order to use it, in the inspector pannel of the object you want to modify click on "Add Component" then search for the Boom Physics Modifier
![add component](Assets/Resources/Github%20Guide%20Images/Add%20Component1.png)
![search componnent](Assets/Resources/Github%20Guide%20Images/Search%20Component.png)

After you Add it, the inspector will have another vertical tab containing the physics properties, here is one that I have for a flying spike!

![Physic Properties](Assets/Resources/Github%20Guide%20Images/Physics%20Properties.png)

if you don't knowwhat something does, hover your mouse over the name and Unity will give a tooltip explaining it.

### Tags 
In the inspecter right under the name, where it says "Tag Untagged" if you click that untagged you will see there are a few tags made. If you give a sprite a tag, it will overwrite the in game tag, to be a tag of another sprite, so if you give a coin a "bomb" tag, it will act like a bomb when hit in game. (There are a few tags that unity has their by default, just ignore them) 
![Unity Tag Example](Assets/Resources/Github%20Guide%20Images/Unity%20Tag%20Example.png)

### Quicksand and Big Wheel
quicksand and the big wheel powerup were in the games files but unreleased, because of that they are a bit buggy and big wheel doesn't actually have a sprite image. To use them just drag in the prefab like you would the other stuff.

### Exporting the level
Currently you can't play the level in the unity editor just yet. To play and test the level out, you need to play it in the custom ipa from github or the discord. Go to [https://boom.markstam.eu/](https://boom.markstam.eu/) to get the app.

First thing you need to do is export the level, up in the top, go to boom >> export PLHS. Or you can press ctrl+g

![Export Level](Assets/Resources/Github%20Guide%20Images/Export%20Level.png)

The level will be stored as plhs (which is just a plist file) in the *Levels* folder, to find the level just go to wherever you saved the project and you should see *Levels* next to the *Assets* folder.

---

## Testing/Playing the level
<!-- add link to take you to the Add to Ipa script-->
There are a few methods for testing the level, you can set up a local server on your computer or you can use discord. The Ipa method involves reinstalling the ipa, which isn't much of a hastle if your jailbroken, but takes the longest to do.

### Steps for running a local server
1. Make sure you have Python3 installed and on the path, (Python will automatically be added to the path usually)
2. Open up Powershell or Bash then type `cd '/Path-To-Levels'` where the path is the location of your levels directory, you can find it in file explorer by clicking up the top like this: ![Path From File Explorer](Assets/Resources/Github%20Guide%20Images/File%20Explorer.png) If your path was the one in the image, the command would be `cd 'C:\Users\Lachl\Github\Boom-Level-Editor\Levels'`
3. Find out what IP adress you have, in powershell run the command `ipconfig` or in bash run `ip addr show` you want the ipv4 adress, if there are multiple, any of them should work. I use the wireless one usually.
4. run `python -m http.server` (if that doesn't work, try py, or python3 -m http.server). 
5. Now that the server has started, on your device that has boom installed and go on a web browser, go to http://\<IpAddress>:\<port> by default the port is 8000, if the port is already being used by something, run `python -m http.server <freePort>`
6. It should show a file listing of all the levels in the level folder, tap and hold on the level you want to play, then copy link address, then go to boom and click on "Level URL" in custom settings, then paste the link in the text box that shows up ![Boom Settings](Assets/Resources/Github%20Guide%20Images/Boom%20Settings.png)
7. Go to any level that you don't care about the ghost and have fun! The good thing about having the local server, is that every time you export the level, it will update the file on the local server automatically, all you need to do to update the level in boom is exit the level and go back in.

Once understand how to do it, it is definitely the easiest way to test your level, but it can be even faster to set up. 
>[Good tutorial on powershell aliases, functions and profile](https://youtu.be/0Rl_V079HEw)

1. In Powershell, to make sure you can use the function every time you open a new powershell window, you need a profile, to check if you have a profile already run `Test-Path $Profile` if it returns false then run `New-Item -Path $Profile -ItemType File -Force` to create one. 
2. Open your profile with a text editor `notepad $Profile`
3. Paste this code into your profile, replace \<Path-To-Levels-Folder> with the path from explorer (leave the apostrophes) and save, In .bash_aliasas it is almost the same, but swap Set-Location with cd and Select-String with grep.
```Powershell
function boomserv()
{
    Set-Location '<Path-To-Levels-Folder>'
    ipconfig | Select-String "IPv4"
    python -m http.server
}
``` 
Now close powershell and reopen it, if you run `boomserv` it should work now. You still need to do steps 5-7.

### Discord Method
The discord method is okay if you don't plan on updating your level very often and the good thing about it is that discord will host the file for you and will only go away if you delete the file, but it also means that everytime you make a change to the level and export it in the level editor you need to redo steps 2+

1. Create a new server for yourself in discord
2. In one of the text channels you can either drag in the level from file explorer, or in the message thing down the bottom click the plus icon and find the level.
3. Right Click on the message and click "copy link" (make sure you don't click copy message link). ![Discord Copy Link](Assets/Resources/Github%20Guide%20Images/Discord%20Download.png)
4. The link is usually super long so using a link shortener is handy, a good website is [bombch.us](http://bombch.us)
5. In the "Level URL" box in the settings part inside the boom app, put the new shortened link. 
6. Choose any level that you don't care about the ghost.
   
### Ipa Method
<!--Improve this, I am not happy with it-->
Putting your level in the ipa means you don't need to use a link to load the level and you can have it with its own ghost and targets and stuff. The easiest way to get it in game is with the "Add to Ipa" which is at Boom>Add to Ipa. But currently it is broken and the settings file isn't working properly so once that is fixed I will update this section on how to add it to the Ipa.


