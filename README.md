# Assignment 5: Virtual Teleportation

**Due: Wednesday, November 24, 10:00pm CDT**

In this assignment, you will implement a custom teleportation script and then add some advanced functionality.  Note that you are **not** permitted to use the teleportation provider in the XR Interaction Toolkit.

## Submission Information

You should fill out this information before submitting your assignment.  Make sure to document the name and source of any third party assets such as 3D models, textures, or any other content used that was not solely written by you.  Include sufficient detail for the instructor or TA to easily find them, such as a download link.

Name: 

UMN Email:

Third Party Assets:

Instructions for controlling teleport direction:

## Getting Started

Clone the assignment using GitHub Classroom.  The project has been configured for the Oculus Quest, and the [XR Interaction Toolkit](https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@1.0/manual/index.html) package has already been imported.  A basic empty scene with an action-based XR rig is also provided.

## Rubric

Graded out of 20 points. 

1. Create a virtual scene that is a suitable testbed for virtual teleportation.  It should be large enough that you can't walk through it without using virtual locomotion, and it should contain walkable surfaces at two or more elevations.  For example, you might have a ground plane and a raised platform that the user will need to teleport to.  Other than that, you are free to design the environment however you want, but make sure to sure low poly assets that can render smoothly on the Quest!  (2)
2. Add a laser pointer to the controller.  You can feel free to customize its appearance however you want.  For the purposes of this assignment, you can chose either the left or right controller.  You do not have to implement this functionality on both of them.  (2)
3. The laser pointer should only appear when the thumbstick is pressed forward nearly all the way.  When the thumbstick is in the rest position, it should be invisible.  (2)
4. Create a new script called `TeleportationTarget`.  You should add this script to any surfaces that you want the user to be able to teleport to.  Note that you can also add this script to an invisible plane or cube object on top of more complex geometry by toggling off the `MeshRenderer`.   Next, when the thumbstick is in the forward position and the laser pointer is visible, perform a raycast.  If the object hit by the raycast is a `TeleportationTarget`, then change the laser pointer color.  If the object is not a `TeleportationTarget` or no object was hit, then the laser pointer should be rendered using its default settings.  (2)
5. Now, implement the basic teleportation.  When the user is pointing at a `TeleportationTarget` and releases the thumbstick, then move the camera rig so that the user is standing on the target point.  Make sure to adjust the height correctly!  (4)
6. Next, we are going to add the ability to control the direction after teleportation.  First, you should add an arrow or another visual indicator that will be displayed if the user is pointing at a valid teleportation point.  See Figure 2 in [Bozgeyikli et al.](https://dl.acm.org/doi/abs/10.1145/2967934.2968105) for an example.  You can decide how to best control the direction of the indicator, such as the thumbstick or the rotation of the user's hand.  Feel free to implement this however you want, but make sure that the user has a way to control the direction in all 360 degrees.  Make sure to describe the instructions in the submission of your readme file so we know how to use it properly.  (4)
7. Finally, you can complete this assignment by modifying the camera rig's rotation so that the user's viewpoint is pointing in the specified direction after the teleport.  (4)

**Bonus Challenge:**  Make your teleportation script smarter!  When the user is pointing directly at a `TeleportationTarget` , the teleport should work using the direct straight line raycast as described above.  If they are not pointing at a valid target, then the script should use a parabolic arc to attempt to find another target.  This will allow the user to point above the ground, and the laser pointer will adapt and curve downwards.  Note that this is actually quite complicated to implement, so you are free to use code from online or third party assets to implement the trajectory calculations and/or line drawing for the parabolic arc.  The teleportation functionality must be solely written by you.  Make sure to include comments on any external code and document the source in your readme file.  (2)

Make sure to document all third party assets in your readme file. ***Be aware that points will be deducted for using third party assets that are not properly documented.***

## Submission

You will need to check out and submit the project through GitHub classroom.  **Make sure your APK file is in the root folder.** Do not remove the `.gitignore` or `README.md` files.

Please test that your submission meets these requirements.  For example, after you check in your final version of the assignment to GitHub, check it out again to a new directory and make sure everything opens and runs correctly.  You can also test your APK file by installing it manually using [SideQuest](https://sidequestvr.com/).

## License

Material for [CSCI 5619 Fall 2021](https://canvas.umn.edu/courses/268490) by [Evan Suma Rosenberg](https://illusioneering.umn.edu/) is licensed under a [Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License](http://creativecommons.org/licenses/by-nc-sa/4.0/).

The intent of choosing CC BY-NC-SA 4.0 is to allow individuals and instructors at non-profit entities to use this content.  This includes not-for-profit schools (K-12 and post-secondary). For-profit entities (or people creating courses for those sites) may not use this content without permission (this includes, but is not limited to, for-profit schools and universities and commercial education sites such as Coursera, Udacity, LinkedIn Learning, and other similar sites).   