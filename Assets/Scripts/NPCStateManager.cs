using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCStateManager : MonoBehaviour
{
   NPCState currentState;
   NPCWander wanderState = new NPCWander();
   NPCSeek seekState = new NPCSeek();
   NPCFollow followState = new NPCFollow(); 

   void Start();
}
