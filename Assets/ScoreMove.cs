using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreMove : MonoBehaviour
{
    public TextMeshPro scoreValue;
    public int score;
    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        RectTransform textPos = GameObject.Find("Score").GetComponent<RectTransform>();
        var playerPos = GameObject.Find("Player").GetComponent<Transform>().position;
        scoreValue.text = "Score: " + ++score;
        textPos.anchoredPosition3D = playerPos + new Vector3(0, 5, 15);
    }
}
