using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBAr : MonoBehaviour
{




    //private HealthSystem healthSystem;
    //public void Setup(HealthSystem healthsystem)
    //{
    //    this.healthSystem = healthsystem;
    //    healthSystem.OnHealthChanged += HealthSystem_OnHealthChanged;
    //}

    //private void HealthSystem_OnHealthChanged(object sender, System.EventArgs e)
    //{
    //    transform.Find("Bar").localScale = new Vector3(healthSystem.GetHealthPercent(), 1);
    //}


    private HealthSystem HealthSystem;
    public void SetUp(HealthSystem healthSystem)
    {
        this.HealthSystem = healthSystem;
        HealthSystem.OnHealthChanged += HealthSystem_OnHealthChanged;
    }

    private void HealthSystem_OnHealthChanged(object sender, System.EventArgs e)
    {
        transform.Find("Bar").localScale = new Vector3(HealthSystem.HealthBarPercent(), 1);
    }
}
