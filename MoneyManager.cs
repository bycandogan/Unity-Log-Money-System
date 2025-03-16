using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyManager : MonoBehaviour{
    public static MoneyManager Instance; 
    public int currentMoney = 0;
    public TMP_Text moneyText; // Money UI Text

    private void Awake(){
        if (Instance == null){
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    private void Start() {
        UpdateUI();
    }

    public void AddMoney(int amount, int tip){
        currentMoney += (amount + tip);
        UpdateUI();
        LogSystem.Instance.TriggerTransactionLog(LogStatus.plus, "", amount, tip);
    }

    public bool SpendMoney(int amount){
        if (currentMoney >= amount){
            currentMoney -= amount;
            UpdateUI();
            LogSystem.Instance.TriggerTransactionLog(LogStatus.minus, "", amount, 0);
            return true;
        }else{
            LogSystem.Instance.TriggerTransactionLog(LogStatus.message, "Money is not enough", 0, 0); 
            return false;
        }
    }

    private void UpdateUI(){ // Saving Money -> using PlayerPrefs
        if (moneyText != null){
            moneyText.text = currentMoney.ToString() + " $";
        }
    }
}
