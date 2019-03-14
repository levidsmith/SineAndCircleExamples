//2019 Levi D. Smith, levidsmith.com

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCircle : MonoBehaviour {

    public GameObject ProjectileCirclePrefab;

    float fSpawnCountdown;

    public Slider sliderRadius;
    public Slider sliderIncrement;


    // Start is called before the first frame update
    void Start() {

        //        Debug.Log(Vector3.Distance(new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 0f)));
        /*
        int inum;
        float fnum;

        inum = 11 / 4;   // 2
        inum = 11 % 4;   // 3
        fnum = 11 / 4;   // 2
        fnum = 11f / 4f; // 2.75
        fnum = 11f % 4f; // 3
//        inum = 11f / 4f; //error
        inum = (int) (11f / 4f); // 2
        */

//        Debug.Log(inum.ToString());
        
    }

    // Update is called once per frame
    void Update() {
        /*
        fSpawnCountdown -= Time.deltaTime;
        if (fSpawnCountdown <= 0f) {
            ProjectileCircle p = Instantiate(ProjectileCirclePrefab, new Vector3(sliderRadius.value, 0f, 0f), Quaternion.identity).GetComponent<ProjectileCircle>();
            p.fRadius = sliderRadius.value;
            fSpawnCountdown += 2f;
        }
        */

        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, Input.GetAxis("Vertical") * Time.deltaTime, 0f);
        
    }

    public void spawnProjectile() {
        ProjectileCircle p = Instantiate(ProjectileCirclePrefab, new Vector3(transform.position.x + sliderRadius.value, 0f, 0f), Quaternion.identity).GetComponent<ProjectileCircle>();
        p.fRadius = sliderRadius.value;
        p.fIncrement = sliderIncrement.value;
        p.player = this;

    }

    public void clearProjectiles() {
        ProjectileCircle[] pcs = GameObject.FindObjectsOfType<ProjectileCircle>();
        foreach (ProjectileCircle pc in pcs) {
            Destroy(pc.gameObject);
        }

    }
}
