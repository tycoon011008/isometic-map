﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyObject : CharacterObject
{
    public Enemy enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        BaseStart();
    }

    public void EnemyClicked()
    {
        gameManager.EnemyCharacterClicked(this.gameObject);
    }

    protected override void UpdateHealth()
    {
        // Uncomment this when you assign an Enemy object to this GameObject
        // healthbar.fillAmount = ((float)enemy.health) / enemy.maxHealth;
    }
}
