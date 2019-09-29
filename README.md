# Climate simulator
*Special thanks to One Wheel Studio for posting the tutorial that helped me get the time math right. https://youtu.be/babgYCTyw3Y*

## Summary
Add this to your Unity project to allow the passage of time with changing seasons. 

## How to use

1. Start with an empty GameObject to attach the Climate.cs script to. This is now your climate.
2. Make the game's main directional light a child of your climate. 
3. Create a Canvas and Panel with two UI Texts
  i. The inspector should now contain the following hierarchy (minus whatever other Game objects are in the scene)
    * Climate
      * Directional Light
    * Canvas
      * Panel
        * Text 1
        * Text 2
4. The climate and timekeeper scripts each require a reference to one of the two Texts
5. Play the game. The Day Length slider will change the speed of the sun's rising and setting. The higher the length, the longer the day.
