using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject cube;
    public static int score;
    public static string formatedTime;

    void Start()
    {
        AddCubes();
        GameObject countDownCanvas = GameObject.FindWithTag("CountDownCanvas");
        countDownCanvas.SetActive(true);

        GameObject quitCanvas = GameObject.FindWithTag("QuitCanvas");
        var quitCanvasGroup = quitCanvas.GetComponent<CanvasGroup>();
        quitCanvasGroup.alpha = 0f;
    }

    public void AddCubes()
    {
        CreateCube(-6, 0.5f, -6);
        CreateCube(-8.5f, 0.5f, 5);
        CreateCube(-6, 0.5f, 4.5f);
        CreateCube(2.5f, 0.5f, 6.5f);
        CreateCube(10, 0.5f, 6.5f);
        CreateCube(8.5f, 0.5f, -6);
    }



    public void CreateCube(float x, float y, float z)
    {
        var startPosition = new Vector3(x, y, z);
        cube.transform.position = startPosition;

        Instantiate(cube);
    }
}
