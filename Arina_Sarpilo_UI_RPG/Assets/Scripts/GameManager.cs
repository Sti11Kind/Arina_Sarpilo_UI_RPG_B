using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Character enemy;

    [SerializeField] private TMP_Text playerName, playerHP, playerWeapon, enemyName, enemyHP;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.CharName;
        playerHP.text = "HP: " + player.Health.ToString("F1");
        enemyHP.text = "HP: " + enemy.Health.ToString("F1");
        playerWeapon.text = player.ActiveWeaponName;
        
        {
            playerName.text = player.CharName;
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                restartPanel.SetActive(true);
            }
        }
    }

    public void SwitchWeapon()
    {
        player.SwitchWeapon();
        UpdateUI();
    }
    
    public void AttackButton()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateUI();
    }

    
    public GameObject restartPanel;
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
