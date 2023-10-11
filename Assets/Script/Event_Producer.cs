namespace NJ_Event
{
    using System.Collections.Generic;
    using UnityEngine;

    public class Producer : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D other)
        {
            EventManager.TriggerEvent("addCoins", new Dictionary<string, object> { { "amount", 1 } });
        }
        void OnMouseUp()
        {
            EventManager.TriggerEvent("clic", new Dictionary<string, object> { { "clic", 1 } });
        }
    }
}