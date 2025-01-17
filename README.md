[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Break down in HW1:
This game world is composed of three objects. They are player (rabbit), plants and a display window(UI). 

Objects
UI:
- Attributes
   - how many seeds are left
   - how many plants the rabbit already planted
- Actions
   - game start
      - if player tap space key, seeds planted+1, seeds remaining-1
      - if not, does not change

PLAYER(rabbit):
- Attributes
   - movement
   - If the player plant seeds
- Actions
   - w/a/s/d to control
   - Space to plant seed

PLANTS: 
- Attributes
   - Two conditions(appear/disappear)
- Actions
   - Whether the player use space to plant seeds (Yes, plants appear No, no change)

## Devlog
For this project, I developed a simple planting game where the player completes tasks by controlling the movement of rabbits and planting seeds. The main function is to control the movement of rabbits using WASD or arrow keys, and to plant seeds by pressing the space bar. When the player presses the space bar, the program checks if _numSeedsLeft is greater than 0, making sure the player has any seeds left to plant. If there are seeds, the Instantiate plant is generated, while UpdateSeeds() is called to update the UI, so reduce the number of remaining seeds _numSeedsLeft and increase the planted seeds count _numSeedsPlanted.

When I basically finished all the content, I found that there were superfluous # characters in the unity ui output interface when I was testing the program. After discussing with my friends, I found that it was the wrong text link in the gamemanager interface plant count ui that caused the superfluous characters. Just re-link the correct text to fix it.

In the Start() method, I initialize the number of seeds and display the UI to ensure that the interface accurately reflects the current state when the game starts. The biggest challenge is to accurately determine if the seed has been planted and to update the UI in a timely manner. Through this process, I gained a better understanding of how to handle user input and interface interaction, while mastering basic game logic and interface update techniques.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Although you described some aspects of your code in this Devlog, I cannot give it full points because you did not make the connection between the code and your high-level plan clear. For example, when you said:

> When the player presses the space bar, the program checks if _numSeedsLeft is greater than 0, making sure the player has any seeds left to plant

You also could have specified that this code all occurs in the Update function of the Player Component, which is implementing the 'PLAYER(rabbit)' object mentioned in the break-down. Because you didn't mention your objects or their attributes/actions at any point, I can't quite give this full credit.

I'm also not sure what you mean by this:

> The biggest challenge is to accurately determine if the seed has been planted and to update the UI in a timely manner. Through this process, I gained a better understanding of how to handle user input and interface interaction, while mastering basic game logic and interface update techniques.

We're not really learning about updating things 'in a timely manner'. You don't need to include flowery language in your Devlogs- be direct and to the point, and make sure to answer the prompt.

Also, please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
