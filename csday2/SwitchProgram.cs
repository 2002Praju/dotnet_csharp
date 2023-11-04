class SwitchProgram{
    public static void Main(){
        Console.WriteLine("Please Enter an Alphabet:");
        char ch = (char)Console.Read();
        switch (ch){
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("VoWEl");
                break;
            default:
                Console.WriteLine("Enter alpahabet is Consonant");
                break;
        }
        
        
    }
}