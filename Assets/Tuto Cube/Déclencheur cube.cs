using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class Déclencheurcube : MonoBehaviour
{
    public GameObject vfxprefab;
    
    // Start is called before the first frame update
    void SpawnVFX()
    {
        GameObject vfx = Instantiate(vfxprefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
