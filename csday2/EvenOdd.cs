class IfElseProgram{
    public static void Main(){
        Console.WriteLine("Please enter the number:");
        int n=Convert.ToInt32(Console.ReadLine());
        if(n % 2 == 0){
            Console.WriteLine("Number is Even");

        }else{
            Console.WriteLine("Number is odd");
        }
    }
}
