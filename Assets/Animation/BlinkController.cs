using UnityEngine;
using UnityEngine.UI;
using System;

public class BlinkController : MonoBehaviour{
    // Alpha増減値(点滅スピード調整)
    private float _Step = 0.017f;
    private Color baseColor;
    private string target = "Text";

    private void SetBaseColor() {
        if (gameObject.GetComponent<Text>() != null) {
            baseColor = gameObject.GetComponent<Text>().color;
        } else if (gameObject.GetComponent<Image>() != null) {
            baseColor = gameObject.GetComponent<Image>().color;
        }
        if (baseColor == null) {
            Debug.LogError("basecolor == null");
        }
    }

    void Update() {
        // 現在のAlpha値を取得
        SetBaseColor();
        // Alphaが0 または 1になったら増減値を反転
        if (baseColor.a < 0 || baseColor.a > 1) {
            _Step = _Step * -1;
        }
        // Alpha値を増減させてセット
        if (gameObject.GetComponent<Text>() != null) {
            baseColor = gameObject.GetComponent<Text>().color = new Color(baseColor.r, baseColor.g, baseColor.b, baseColor.a + _Step);
        } else if (gameObject.GetComponent<Image>() != null) {
            baseColor = gameObject.GetComponent<Image>().color = new Color(baseColor.r, baseColor.g, baseColor.b, baseColor.a + _Step);
        }
    }

}
