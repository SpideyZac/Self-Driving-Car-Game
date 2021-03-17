# Self-Driving-Car-Game
Self driving car game for AI

Simple, download the file. And create an AI to get around a custom made track.

The prefabs and sprites folder should have every thing you need.
They are labeled making it easy to figure out what they do.
If you have nay questions, just report them in issues :)

The car prefab located in the sprites folder is the car which can be controlled using the A and D keys. The speed and turnSpeed varribles for the carScript(part of the car prefab)
can be moddified to change the speed of the car and the speed of the steering

The wall prefab located in the sprites folder is used to detect if the car hits a boundary of the course, sending the car back to the game object "Spawn"'s position when
the car colides with the wall.

The main camera prefab located in the prefab folder is used to see the screen and is used to follow the car

The Spawn prefab located in the prefab folder is used to teleport the car back to the beginning of the level if it wins, or collides with a wall. Set the position of this game
object to where you want the car to respawn at.

The Win prefab located in the sprites folder is the marker of the end of the course. If it is touched it will send the car back to the spawn. This game object
is not detectable by ray casts.

If you are not sure what you are allowed to do with this code, please check the LICENSE file.
If you need help, please report your issue in the Issues section.

Have fun imbeting AI into this game! :)
