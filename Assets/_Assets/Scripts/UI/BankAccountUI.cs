using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BankAccountUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bankAccountAmount;

    public void Start()
    {
        Player.Instance.OnBankAccountAdded += Player_OnBankAccountAdded;
        Player.Instance.OnBankAccountDeducted += Player_OnBankAccountDeducted;

        bankAccountAmount.text = GetFormattedBankAccountAmount();
    }

    private void Player_OnBankAccountAdded(object sender, System.EventArgs e)
    {
        bankAccountAmount.text = GetFormattedBankAccountAmount();
    }

    private void Player_OnBankAccountDeducted(object sender, System.EventArgs e)
    {
        bankAccountAmount.text = GetFormattedBankAccountAmount();
    }

    private string GetFormattedBankAccountAmount()
    {
        return Player.Instance.GetBankAccountAmount().ToString() + " €";
    } 
}
