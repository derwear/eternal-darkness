using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHelper : MonoBehaviour
{
    public int MaxHealth = 100;
    public int Health = 100;
    public int GoldDrop = 90;

    GameHelper _gameHelper;
    // Start is called before the first frame update
    void Start()
    {
        _gameHelper = GameObject.FindObjectOfType<GameHelper>();
        _gameHelper.HPBar.maxValue = MaxHealth;
        _gameHelper.HPBar.value = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetHit(int damage)
    {
        int health = Health - damage;
        if (health <= 0)
        {
            _gameHelper.TakeGold(GoldDrop);
            Destroy(gameObject);
        }
        Health = health;
        _gameHelper.HPBar.value = Health;
        Debug.Log("Health - " + Health);
    }
}
