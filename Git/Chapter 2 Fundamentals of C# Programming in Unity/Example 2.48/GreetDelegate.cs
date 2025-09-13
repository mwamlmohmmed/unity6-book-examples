public delegate void GreetDelegate();

public class Greeter {
    public GreetDelegate greetAction;

    public void SayHello() {
        Debug.Log("Hello, adventurer!");
    }

    public void Start() {
        greetAction = SayHello;
        greetAction(); // Calls SayHello
    }
}       