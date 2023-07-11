using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text zamanTEXT, balonTEXT;
    public GameObject patlama;
    public float zamansayaci = 60;
    float patlayanbalon = 0;
    // Start is called before the first frame update
    void Start()
    {
        balonTEXT.text = "Balon : " + patlayanbalon;
    }

    // Update is called once per frame
    void Update()
    {
        if (zamansayaci > 0)
        {
            zamansayaci -= Time.deltaTime;
            zamanTEXT.text = "Süre : " + (int)zamansayaci;
        }

        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for(int i=0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }
        
    }
    public void BalonEkle()
    {
        patlayanbalon += 1;
        balonTEXT.text = "Balon : " + patlayanbalon;
    }
}
