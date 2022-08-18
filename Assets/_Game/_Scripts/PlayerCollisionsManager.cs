using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Naren_Dev
{
    public class PlayerCollisionsManager : MonoBehaviour
    {

        #region Unity Built-In Methods

        private void OnTriggerEnter2D(Collider2D other)
        {
            switch (other.tag)
            {
                case "Collectable":
                    CollectableManager.instance?.onCollectableCollected?.Invoke(other.GetComponent<Collectable>(), this.transform);
                    break;
                case "JumpPad":

                    break;
                case "Checkpoint":
                    EventHandler.TriggerEvent(EventID.EVENT_ON_CHECKPOINT_REACHED, other.transform);
                    break;
            }
        }

        #endregion
    }
}