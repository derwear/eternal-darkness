using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    public Slider HPBar;
    public Transform StartPosition;
    public int PlayerGold;
    public int PlayerDamage = 10;
    public Text PlayerGoldUI;
    public Text powerText;
    public GameObject GoldPrefab;
    public GameObject[] MonstersPrefabs;

    // Start is called before the first frame update
    
    void Start()
    {
        SpawnMonster();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerGoldUI.text = PlayerGold.ToString();
        powerText.text = PlayerDamage.ToString();
    }
    
    public void TakeGold(int gold)
    {
        PlayerGold += gold;
        GameObject goldObj = Instantiate(GoldPrefab) as GameObject;
        Destroy(goldObj, 2);

        SpawnMonster();
    }
    public void SpawnMonster()
    {
        int index = Random.Range(0, MonstersPrefabs.Length);
        GameObject monsterObj = Instantiate(MonstersPrefabs[index]) as GameObject;
        monsterObj.transform.position = StartPosition.position;

    }
}
