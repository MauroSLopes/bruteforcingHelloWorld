// Timer Variable in miliseconds
int waitTimer = 20;

// Text to be brute forced
string mensage = "hello world!?!";

// Result mensage
string currentMensage = "";

// Alphabet array
char[] alphabet = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r',
's','t','u','v','w','x','y','z', ' ', '.', ',',';',':','!','?'};

// Repeat for each letter in the text
foreach(char c in mensage){

    // Look for letter in the alphabet array
    for (int i = 0; i < alphabet.Length; i++)
    {
        // Slowdown the code
        Thread.Sleep(waitTimer);
        // Display the letters
        Console.WriteLine($"{currentMensage}{alphabet[i]}");
        if(alphabet[i] == c){
            // Lock the letter and end the search 
            currentMensage += c;
            break;
        }    
    }
}