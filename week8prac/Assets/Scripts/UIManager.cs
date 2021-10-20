using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Declares an instance of the UI Manager
    private static UIManager instance;

    // Declares a Read-Only instance of this UI Manager allowing other scripts to pull from it.
    public static UIManager Instance
    {
        get
        {
            return instance;
        }
    }

    public Canvas scoreCanvas;

    // Awake is called before Start
    void Awake()
    {
        // Sets whatever this object this is attached to as the Singleton in the Scene.
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        // Finds the Text child of P1's Score in the Canvas and changes it to the Current Score provided by the Game Manager.
        scoreCanvas.transform.Find("Score").GetComponent<Text>().text = "P1 Score : " + Scorekeeper.Instance.CurrentScore.ToString();

        // Finds the Text child of P2's Score in the Canvas and changes it to the Current Score provided by the Game Manager.
        scoreCanvas.transform.Find("ScoreP2").GetComponent<Text>().text = "P2 Score : " + Scorekeeper.Instance.CurrentScoreP2.ToString();

    }
}
