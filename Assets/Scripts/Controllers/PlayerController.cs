using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int score;

    public int lives;

    public double startSpeed = 1.0;

    public int invadersDead;

    public double boostPerWave = 0.2;

    public int InvadersPerWave => {
        return 55;
    };

    public int InvadersSpeed => {
        return this.startSpeed + (this.invadersDead / this.InvadersPerWave) * this.boostPerWave;
    };
}
