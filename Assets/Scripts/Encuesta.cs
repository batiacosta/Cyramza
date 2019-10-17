using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encuesta : MonoBehaviour
{
    public GameObject registroPanel;
    public void Cerrar() {
        registroPanel.GetComponent<Animator>().SetBool("abierto", false);
    }
    public void Enviar() {
        //  Verifica si esta conectado
        //  Envia la informacion a la base de datos en firebase
        //  Cierra la ventana
        Cerrar();
    }
}
