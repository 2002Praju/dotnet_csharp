class IfElseLadderProgram
{
    public static void Main(){
        Console.WriteLine("Please Enter Firstt Number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter Second Number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter Third Number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if(num1 > num2 && num1 > num3){
            Console.WriteLine($"Largest Number is: {num1}");
        }
        else if (num2 > num1 && num2 > num3) {
            Console.WriteLine($"Largest Number is: {num2}");
        }else{
            Console.WriteLine($"Largest number is : {num3}");
        }
    }
}