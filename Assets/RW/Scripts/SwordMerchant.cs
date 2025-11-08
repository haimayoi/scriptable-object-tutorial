using UnityEngine;
using UnityEngine.UI;

public class SwordMerchant : MonoBehaviour
{
    [SerializeField]
    private Text swordName; // 1
    [SerializeField]
    private Text description; // 2
    [SerializeField]
    private Image icon; // 3
    [SerializeField]
    private Text goldCost; // 4
    [SerializeField]
    private Text attackDamage; // 5
    [SerializeField]
    public AudioSource audioSource; //6
        
    public void UpdateDisplayUI(SwordData swordData)
    {
        swordName.text = swordData.SwordName;
        description.text = swordData.Description;
        icon.sprite = swordData.Icon;
        goldCost.text = swordData.GoldCost.ToString();
        attackDamage.text = swordData.AttackDamage.ToString();
        audioSource.PlayOneShot(swordData.SelectSound);
    }
}
