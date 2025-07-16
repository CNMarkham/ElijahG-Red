using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour
{
    public Text enemyUI;
    public int enemyRemaining;

    // Start is called before the first frame update
    void Start()
    {
        enemyRemaining = 5;
        enemyUI.text = enemyRemaining.ToString();

    }

    public void UpdateText()
    {

        enemyRemaining -= 1;
        enemyUI.text = enemyRemaining.ToString();
    }

}
