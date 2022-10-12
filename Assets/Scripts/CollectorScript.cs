using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target) {
        if (target.tag == "Trick" || target.tag == "Candy" || target.tag == "Roll") {
            target.gameObject.SetActive(false);
        }
    }


}
