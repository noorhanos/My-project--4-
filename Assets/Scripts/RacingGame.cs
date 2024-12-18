using UnityEngine;
namespace assi24
{
public class RacingGame : MonoBehaviour
{
    public RaceState raceState;
    public void SimulateRace ()
    {
        switch (raceState)
        {
            case RaceState.Start:
                Debug.Log("The race has started!, Get ready champion");
                break;
            
            case RaceState.Accelerate:        
                Debug.Log("You press the gas pedal. The car speeds up!");
                break;

            case RaceState.Turn:
                Debug.Log("You approach a sharp turn. Be careful not to crash!");
                break;

            case RaceState.crash:        
                Debug.Log("You hit a barrier. The race is over.");
                break;
            case RaceState.Finish:        
                Debug.Log("You crossed the finish line. Well done!");
                break;

            default:
             Debug.Log("This state is not defined. Something is wrong.");
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {
        SimulateRace();
    }
}
}      