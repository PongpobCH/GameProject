using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;


namespace DIALOGUE

{
    public class DialogueParser
        {

            private const string commandRegexPattern = "\\w*[^\\s]\\(";
            
            public static DialogueLine Parse(string rawLine)
            {
                Debug.Log($"Parsing line - '{rawLine}'");

                (string speaker, string dialogue, string commands) = RipContent(rawLine);

                return new DialogueLine(speaker, dialogue, commands);
            }

             private static (string, string, string) RipContent(string rawLine)
            {
                string speaker = "",  dialogue = "" , commands = "";

                int dialogueStart = -1;
                int dialogueEnd = -1;
                bool isEscaped = false;

                for (int i = 0; i < rawLine.Length; i++)
                {
                    char current = rawLine[i];
                    if (current == '\\')
                        isEscaped = !isEscaped;
                    else if (current == '"' && !isEscaped)
                    {
                        if(dialogueStart == -1)
                            dialogueStart = i;
                        else if (dialogueEnd == -1)
                            dialogueEnd =i;

                    }
                    else
                        isEscaped = false;
                }

                //Debug.Log(rawLine.Substring(dialogueStart + 1, (dialogueEnd - dialogueStart) - 1 ));

                //Identify Command Pattern 

                
                Regex commandRegex = new Regex(commandRegexPattern);
                Match match = commandRegex.Match(rawLine);

                return (speaker, dialogue, commands);
            }

        }  
}
