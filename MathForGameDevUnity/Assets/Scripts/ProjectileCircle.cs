//2019 Levi D. Smith, levidsmith.com

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCircle : MonoBehaviour {


    public float fRadius;
    public float fIncrement;
    float fLifetime;

    public PlayerCircle player;



    // Start is called before the first frame update
    void Start() {
        fLifetime = 0f;
        
    }

    // Update is called once per frame
    void Update() {

        float fCenterX = player.transform.position.x;
        float fCenterY = player.transform.position.y;


        //        transform.position = new Vector3(fRadius * Mathf.Cos(fLifetime), Mathf.Sin(fRadius * fLifetime), 0f);  //cool double helix


        fLifetime += Time.deltaTime * fIncrement;
        transform.position = new Vector3(fCenterX + fRadius * Mathf.Cos(fLifetime), fCenterY + fRadius * Mathf.Sin(fLifetime), 0f);

        
    }
}
