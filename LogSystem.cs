using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public enum LogStatus{
    plus,
    minus,
    message,
    map
}

public class LogSystem : MonoBehaviour{
    public static LogSystem Instance;    
    public GameObject moneyPlus, moneyMinus, logMessage, mapUpdate; // Prefabs
    public Transform logContainer; // Prefabs created tranform
    private GameObject prefab;
    
    private void Awake(){
        if (Instance == null){ Instance = this; } else { Destroy(gameObject); }
    }
    
    public void TriggerTransactionLog(LogStatus status, string message, float amount, float tip){ 
        if(status == LogStatus.plus){
            prefab = moneyPlus;
        } else if(status == LogStatus.minus){
            prefab = moneyMinus;
        } else if(status == LogStatus.message){
            prefab = logMessage;
        } else if(status == LogStatus.map){
            prefab = mapUpdate;
        } else {}        
        DisplayLog(prefab, status, message, amount, tip);
    }
    
    public void DisplayLog(GameObject prefab, LogStatus status, string message, float amount, float tip){ 
        if (prefab == null || logContainer == null) return;        
        GameObject logEntry = Instantiate(prefab, logContainer);
        // Attention !!! - Here we are looking for the “LogText” object under the first element in the log prefab.
        // In the example we used Prefab -> Background -> LogText.
        TMP_Text logText = logEntry.transform.GetChild(0).Find("LogText")?.GetComponent<TMP_Text>();

        if (logText != null){
            if(status == LogStatus.plus || status == LogStatus.minus){
                if(tip > 0){
                    logText.text = amount.ToString() + "$ " + " (+" + tip.ToString() + "$)";
                } else {
                    logText.text = amount.ToString() + "$";
                }                
            } else if(status == LogStatus.map){
                // OK            
            } else {
                logText.text = message;
            }
            
        }
        
        LayoutRebuilder.ForceRebuildLayoutImmediate(logEntry.GetComponent<RectTransform>());
        StartCoroutine(RemoveLogAfterDelay(logEntry, 3f));
    }

    private IEnumerator RemoveLogAfterDelay(GameObject logEntry, float delay){
        yield return new WaitForSeconds(delay);
        if (logEntry != null){
            Destroy(logEntry);
        }
    }
}
