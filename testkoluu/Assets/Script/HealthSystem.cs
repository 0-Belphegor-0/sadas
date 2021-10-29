using UnityEngine;
using System;
public class HealthSystem 
{

    //public event EventHandler OnHealthChanged;
    //private int HealthMax;
    //private int Health;
    //public HealthSystem(int healthMax)
    //{
    //   this.HealthMax = healthMax;
    //    Health = healthMax;


    //}
    //public int GetHealth()
    //{
    //    return Health;

    //}

    //public void health (int healthAmount)
    //{
    //    Health += healthAmount;
    //    if (Health > HealthMax) Health = HealthMax;
    //    if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    //}
    //public void damage(int damageAmount)
    //{
    //    Health -= damageAmount;
    //    if (Health <0) Health = 0;
    //    if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    //}
    //public float GetHealthPercent()
    //{
    //    return (float)Health / HealthMax; 
    //}

    private int Health;
    private int HealthMax;
    public event EventHandler OnHealthChanged;
    public HealthSystem (int HealthMax)
    {
        this.HealthMax = HealthMax;
        Health = this.HealthMax;
    }
    public void health(int healthAmong)
    {
        Health += healthAmong;
        if (Health > HealthMax) Health = HealthMax;
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }
    public void damage(int damageAmong)
    {
        Health -= damageAmong;
        if (Health < 0) Health = 0;
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }
    public float HealthBarPercent()
    {
        return (float)Health / HealthMax;
    }









}
