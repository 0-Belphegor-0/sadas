using CodeMonkey;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    //public Transform pfHealthBar;
    //private void Start()
    //{
    //    HealthSystem healthSystem = new HealthSystem(100);
    //    Transform heathBarTransform = Instantiate(pfHealthBar, new Vector3(0,-1), Quaternion.identity);
    //    HealthBAr healthBar = heathBarTransform.GetComponent<HealthBAr>();

    //    healthBar.Setup(healthSystem);

    //    CMDebug.ButtonUI(new Vector2(100, 100), "health", () =>
    //     {
    //         healthSystem.health(1);

    //     });
    //    CMDebug.ButtonUI(new Vector2(-100, 100), "damage", () =>
    //    {
    //        healthSystem.damage(1);

    //    });







   public Transform pfHealthBar;

    private void Start()
    {
       
        HealthSystem healthSystem =new HealthSystem(100);
        Transform HealthTranform = Instantiate(pfHealthBar, new Vector3(0, 1), Quaternion.identity);
        HealthBAr healthBAr = HealthTranform.GetComponent<HealthBAr>();

        healthBAr.SetUp(healthSystem);


        CMDebug.ButtonUI(new Vector2(100, 100), "health", () =>
           {
               healthSystem.health(10);



           });
        CMDebug.ButtonUI(new Vector2(-100, 100), "damage", () =>
        {
            healthSystem.damage(10);



        });





    }





}
