using UnityEngine;
namespace PkkCode {
    public class Log {
        public static void Info(string functionName, string fileName) {
            Debug.LogFormat("funcstion : {0} - file: {1}", functionName, fileName);
        }
    }
}