using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBubble : MonoBehaviour
{
    [SerializeField] private PlayerHP playerHP;
    [SerializeField] private Image totalHealthBubble;
    [SerializeField] private Image currentHealthBubble;

    private void Start(){
        totalHealthBubble.fillAmount = playerHP.currentHP / 10;
    }
    private void Update(){
        currentHealthBubble.fillAmount = playerHP.currentHP / 10;
    }
}
