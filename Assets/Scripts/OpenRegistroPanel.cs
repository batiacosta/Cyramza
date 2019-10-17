using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRegistroPanel : MonoBehaviour
{
    public GameObject registroPanel;

    public void AbrirPanelRegistro() {
        registroPanel.GetComponent<Animator>().SetBool("abierto", true);
    }
}
