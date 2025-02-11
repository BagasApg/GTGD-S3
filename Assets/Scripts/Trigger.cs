using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{

    public class Trigger : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.name);
        }
    }
}
