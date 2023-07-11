using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonPatlatma : MonoBehaviour
{
    public GameObject balon;
    float balonolusturmasuresi = 1f;
    float zamansayaci = 0f;
    oyunKontrol okScripts;
    // Start is called before the first frame update
    void Start()
    {
        okScripts = this.gameObject.GetComponent<oyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        zamansayaci -= Time.deltaTime;
        if (zamansayaci < 0 && okScripts.zamansayaci>0)
        {
            GameObject go= Instantiate(balon, new Vector3(Random.Range(-2.3f,2.4f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range( 50f,100f), 0));
            zamansayaci = balonolusturmasuresi; 
        }
        

        
    }
}
