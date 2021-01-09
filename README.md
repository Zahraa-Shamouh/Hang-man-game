## Hangman Game 
It is a 3D game build using UnityEngine. 

I have created different menus to help the player move from one scence to another. 
# Main Menu
  - **Play button** 
    - This button will take you to diffrent menu which the **category menu** where the player can select any game he want to play. 
  - **Options button**
    - By pressing the options button, the player will be moved to two diffrent menus
      - **Setting option**
        - In the setting, the player can adjust the volume of the background music in the game. 
      - **Rate the game option**
        - In this option, the player have the capacity to give a **feedback** on the game by send this feedback via email to me. Additionally, he/she can rate the game. Keep in mind that this options wont work unless i build the game, because the **Rate option** will take you to the **play store**. 
  - **Quit button**
    - By pressing this button the game will end.
    
    
 # Category Menu
 The player can select one of the 4 category I have created to start playing the game. After the selection of the player, he/she will be moved to another scene where the game is displayed. 
 
 At any time while the player play the game, he/she have the option to press **esc button in the keyboard** to pause the game. 
  - **Pause menu** , 
    In this menu, the player have 3 diffrent options 
    1. press **esc** again to unpause or press the **Resume button** and continue the game.
    2. press **Menu button** to return to the main menu scene. 
    3. press **Quit** to exit the game. 
    
  While the player playing the game he always have the option to restart the game by pressing the **Restart button** on the top right in the scene where his score will be zero again.  
  
  
  # Background Music Of The Game 
  Since I have only one music playing in the game and I want it to be playing in all scencs in the game. I had to put it on **loop** and **Play On Awake** in unity. The **Play On Awake** option means that the music will start at the Main menu (the first scene in the game). Her is a problem, because whenever the player wants to return to the main mune (first scene) the music will be duplicate. Therefore, I have to destroy the duplicate music. 
  ``` c#
  //for the background music to be ON in all scencs
    void Awake()
    {
        if (!_instance)
            _instance = this;
        else
            Destroy(this.gameObject); 
 
        DontDestroyOnLoad(this.gameObject);
    }
   ```
   The above function will keep the music playing in all scenes and destroy the duplicate music whenever the player return to the main menu.  
  
