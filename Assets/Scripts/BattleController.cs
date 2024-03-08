using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject enemy;
    [SerializeField] private Slider playerHealth;
    [SerializeField] private Slider enemyHealth;
    [SerializeField] Button attackButton = null, healButton = null, runButton;
    private bool isPlayerTurn = true;

    private void Attack(GameObject target, float damage)
    {
        if (target == enemy)
        {
            enemyHealth.value -= damage;
        }
        else
        {
            playerHealth.value -= damage;
        }
        ChangeTurns();
    }

    private void Heal(GameObject target, float amount)
    {
        if (target == enemy)
        {
            enemyHealth.value += amount;
        }
        else
        {
            playerHealth.value += amount;
        }
        ChangeTurns();
    }

    //On button click.
    public void ButtonAttack()
    {
        Attack(enemy, 10);
    }
    public void ButtonHeal()
    {
        Heal(player, 5);
    }

    private void ChangeTurns()
    {
        isPlayerTurn = !isPlayerTurn;

        if (!isPlayerTurn)
        {
            attackButton.interactable = false;
            healButton.interactable = false;
            runButton.interactable = false;

            StartCoroutine(EnemyTurn());
        }
        else
        {
            attackButton.interactable = true;
            healButton.interactable = true;
            runButton.interactable = true;
        }
    }

    private IEnumerator EnemyTurn()
    {
        yield return new WaitForSeconds(3);

        int random = 0;
        random = Random.Range(1, 3);

        if (random == 1)
        {
            Attack(player, 12);
            Debug.Log("Enemy attacked!");
        }
        else
        {
            Heal(enemy, 4);
            Debug.Log("Enemy healed!");
        }
    }
}
