using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreChangeScene : ScoreManager {



	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
        if (ScoreManager.score == 30)
        {
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            if (currentIndex < SceneManager.sceneCountInBuildSettings - 1)
            {
                SceneManager.LoadScene(3);
            }
        }
        }

	}
