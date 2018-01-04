using UnityEngine;
using UnityEditor;

public class LayoutShortCuts : EditorWindow
{
 
	[MenuItem ("Window/LayoutShortcuts/1 %9", false, 999)]
	static void Layout1 ()
	{
		EditorApplication.ExecuteMenuItem ("Window/Layouts/(Ethan)Debug Time");
	}

	[MenuItem ("Window/LayoutShortcuts/2 %0", false, 999)]
	static void Layout2 ()
	{
		EditorApplication.ExecuteMenuItem ("Window/Layouts/(Ethan)TakingCareOfBusiness");
	}

	[MenuItem ("Window/LayoutShortcuts/3 %8", false, 999)]
	static void Layout3 ()
	{
		EditorApplication.ExecuteMenuItem ("Window/Layouts/2 by 3");
	}

    [MenuItem("Window/LayoutShortcuts/AlignViewToSelected %;", false, 999)]
    static void AlignViewWithSelected()
    {
        EditorApplication.ExecuteMenuItem("GameObject/Align View to Selected");
    }
}