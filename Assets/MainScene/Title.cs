﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {
    private int arrow = 1;
    private bool flag = false;
    private bool nextScene = false;
    private string TextObjectName1 = "Press_Enter_Key";
    private string TextObjectName2 = "Start_Or_Load";
    private string arrowImageName = "ArrowImage";
    private GameObject text1;
    private GameObject text2;
    private GameObject arrowImage;
    private Vector3 hajimekaraPosition = new Vector3(-50, -58, 0);
    private Vector3 tudukikaraPosition = new Vector3(-50, -104, 0);
    private Vector3 initialPosition;

    void Start() {
        text1 = GameObject.Find(TextObjectName1);
        text2 = GameObject.Find(TextObjectName2);
        arrowImage = GameObject.Find(arrowImageName);
        initialPosition = arrowImage.transform.position - hajimekaraPosition;
    }

	void Update () {
        if (!flag) {
            //flag = false
            text1.SetActive(!flag);
            text2.SetActive(flag);
            arrowImage.SetActive(flag);
            flag = Input.GetKeyDown(KeyCode.Return);
        } else {
            //flag = true;
            text1.SetActive(!flag);
            text2.SetActive(flag);
            arrowImage.SetActive(flag);
            flag = !Input.GetKeyDown(KeyCode.Escape);
            nextScene = Input.GetKeyDown(KeyCode.Return);
            if (Input.GetKeyDown(KeyCode.UpArrow)) {
                arrow = 1;
            } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
                arrow = -1;
            }
            if (arrow == 1) {
                arrowImage.transform.position = initialPosition + hajimekaraPosition;
                if (nextScene) {
                    SceneManager.LoadScene("Start");
                }
            } else if(arrow == -1) {
                arrowImage.transform.position = initialPosition + tudukikaraPosition;
                if (nextScene) {
                    SceneManager.LoadScene("Load");
                }
            }
        }
	}
}
