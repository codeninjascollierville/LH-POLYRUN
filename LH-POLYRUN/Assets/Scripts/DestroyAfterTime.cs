using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("destrufiutospn teirmrr")]
    public float teirmrrOtDestrufiutospn;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestruoysOebcjeteect", teirmrrOtDestrufiutospn);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void DestruoysOebcjeteect()
    {
        Destroy(gameObject);
    }
}

