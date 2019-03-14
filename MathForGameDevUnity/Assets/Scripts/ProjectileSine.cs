//2019 Levi D. Smith, levidsmith.com

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSine : MonoBehaviour {

    float fLifetime;

    public float fAmplitude;
    public float fFrequency;


    // Start is called before the first frame update
    void Start() {
        fLifetime = 0f;
        
    }

    // Update is called once per frame
    void Update() {


        float fSpeed = 5f;
        fLifetime += Time.deltaTime * fSpeed;
        transform.position = new Vector3(fLifetime, fAmplitude * Mathf.Sin(fLifetime * fFrequency), 0f);


        if (fLifetime > 20f) {
            Destroy(gameObject);
        }
        
    }
}
