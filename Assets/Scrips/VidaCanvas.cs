using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VidaCanvas : MonoBehaviour
{
    int life;
    TextMeshProUGUI visualife;

    private void Start()
    {
        visualife = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        visualife.text = life.ToString();
    }
    public void SeeLife(int newlife)
    {
        life += newlife;
    }
}
