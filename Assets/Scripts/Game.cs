using UnityEngine;

public class Game : MonoBehaviour
{
    /************************
     * Global Variables
     ***********************/   
    // Game Score 
    public static int score;
    // All or Nothing Score
    public static int allOrNothingScore;
    // Formated Time Remaining
    public static string formatedTime;
    // Current Round
    public static int round = 0;

    // Reference to CountDown Script to reset timer
    private CountDown countDownScript = new CountDown();

    void Start()
    {
        // At start of game reset objects
        ResetGame();
        // Show the CountDown Canvas
        ShowCountDown();
    }

    public void ResetGame()
    {
        // Delete any existing cubes
        DeleteCubes();
        // Add the cubes to the game
        AddCubes();
        // Reset and hide all the canvases
        ResetCanvases();
        // Reset the Player (Ball) location
        ResetPlayerLocation();
        // Start the timer
        countDownScript.StartCountDownTime();
    }

    private void ShowCountDown()
    {
        // Get a reference to the CountDown Canvas
        Canvas countDownCanvas = GameObject.FindWithTag("CountDownCanvas").GetComponent<Canvas>();
        // Enable the canvas so it is visible
        countDownCanvas.enabled = true;
    }

    private void ResetCanvases()
    {
        // Get a reference to the CountDown Canvas
        Canvas countDownCanvas = GameObject.FindWithTag("CountDownCanvas").GetComponent<Canvas>();
        // Enable the canvas so it is visible
        countDownCanvas.enabled = false;

        // Get a reference to the Quit Canvas
        Canvas quitCanvas = GameObject.FindWithTag("QuitCanvas").GetComponent<Canvas>();
        // Enable the canvas so it is visible
        quitCanvas.enabled = false;

        // Get a reference to the GameOver Canvas
        Canvas gameOverCanvas = GameObject.FindWithTag("GameOverCanvas").GetComponent<Canvas>();
        // Enable the canvas so it is visible
        gameOverCanvas.enabled = false;
    }

    private void ResetPlayerLocation()
    {
        // Get a reference to the Player(Ball) GameObject
        var player = GameObject.FindWithTag("Player");
        // Set the position of the Player(Ball)
        player.transform.position = new Vector3(-10, 0.5f, -2);
    }

    private void DeleteCubes()
    {
        // Find all the remaining Cubes in the Game
        var cubes = GameObject.FindGameObjectsWithTag("GameCube");

        // Loop through each Cube
        foreach (var c in cubes)
        {
            // Destory/Remove each Cube
            Destroy(c);
        }
    }

    private void AddCubes()
    {
        // Create each Cube passing in its location
        CreateCube(-6, 0.5f, -6);
        CreateCube(-8.5f, 0.5f, 5);
        CreateCube(-6, 0.5f, 4.5f);
        CreateCube(2.5f, 0.5f, 6.5f);
        CreateCube(10, 0.5f, 6.5f);
        CreateCube(8.5f, 0.5f, -6);
    }

    public void CreateCube(float x, float y, float z)
    {
        // Get an reference to the Cube Prefab
        GameObject cube = GameObject.FindWithTag("Cube");
        // Set the location passed in
        var startPosition = new Vector3(x, y, z);
        // Set the postion
        cube.transform.position = startPosition;

        // Create an Instance of the Cube Prefab
        var newCube = Instantiate(cube);
        // Change the tag name to "GameCube" for later reference
        newCube.tag = "GameCube";
    }
}
