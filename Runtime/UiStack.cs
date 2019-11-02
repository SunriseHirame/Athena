using System.Collections.Generic;

namespace Hirame.Athena
{
    public static class UiStack
    {
        private static List<UiView> uiStack = new List<UiView> ();

        internal static void PushUi (UiView uiView)
        {
            // see if current ui has a transition animation?
            
            // Add a new ui
            uiStack.Add (uiView);
            
            // Play in transition animation?
        }

        internal static void PopUi ()
        {
            if (uiStack.Count > 0)
            {
                // Potential show some ui closing dialog
                
                // Play some closing animation
                
                // Close the top most ui
                uiStack.RemoveAt (uiStack.Count - 1);
            }

            // if we still have roots left, open the top most
            // else show some kind of exit screen / bottom level interaction
        }
    }

}
