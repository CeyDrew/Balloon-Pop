using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonKontrol : MonoBehaviour
{
    
    public GameObject patlama;
    oyunKontrol oyunKontrolScrips;
     void Start()
    {
        oyunKontrolScrips = GameObject.Find("_Scripts").GetComponent<oyunKontrol>();
    }
    void OnMouseDown()
    {
        GameObject go= Instantiate(patlama, transform.position, transform.rotation) as GameObject ;
        Destroy(this.gameObject);
        Destroy(go,  0.333f);
        oyunKontrolScrips.BalonEkle();
    }
}
