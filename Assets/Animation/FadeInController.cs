using UnityEngine;
using UnityEngine.UI;
using System;

public class FadeInController : MonoBehaviour {
    // Alpha増減値(点滅スピード調整)
    private float _Step = 0.02f;
    private Color baseColor;
    private Type type;

    private void SetBaseColor() {
        if(gameObject.GetComponent<Text>() != null) {
            baseColor = gameObject.GetComponent<Text>().color;
        } else if(gameObject.GetComponent<Image>() != null){
            baseColor = gameObject.GetComponent<Image>().color;
        }
        if(baseColor == null) {
            Debug.LogError("basecolor == null");
        }
    }

    void OnEnable() {
        SetBaseColor();
        if (gameObject.GetComponent<Text>() != null) {
            baseColor = gameObject.GetComponent<Text>().color = new Color(baseColor.r, baseColor.g, baseColor.b, 0);
        } else if (gameObject.GetComponent<Image>() != null) {
            baseColor = gameObject.GetComponent<Image>().color = new Color(baseColor.r, baseColor.g, baseColor.b, 0);
        }
    }

    void Update() {
        // 現在のAlpha値を取得
        SetBaseColor();
        // Alpha値を増減させてセット
        if (gameObject.GetComponent<Text>() != null) {
            baseColor = gameObject.GetComponent<Text>().color = new Color(baseColor.r, baseColor.g, baseColor.b, baseColor.a + _Step);
        } else if (gameObject.GetComponent<Image>() != null) {
            baseColor = gameObject.GetComponent<Image>().color = new Color(baseColor.r, baseColor.g, baseColor.b, baseColor.a + _Step);
        }
    }

}
