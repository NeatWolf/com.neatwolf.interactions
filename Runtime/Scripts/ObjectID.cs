using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace NeatWolf.Interactions
{
    /// <summary>
    /// Provides a unique ID to objects for purposes like saving and loading.
    /// Attach to GameObjects that require a unique, persistent identifier.
    /// Automatically assigns a unique ID at creation, ensuring consistency across game sessions.
    /// </summary>
    [ExecuteInEditMode]
    public class ObjectID : MonoBehaviour
    {
        [SerializeField, ReadOnly(true)]
        private string id;

        public string ID => id;

        private void Reset()
        {
            id = Guid.NewGuid().ToString();
        }
    }

}
