//2019 Levi D. Smith, levidsmith.com

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSine : MonoBehaviour {

    public GameObject ProjectilePrefab;
    float fSpawnCountdown;

    public Slider sliderAmplitude;
    public Slider sliderFrequency;

    // Start is called before the first frame update
    void Start() {
        fSpawnCountdown = 0f;
        
    }

    // Update is called once per frame
    void Update() {

        fSpawnCountdown -= Time.deltaTime;
        if (fSpawnCountdown <= 0f) {
            ProjectileSine p = Instantiate(ProjectilePrefab, Vector3.zero, Quaternion.identity).GetComponent<ProjectileSine>();
            p.fAmplitude = sliderAmplitude.value;
            p.fFrequency = sliderFrequency.value;
            fSpawnCountdown += 2f;
        }
        
    }
}
