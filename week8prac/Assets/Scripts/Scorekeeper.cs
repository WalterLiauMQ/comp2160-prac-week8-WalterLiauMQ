using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{

    // Declares an instance of the Scorekeeper
    private static Scorekeeper instance;

    // Declares a Read-Only instance of this Scorekeeper allowing other scripts to pull from it.
    public static Scorekeeper Instance
    {
        get
        {
            return instance;
        }
    }

    // Points gained per Pickup
    public float pickupPoints = 10;


    // Current Score for P1 (Pub)
    public float CurrentScore
    {
        get
        {
            return currentScore;
        }
    }

    // Current Score for P1 (Priv)
    private float currentScore = 0;

    // Current Score for P2 (Pub)
    public float CurrentScoreP2
    {
        get
        {
            return currentScoreP2;
        }
    }

    // Current Score for P2 (Priv)
    private float currentScoreP2 = 0;


    // Awake is called before Start
    void Awake()
    {
        // Checks if there is a Pre-Existing Game Manager instance.
        if (instance == null)
        {
            // Sets whatever this object this is attached to as the Singleton in the Scene.
            instance = this;

        }

    }

    // Adds score for P1
    public void AddScore()
    {
        currentScore += pickupPoints;
    }
    
    // Adds score for P2
    public void AddScoreP2()
    {
        currentScoreP2 += pickupPoints;
    }
}
