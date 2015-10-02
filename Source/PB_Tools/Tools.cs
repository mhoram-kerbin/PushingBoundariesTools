using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace PB_Tools
{
    
    // Log the names of all loaded Dll's
    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class LogLoadedDllNames : MonoBehaviour
    {
        private static bool doneOnce = false;
        public void Start()
        {
            if (doneOnce)
            {
                return;
            }
            doneOnce = true;

            Debug.Log("LogLoadedDllNames: " + AssemblyLoader.loadedAssemblies.ToList().Select(la => la.dllName).Aggregate((a, b) => a + ", " + b));
        }
    }
}
