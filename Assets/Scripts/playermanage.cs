using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanage : MonoBehaviour
{

    internal GameObject ripawpoi;
    // Start is called before the first frame update
    void Start()
    {
        ripawpoi = GameObject.Find("Spawn");
    }

    // Update is called once per frame
    void Update()
    {

    }
    internal void setRP(GameObject newripawpoi)
    {
        if (ripawpoi != null && ripawpoi.GetComponent<ripawpoi>() != null) {
            //ripawpoi = newripawpoi;
            ripawpoi.GetComponent<ripawpoi>().switchColor(); }
        ripawpoi = newripawpoi;
        ripawpoi.GetComponent<ripawpoi>().switchColor();

        //GetComponent<Collider>().gameObject.GetComponent<ripawpoi>().switchAcive();
    }
    internal void Respawn() {
            transform.position = ripawpoi.transform.position;
     }
    
}
