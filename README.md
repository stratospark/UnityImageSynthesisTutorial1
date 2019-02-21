# Image Synthesis for Machine Learning #
Aim is to help Machine Learning and Computer Vision researchers to generate annotated training sets in Unity and [on the Cloud](../../wiki/AWS).

### Rationale ###

One of the main challenges in Machine Learning is the task of getting large amounts of training data in the right format. Deep learning, and machine learning more generally, needs huge training sets to work properly.

Virtual worlds can provide a wealth of training data. However it must consist of more than just the final image: object categorization, optical flow, etc

### What does it do? ###

This repository contains code that is [easy to add to any existing Unity project](../../wiki/Installation). It allows to capture image depth, segmentation, optical flow, etc as .png images with minimal intrusion:

* __Image segmentation__ - each object in the scene gets unique color
* __Object categorization__ - objects are assigned color based on their category
* __Optical flow__ - pixels are colored according to their motion in the relation to camera
* __Depth__ - pixels are colored according to their distance from the camera
* __Normals__ - surfaces are colored according to their orientation in relation with the camera 
* *... and more in the future*

![Readme_DescriptionMainImageNew.jpg](https://bitbucket.org/repo/5KgjLE/images/2557031440-Readme_DescriptionMainImageNew.jpg)
![Readme_Description4Passes.png](https://bitbucket.org/repo/5KgjLE/images/3420646604-Readme_Description4Passes.png)
*(Assets used in the image above are courtesy of [FINWARD STUDIOS](http://www.finwardstudios.com) and not included in this repository. You can obtain this package from [Asset Store](http://u3d.as/BaG))*

### Wiki ###
* [How to use it in the existing project](../../wiki/Installation)
* [How does it work](../../wiki/Implementation)
* [Render images on Amazon Cloud (AWS)](../../wiki/AWS)
* [ToDo list](../../wiki/Roadmap)

### Who do I talk to? ###
* email: rej@unity3d.com
* twitter: `@__ReJ__`

### Requirements ###
* Unity *5.5.0* or later
* Should work on any OS officially supported by Unity

### License ###
This repository is covered under the [MIT/X11](LICENSE.TXT) license.