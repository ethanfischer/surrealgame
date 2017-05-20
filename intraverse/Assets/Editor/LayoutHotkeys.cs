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
 
}