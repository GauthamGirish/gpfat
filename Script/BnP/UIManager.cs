using UnityEngine;
using UnityEngine.UI;  // For working with UI elements
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    // Reference to the Button and Scroll View
    public Button myButton;
    public ScrollRect scrollRect;
    public Text infoText; // Reference to a Text object for displaying messages
    void Start()
    {
        // Assign a function to the button click event
        myButton.onClick.AddListener(OnButtonClick);
        // Add listener for scroll view events (optional)
        scrollRect.onValueChanged.AddListener(OnScrollChanged);
    }
    // Function to handle button click
    void OnButtonClick()
    {
        Debug.Log("Button clicked!");
        infoText.text = "You clicked the button!";
    }

    // Function to handle scrolling events (optional)
    void OnScrollChanged(Vector2 position)
    {
        Debug.Log("Scrolling... Position: " + position);
    }
    // Optionally, you can load another scene when the button is clicked
    public void LoadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}







































/*
Steps to Create Unity Project with UI Component, Scrolling, and Simple Events:

1. Create a New Unity Project
   - Open Unity Hub and create a new project.
   - Choose a template (3D or 2D, depending on your need).

2. Add a Canvas and UI Components
   - In the Unity editor, right-click in the Hierarchy panel.
   - Select UI → Canvas. This will automatically create an EventSystem and a Canvas object.
   - Right-click on the Canvas and add the UI elements you need:
     - Button: UI → Button
     - Text: UI → Text
     - Scroll View: UI → Scroll View

3. Configure the Scroll View
   - Unity's Scroll View contains the following parts:
     - Viewport: This is where the content will be displayed.
     - Content: This will contain all the elements inside the scroll view.
     - Scrollbar (optional): Adds a vertical/horizontal scrollbar.
   - You can adjust the size of the content inside the Scroll View to simulate scrolling.
   - You can place multiple UI elements (like buttons, images, etc.) inside the content for scrolling.

4. Add a C# Script for Event Handling
   - Create a C# script to handle events like button clicks or UI interactions.
   - Right-click in the Project window, select Create → C# Script, and name it `UIManager`.

   Sample C# Script for UIManager:
   (Add your custom script here for handling the events.)

5. Linking the Script to UI Elements
   - Attach the UIManager script to an empty GameObject in the Hierarchy panel.
   - Drag and drop the UI elements (Button, ScrollRect, and Text) into the script's public fields in the Inspector.

6. Testing the Project
   - Press the Play button in the Unity editor.
   - Interact with the UI components:
     - Clicking the button will update the text and log a message.
     - Scrolling the Scroll View will log the current scroll position.
*/
