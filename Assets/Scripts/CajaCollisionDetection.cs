using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Colisión con " + col.gameObject.name);
        float[] posicionesX = { -2f, 0f, 2f };
        int indice = Random.Range(0, posicionesX.Length);
        float posix = posicionesX[indice];       
        if(col.gameObject.CompareTag("Player")){
            Destroy(col.gameObject);
        }
        else if(col.gameObject.CompareTag("Piso")){
            gameObject.transform.Translate(posix, 7, 0);
            gameObject.transform.Translate(0f, 4f, 0f);
        }
    }
}
