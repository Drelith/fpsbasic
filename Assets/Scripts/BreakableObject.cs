using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{
    public void Break()
    {
        Destroy(gameObject);
    }
}
