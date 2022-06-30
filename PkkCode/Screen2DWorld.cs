using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PkkCode
{
    public class Screen2DWorld : MonoBehaviour {
        public static void setWallsOnTheScreen(float wallThickness, Transform parent, Sprite wallSprite) {
            Dictionary<string, Transform> walls = new Dictionary<string, Transform>();
            addWallsGameObjectInWallsDictionary(walls);
            Vector2 screenRatio = getScreenRatio();
            setWallsCollider(walls, screenRatio, wallThickness, parent, wallSprite);
            setWallsPositionFromWallDictionary(walls, screenRatio);
        }

        private static void setWallsPositionFromWallDictionary(Dictionary<string, Transform> walls, Vector2 screenSize) {
            Vector2 cameraPos = Camera.main.transform.position;
            walls["TOP"].position = new Vector2(cameraPos.x, cameraPos.y + screenSize.y - (walls["TOP"].localScale.y * 2.0f));
            walls["BOTTOM"].position = new Vector2(cameraPos.x, cameraPos.y - screenSize.y - (walls["BOTTOM"].localScale.y * -2.0f));
            walls["RIGHT"].position = new Vector2(cameraPos.x + screenSize.x - (walls["RIGHT"].localScale.x * 2.0f), cameraPos.y);
            walls["LEFT"].position = new Vector2(cameraPos.x - screenSize.x + (walls["LEFT"].localScale.x * 2.0f), cameraPos.y);
        }

        private static void setWallsCollider(Dictionary<string, Transform> walls, Vector2 screenSize, float wallThickness, Transform parent, Sprite wallSprite) {
            foreach (KeyValuePair<string, Transform> wall in walls) {
                // add collider
                wall.Value.gameObject.AddComponent<BoxCollider2D>();
                //Not adding the sprite on the left and right wall
                if(wall.Key != "LEFT" && wall.Key != "RIGHT")
                    wall.Value.gameObject.AddComponent<SpriteRenderer>().sprite = wallSprite;
                
                wall.Value.name = wall.Key + "Wall";
                wall.Value.parent = parent;
                
                if (wall.Key == "LEFT" || wall.Key == "RIGHT") {
                    wall.Value.localScale = new Vector2(wallThickness, screenSize.y * 1.5f);
                } else {
                    wall.Value.localScale = new Vector2(screenSize.x * 1.833f, wallThickness);
                }
            }
        }

        private static Vector2 getScreenRatio()
        {
            Vector2 screenRatio;
            screenRatio.x = Vector2.Distance(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)),
                Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0))) * 0.5f;
            screenRatio.y = Vector2.Distance(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)),
                Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height))) * 0.5f;
            return screenRatio;
        }

        private static void addWallsGameObjectInWallsDictionary(Dictionary<string, Transform> walls)
        {
            walls.Add("TOP", new GameObject().transform);
            walls.Add("BOTTOM", new GameObject().transform);
            walls.Add("LEFT", new GameObject().transform);
            walls.Add("RIGHT", new GameObject().transform);
        }
    }

}
