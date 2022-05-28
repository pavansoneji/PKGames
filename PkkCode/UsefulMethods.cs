using UnityEngine;

namespace PkkCode
{
    public class UsefulMethods
    {
        public static string generateRandomName()
        {
            Debug.Log("Generating Random Name:");
            string[] genres = new string[] { "Silver","Surfer","Spider", "Man", "Iron","Captian","Flash","Devil","Stunts","One","Piece" };
            return genres[Random.Range(0, genres.Length)] + genres[Random.Range(0, genres.Length)];
        }

        public static string generateCustomRandomName(string[] namesArr, int wordsLimit=2, bool usingSpace = false) {
            string playerRandomName = "";
            for(int i = 0; i < wordsLimit; i++) {
                playerRandomName += (usingSpace) ? namesArr[Random.Range(0, namesArr.Length)] + " " : namesArr[Random.Range(0, namesArr.Length)];
            }
            return playerRandomName;
        }
    }
}
