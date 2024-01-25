using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecameInvisible : MonoBehaviour
{

    // Disable this script when the GameObject moves out of the camera's view
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
