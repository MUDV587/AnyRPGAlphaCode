using AnyRPG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace AnyRPG {
    public class CurrencyButton : TransparencyButton {

        [SerializeField]
        private Currency currency = null;

        [SerializeField]
        private Image icon = null;

        [SerializeField]
        private Text currencyName = null;

        [SerializeField]
        private Text description = null;

        /*
        public void AddCurrency(string currency) {
            Currency addCurrency = SystemCurrencyManager.MyInstance.GetResource(currency);
            AddCurrency(addCurrency);
        }
        */

        public void AddCurrency(Currency currency) {
            this.currency = currency as Currency;
            icon.sprite = this.currency.MyIcon;
            icon.color = Color.white;
            currencyName.text = this.currency.MyName;
            description.text = this.currency.GetSummary();
        }

        public void ClearCurrency() {
            icon.sprite = null;
            icon.color = new Color32(0, 0, 0, 0);
            currencyName.text = string.Empty;
            description.text = string.Empty;
        }


    }

}