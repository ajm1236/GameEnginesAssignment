# GameEnginesAssignment  
Name: Adam Moen  
Student Number: C19318671  
Class Group: TU857  
Video:  
[NonVR build of Doctor Who Intro](https://youtu.be/8IJ8Xewr1aA)  
[VR build of Doctor Who Intro](https://youtu.be/nG2JfPfZ_JM)

# Description of the Project  
Inspired by the intro to the classic British sci-fi show 'Doctor Who' ([4th Doctor Who Intro](https://www.youtube.com/watch?v=1fnzcAFy8d8&ab_channel=DoctorWho))  
([9th Doctor Who Intro](https://www.youtube.com/watch?v=z75qvDtbxjQ&ab_channel=DoctorWho))
this project loosely recreates the time vortex in which The Doctor, their comapanion(s) and their time travelling spaceship, the TARDIS (Time and Relative Dimensions in Space) fly through the time vortex and their way to their next adventure.  
  
Users will be able to see the TARDIS fly through a multicoloured Time Vortex, and take control of the TARDIS which is outlined below.  
# Instructions For Use
 - The up and down arrow keys control the distance in which the TARDIS is from the Main Camera.  
 - The left and right arrow keys control the speed of rotation of the TARDIS (can rotate either way, by default it is already rotating anti-clockwise).  
 - 'W' & 'S' control the speed of the Time Vortex.
 - Pressing the 'R' key will reset the speeds, the distance, and the rotation.  
 - Pressing Spacebar will invoke one of two sound effects: the TARDIS takeoff sound, or the TARDIS landing sound. It is set to randomly choose one when button pressed.  
 - Press 'ESC' to close the build.  

# How It Works
We follow the TARDIS along while it is flying through the Time Vortex with the famous long lasting theme tune playing in the background.  
The TARDIS and Time Vortex can be moved with the controls above.  
  
To get the TARDIS to move throught the vortex, it is set so that it is always a certain distance in front of the Main Camera, so as the camera moves, the TARDIS moves with it.  
  
To create the Time Vortex in which the TARDIS flies through, a phyllotaxis calculation was applied to trail renderers to create the vortex we see. The phyllotaxis algorithm creates a pattern within a circular shape and as we pass the camera through the scene world, the trails render in front of the camera creating a sort of a tunnel effect made up of spirals. The trails have a set colour gradient to them so they pass through different colours to create the vortex effect.  
  
The Doctor's theme is used and is attached to the TARDIS and as it moves away from the camera, it sounds quieter. The sound effects are played from spacebar, a random number generator plays either sound when pressed just to give an element of randomness.
  
The light on the top of the TARIDS rotates and flashes as that's what it does when it is in transit. This was done by setting up the rotation as a coroutine and also the flashing was done by turning the light on and off with a few seconds between each as a coroutine also.  
  
There are two builds for the game, one with VR implementation, and one without. Both can be found in the builds folder.  

Also has VR support which can be found alongside the Non-VR builds in the *Builds* folder.

# List of classes/assets in the project
| Class/asset | Source |
|-----------|-----------|
| Tardis.cs | Self written |
| Spread.cs | Modified from [PeerPlay](https://www.youtube.com/@PeerPlay) |
| LightScript.cs | Self written |
| AudioWork.cs | Self written |
| Vortex.cs | Self written |
| QuitApp.cs | Self written with help from Unity Documentation|
| PlaySound.cs | Self written |  

# References  

[PeerPlay](https://www.youtube.com/@PeerPlay)  
[Unity Documentation](https://docs.unity.com/)

# What I am most proud of in the assignment  
I am most proud of the Time Vortex that I created. Getting all the trails to compliment one another, very difficult to get the art direction correct so that each trail goes with the other in order to create the Time Vortex look that I was going for. Figuring out the different widths and colour gradients really added up to a Time Vortex I am very proud of. Also figuring out the different angles for each trail and which direction it should go in. The combination of all of these considerations really made something that to me looks really good visually.  

My attempt to get VR to work as well is another thing I would be proud of. I did this with the XR Interactive and Management plugins which allowed me to (kind of) see what the project looked like if a headset were to be hooked up to it. ith VR being more and more present I think it was important to get this right and learn how to implement it, not just for this project but also for potential future ones as well.  
  
Creating the TARIDS would be the next thing, I spent hours in ProBuilder trying to figure out the best way to create the TARDIS, mulling over the smallest details, getting the position of the windows was very important (very touchy subject amongst the fandom) as well as geting all the correct text to appear on it.  
  
If I could make one improvement it would be to have the trails respond to the theme song, unfortunately I many different things to make the trails respond to audio but for some odd reason they never worked so I dropped it, but if I was to try improve this in the future or I was to change anything about it, it'd be that.  
# What I learned  
 - I learned about the different tools of ProBuilder and creating my own models/assets in more detail.  
 - I learned how to implement Trail Renderers in order to create the Time Vortex.  
 - Learned what Phyllotaxis is and how it's calculated.  
 - Implemented phyllotaxis to recreate my favourite TV shows intro.  
 - How to add lights to a Unity Project and how to alter its rotation, intensity and make it flash.  
 - Adding music to a project.  
 - How to build and run a Unity project.  
 - How to write a script to quit a Unity build.  

# Proposal submitted earlier can go here:  
**Submitted Through Form**  
