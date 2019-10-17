using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChoosen : MonoBehaviour
{
    public GameObject colorBotones;
    public int counter = 0;

    public void enabledColors() {
        counter++;
        if (counter == 1) {
            //Enable buttons on the image
            colorBotones.gameObject.SetActive(true);
            this.GetComponent<Button>().interactable = false;
        }
    }
}
