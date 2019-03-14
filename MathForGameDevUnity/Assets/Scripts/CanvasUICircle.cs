//2019 Levi D. Smith, levidsmith.com

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasUICircle : MonoBehaviour {

    public Slider sliderRadius;
    public Text textRadiusValue;

    public Slider sliderIncrement;
    public Text textIncrementValue;

    public PlayerCircle playercircle;


    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        textRadiusValue.text = string.Format("{0:0.00}", sliderRadius.value);
        textIncrementValue.text = string.Format("{0:0.00} Pi", sliderIncrement.value / Mathf.PI);

    }

    public void doSpawnProjectile() {
        playercircle.spawnProjectile();

    }

    public void doClearProjectiles() {
        playercircle.clearProjectiles();
    }
}
