using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collect : MonoBehaviour
{
    
        private void OnTriggerEnter(Collider other)
        {
            
            if (other.gameObject.tag == "Coin")
            {
                Destroy(other.gameObject);
            }
        }
    
}
