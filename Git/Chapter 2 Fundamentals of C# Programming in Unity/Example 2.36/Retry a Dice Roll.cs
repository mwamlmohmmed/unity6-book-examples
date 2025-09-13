int roll;                                   
string input;
do {
    roll = Random.Range(1, 7);
    Debug.Log("You rolled: " + roll);
    Debug.Log("Roll again? (y/n)");
    input = GetPlayerInput(); // Simulate keyboard or UI input
} while (input == "y");