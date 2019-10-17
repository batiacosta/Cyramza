using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeTheColor : MonoBehaviour
{
    public GameObject colorGamma;
    public GameObject colorBotones;
    public void ShowColor() {
        colorGamma.gameObject.SetActive(true);
        colorBotones.gameObject.SetActive(false);
    }
}
