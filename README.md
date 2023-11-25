## Introduction

MediaOutput and MediaPlayer implementation in Unreal Engine based on Spout.

Spout is a video frame sharing system for Microsoft Windows, It's Lossless and Zero-Latency but only for Local Machine.

You can use SpoutMediaOutput to send UE Viewport or Texture to OBS or SpoutCam ( or any Spout Receiver).

You can use SpoutMediaPlayer to receive/play any Spout Source.

It's all based on UE Builtin features, MediaCapture framework and MediaPlayer framework.


Only tested on DirectX12.

If you encounter any problems or need further assistance or clarification, please feel free to contact me.


## Getting Started
### SpoutMediaOutput & OBS
1. Install OBS and Spout2-Plugin
https://github.com/Off-World-Live/obs-spout2-plugin/releases

After installing OBS and the Spout2 plugin, you will see an additional "Spout2 Capture" option in the Source list.
![image](https://github.com/BoysGameStudio/Spout_UnrealEngine_Showcase/assets/15364305/d37cf064-706d-474e-9a56-d26af36b4423)

2. Add Spout2 Capture to the Sources in OBS

3. Run
Open the L_SpoutMediaOutput level in the Unreal Engine project, and then run it. If everything is working correctly, you will see the viewport's image being synchronized in real-time to OBS.
