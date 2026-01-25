using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;




public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed;

    private int currentFedAmount = 0;
    private GameManager GameManager;
    private ScoreValue scoreValue;

    void Awake()
    {
        if (hungerSlider == null)
            hungerSlider = GetComponentInChildren<Slider>(true);

        scoreValue = GetComponentInParent<ScoreValue>();
    }

    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;

        if (hungerSlider.fillRect != null)
            hungerSlider.fillRect.gameObject.SetActive(true);

        hungerSlider.value = currentFedAmount;

        if (currentFedAmount >= amountToBeFed)
        {
            int points = (scoreValue != null) ? scoreValue.points : 1;
            GameManager.AddScore(points);
            Destroy(gameObject);
        }
    }
}