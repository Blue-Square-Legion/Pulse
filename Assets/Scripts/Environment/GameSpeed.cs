using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSpeed : MonoBehaviour
{
    // Reference to the slider and buttons (optional)
    public Slider speedSlider;
    public Button slowButton;
    public Button fastButton;
    public Button defaultButton;

    // Speed values for slow, default, and fast
    public float slowSpeed = 0.2f;
    public float defaultSpeed = 1.0f;
    public float fastSpeed = 2.0f;

    void Start()
    {
        // Set initial game speed to default
        SetGameSpeed(defaultSpeed);

        // Add listeners for buttons (optional, if using buttons for adjustments)
        slowButton.onClick.AddListener(() => SetGameSpeed(slowSpeed));
        fastButton.onClick.AddListener(() => SetGameSpeed(fastSpeed));
        defaultButton.onClick.AddListener(() => SetGameSpeed(defaultSpeed));

        // Setup the slider for dynamic adjustment (optional)
        if (speedSlider != null)
        {
            speedSlider.onValueChanged.AddListener(OnSliderValueChanged);
            speedSlider.value = defaultSpeed;
        }
    }

    // Function to set the game speed
    public void SetGameSpeed(float speed)
    {
        Time.timeScale = speed;
    }

    // Function to handle slider value change
    private void OnSliderValueChanged(float value)
    {
        // You can adjust the range here based on how fast or slow you want the game to go
        Time.timeScale = value;
    }

    // Optionally, you can reset the game speed to default when the game is paused or on a reset button
    public void ResetGameSpeed()
    {
        Time.timeScale = defaultSpeed;
    }

}
