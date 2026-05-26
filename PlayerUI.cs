using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinText;
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        slider.value = player.health;
        slider.maxValue = player.maxHealth;

        coinText.text = player.coins.ToString();
    }
}
