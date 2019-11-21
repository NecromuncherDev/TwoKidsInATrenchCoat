using System.Collections;
using UnityEngine;

namespace VikingCrewTools.UI {
	public class ScriptedDialogueBehaviour : MonoBehaviour {

<<<<<<< HEAD
        private int index;
=======
       private int index;

>>>>>>> 0956567d6916818cd2a418fae97af2e830019878
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

<<<<<<< HEAD
        public DialogueLine[] script;
=======
        [Tooltip("To use when NPC needs to talk before mission or doesn't has one")]
        public DialogueLine[] scriptBefore;
        [Tooltip("When Mission is Active")]
        public DialogueLine[] scriptWhile;
        [Tooltip("After mission ended")]
        public DialogueLine[] scriptAfter;


>>>>>>> 0956567d6916818cd2a418fae97af2e830019878
        public bool doRestartAtEnd = true;
        public float bubbleTimeToLive = 3f;

        // Use this for initialization
        private void Start()
        {
<<<<<<< HEAD
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
=======
            
            index = 0;
        }
        public void ChooseScript()
        {
            TaskItem task = this.gameObject.GetComponent<TaskItem>();
            if (task == null || !task.active && !task.Finished)
            {
                Interacted(scriptBefore);
            }
            else if (task != null && task.active && !task.Finished)
            {
                Interacted(scriptWhile);
            }
            else if (task != null &&  task.Finished)
            {
                Interacted(scriptAfter);
            }
        }


        public void Interacted(DialogueLine[] script)
        {
            Debug.Log("we have made contect");
            if (doRestartAtEnd && index >= script.Length)
            {
                index = 0;
            }
            SpeechBubbleManager.Instance.AddSpeechBubble(script[index].speaker, script[index].line, script[index].speechBubbleType, bubbleTimeToLive, Color.white, Vector3.zero);
            index++;
          

        }


    }
>>>>>>> 0956567d6916818cd2a418fae97af2e830019878
} 