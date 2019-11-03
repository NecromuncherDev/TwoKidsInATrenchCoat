using System.Collections;
using UnityEngine;

namespace VikingCrewTools.UI {
	public class ScriptedDialogueBehaviour : MonoBehaviour {

        private int index;
        [System.Serializable]
        public class DialogueLine
        {
           
            [Tooltip("The transform doing the speaking. This could be a mouth, head or character transform depending on your scene")]
            public Transform speaker;
            [Tooltip("Time to delay from the previous message in the array")]
            public float delay = 2;
            [Multiline, Tooltip("What to say")]
            public string line = "Hello World!";
            [Tooltip("How to say it")]
            public SpeechBubbleManager.SpeechbubbleType speechBubbleType = SpeechBubbleManager.SpeechbubbleType.NORMAL;
        }

        public DialogueLine[] script;
        public bool doRestartAtEnd = true;
        public float bubbleTimeToLive = 3f;

        // Use this for initialization
        private void Start()
        {
            index = 0;
        }

        public void Interacted()
        {
            Debug.Log("we have made contect");
           
            SpeechBubbleManager.Instance.AddSpeechBubble(script[index].speaker, script[index].line, script[index].speechBubbleType, bubbleTimeToLive, Color.white, Vector3.zero);
            index++;
            if (doRestartAtEnd && index == script.Length)
                index = 0;

        }
            
        
	}
} 