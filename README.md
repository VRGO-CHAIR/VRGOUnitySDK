# VRGOUnitySDK

This is a demo project created to demonstrate to new users of the VRGO chair how it can be used.

We've now opened the project for other developers as an introductory example of developing for the VRGO chair.

Notes:

- The VRGO chair is a Raw/Direct input device. You will need the Rewired plugin which can be found here: https://www.assetstore.unity3d.com/en/#!/content/21676
A free trial can be downloaded from: http://guavaman.com/projects/rewired/trial.html

- Please note if using the trial, input will cut out after two minutes.

- Rewired allows a wide range of HID devices and controllers to work with Unity. Please check their samples in their package to find out more about how to add additional controllers. The demo we created has been tested with the VRGO and the Xbox One Controller on Windows.

- There are two modes of movement available with the plugin. The camera forward mode (default) will use the player's HMD forward direction as the direction of travel. Turning off camera forward mode (see Player prefab(s)) will move the player based on the transform's rotation. 

- If you wish to support rotation, it is strongly advised to only support it if using camera forward mode.

- SteamVR support is available as a seperate package within this plugin but requires the SteamVR plugin to be installed in your project. Steam VR is free and can be downloaded here: https://www.assetstore.unity3d.com/en/#!/content/32647

- For more detailed information on getting Rewired and the VRGO chair setup, please check out our short introduction tutorial here:https://youtu.be/YVwm8rr2vGw

- More detailed Rewired documentation is available here: http://guavaman.com/projects/rewired/docs/
