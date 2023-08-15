using UnityEngine;

namespace CollectableSystem
{
    public abstract class Collectable : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (!other.attachedRigidbody.CompareTag("Player")) return;

            OnCollected();
            //Destroy(gameObject);
        }


        protected abstract void OnCollected();
    }
}