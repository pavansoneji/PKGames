using UnityEngine;

namespace PkkCode {    
    public class SwipeManager {  
        public static string DetectSwipe(Vector2 swipeDelta, int swipeDistance = 125) {            
            if (swipeDelta.magnitude > swipeDistance) { 
                float x = swipeDelta.x;
                float y = swipeDelta.y;

                if (Mathf.Abs(x) > Mathf.Abs(y)) {
                    // left or right
                    if (x < 0) {
                        return "SWIPE_LEFT";
                    }else {
                        return "SWIPE_RIGHT";
                    }
                }else {
                    // up or down
                    if (y < 0) {
                        return "SWIPE_DOWN";
                    }else {
                        return "SWIPE_UP";
                    }
                }
            }
            return string.Empty;
        }
    }
}

