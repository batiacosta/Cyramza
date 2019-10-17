using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetColors : MonoBehaviour
{
    public GameObject[] colors;
    public GameObject[] botonesPaleta;
    public GameObject[] botonesImagen;
    public void ResetColores() {
        for (int i = 0; i < botonesPaleta.Length; i++)
        {
            botonesPaleta[i].GetComponent<ColorChoosen>().counter = 0;
            botonesPaleta[i].GetComponent<Button>().interactable = true;
        }
        for (int i = 0; i < colors.Length; i++) {
            colors[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < botonesImagen.Length; i++) {
            botonesImagen[i].gameObject.SetActive(false);
        }
        
    }
}
