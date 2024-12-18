using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ripawpoi : MonoBehaviour
{
    private bool isActive = false;
    private Material mat;
    private Color active = new Color(0, 255, 0, 156);
    private Color UNactive = new Color(255, 0, 0, 156);
    // Start is called before the first frame update
    void Start()
    {
        mat = this.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void switchColor()
    {
        
        if (isActive)
        {
            mat.color = UNactive;
            isActive = false;
        }
        else
        {
            isActive = true;
            mat.color = active;
        }
        
    }
    void OnTriggerEnter(Collider col)
        {
        
        if (col.gameObject.CompareTag("Player") && !isActive)
            {

            col.GetComponent<playermanage>().setRP(this.gameObject);
            }
        }
}
