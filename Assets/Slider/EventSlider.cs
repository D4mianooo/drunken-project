using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EventSlider : MonoBehaviour {
    
    [SerializeField] private Slider slider;
    
    [SerializeField] private float sliderSpeed = 0.2f;
    [SerializeField] private int minSliderSucces = 385;
    [SerializeField] private int maxSliderSucces = 515;
    
    private PlayerInputActions playerInputActions;
    [SerializeField] private bool isCycleOver = true;
    private void Awake() {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.QuickTimeControl.performed += context =>
        {
            if (!isCycleOver) return;
            if (slider.value >= minSliderSucces && slider.value <= maxSliderSucces) {
                Debug.Log("Succesful");
                isCycleOver = false;
            }
        };
    }
    private void Update() {
        if (slider.value == slider.minValue) {
            isCycleOver = true;
            StopCoroutine("LerpSliderValue");
            StartCoroutine(LerpSliderValue(slider.minValue, slider.maxValue));
        }
        if (slider.value == slider.maxValue) {
            isCycleOver = true;
            StopCoroutine("LerpSliderValue");
            StartCoroutine(LerpSliderValue(slider.maxValue, slider.minValue));
        }
    }
    private IEnumerator LerpSliderValue(float start, float end) {
        float percentage = 0f;
        while (percentage <= slider.maxValue + 5f) {
            slider.value = Mathf.MoveTowards(start, end, percentage);
            percentage += sliderSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }
}
