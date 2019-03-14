//2019 Levi D. Smith, levidsmith.com

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasUISine : MonoBehaviour {

    public Slider sliderAmplitude;
    public Text textAmplitudeValue;

    public Slider sliderFrequency;
    public Text textFrequencyValue;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        textAmplitudeValue.text = string.Format("{0:0.00}", sliderAmplitude.value);
        textFrequencyValue.text = string.Format("{0:0.00}", sliderFrequency.value);

    }
}
