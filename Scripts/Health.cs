using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Health : MonoBehaviour {

    public float health = 50;
    public float timeToHeal = 5;
    public float amountToHeal = 3;
    public Camera footCamera;
    public Image healthBar;
    public GameObject deadPanel;

    private float actualHealth;
    private float timer;
    private GameObject player;
    private FirstPersonController controller;

    private void Awake()
    {
        healthBar.fillAmount = 1;
        actualHealth = health;
        player = GameObject.FindGameObjectWithTag("Player");
        controller = player.GetComponent<FirstPersonController>();
    }

    public void Damage(float damage)
    {
        timer = 0;
        actualHealth -= damage;
        ModifyHeadBob(-damage/health);
        ActualizeHealthBar();
        if(actualHealth <= 0)
        {
            actualHealth = 0;
            footCamera.enabled = true;
            deadPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void LateUpdate()
    {
        timer += Time.deltaTime;
        if(timer >= timeToHeal)
        {
            actualHealth += amountToHeal;
            if (actualHealth >= health) actualHealth = health;
            ModifyHeadBob(amountToHeal/health);
            ActualizeHealthBar();
            timer = 0;
        }
    }

    private void ActualizeHealthBar()
    {
        healthBar.fillAmount = actualHealth / health;
        if (actualHealth <= 0) healthBar.fillAmount = 0;
    }

    private void ModifyHeadBob(float bob)
    {
        controller.m_HeadBob.HorizontalBobRange += bob;
        controller.m_HeadBob.VerticalBobRange += bob;
    }
}
