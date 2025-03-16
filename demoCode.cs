using System.Collections;
using UnityEngine;

// READ ME
// This is an example of the commands you can use in the system. You can test this demo by throwing it into an empty gameobject.
// - Can Dogan | 2025
public class demoCode : MonoBehaviour
{ 
    private int counter=0;
    void Start(){
        StartCoroutine(test());
    }

    private IEnumerator test(){
        switch(counter){
            case 0: MoneyManager.Instance.AddMoney(50,0); break;
            case 1: MoneyManager.Instance.AddMoney(10,10); break;
            case 2: MoneyManager.Instance.SpendMoney(66); break;
            case 3: LogSystem.Instance.TriggerTransactionLog(LogStatus.message, "Mission Complete", 0, 0); break;
            case 4: MoneyManager.Instance.AddMoney(9,122); break;
            case 5: MoneyManager.Instance.SpendMoney(90); break;
            case 6: MoneyManager.Instance.SpendMoney(10000); break;
            case 7: LogSystem.Instance.TriggerTransactionLog(LogStatus.map, "", 0, 0); break;
        }
        counter++;
        if(counter >=7) counter = 0;
        yield return new WaitForSeconds(2f);
        StartCoroutine(test());
    }
}
