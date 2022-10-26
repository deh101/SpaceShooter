using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject spawnObject;
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSpawns;
    public TMP_Text scoreUI;
    public int score;

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = "Score: " + score.ToString("F0");

        timer += Time.deltaTime;

        timeBetweenSpawns -= Time.deltaTime * 0.003f;

        if(timer > timeBetweenSpawns)
        {
            timer = 0;
            int randNum = Random.Range(0, 56);
            Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
