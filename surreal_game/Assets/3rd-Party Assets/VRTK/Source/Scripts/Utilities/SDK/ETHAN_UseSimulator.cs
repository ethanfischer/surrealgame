using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace Assets._3rd_Party_Assets.VRTK.Source.Scripts.Utilities.SDK
{
    public static class ETHAN_UseSimulator
    {
        private const string MenuName = "VRTK/UseSimulator";
        private const string _shouldUseSimulator = "MySetting";

        public static bool ShouldUseSimulator
        {
            get { return EditorPrefs.GetBool(_shouldUseSimulator, true); }
            set { EditorPrefs.SetBool(_shouldUseSimulator, value); }
        }

        [MenuItem(MenuName)]
        private static void ToggleAction()
        {
            ShouldUseSimulator = !ShouldUseSimulator;
        }

        [MenuItem(MenuName, true)]
        private static bool ToggleActionValidate()
        {
            Menu.SetChecked(MenuName, ShouldUseSimulator);
            return true;
        }
    }
}
