using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ForTest2 : MonoBehaviour {
    private bool test = false;

    void Update() {
        print("2");
        test = Input.GetKeyUp(KeyCode.Backspace);
        if (test) {
            SceneManager.LoadScene("Test1");
        }
    }
}
