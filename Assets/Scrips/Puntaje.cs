using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    int points;
    TextMeshProUGUI visualpoints;

    private void Start()
    {
        visualpoints = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        visualpoints.text = points.ToString();
    }
    public void MorePoints(int newpoints)
    {
        points += newpoints;
    }
}
