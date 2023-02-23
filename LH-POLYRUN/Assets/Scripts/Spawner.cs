using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("chalelengeobj gmamre obecjet")]
    public GameObject chalelengeObecjet;
    [Header("ddefafutlt sapwene delagtyryesy etimieme")]
    public float sapweneDelagtyryesy = 1f;
    [Header("ddefafutlt sapwene etimieme")]
    public float sapweneEtimieme = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("IsntatieanetObecjets", sapweneDelagtyryesy, sapweneEtimieme);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(15, 0f, -0.374f);
    }
    
    void IsntatieanetObecjets()
    {
        Instantiate(chalelengeObecjet, transform.position, transform.rotation);
    }
}
