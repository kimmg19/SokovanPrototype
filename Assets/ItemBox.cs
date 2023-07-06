using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour {
    public Color touchColor;
    private Color originalColor;
    public bool isOveraped = false;
    Renderer myRenderer;

    void Start() {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    void Update() {

    }
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "EndPoint") {
            myRenderer.material.color = touchColor;
            isOveraped = true;
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.tag == "EndPoint") {
            myRenderer.material.color = originalColor;
            isOveraped = true;

        }
    }
    private void OnTriggerStay(Collider other) {
        if (other.tag == "EndPoint") {
            myRenderer.material.color = touchColor;
            isOveraped = true;

        }
    }
}
