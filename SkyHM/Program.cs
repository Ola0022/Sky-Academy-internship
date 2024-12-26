class Program{
    static void Main(String[] args){
        Console.Write("Enter value of x:");
        int x=Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter value of y:");
        int y = Convert.ToInt16(Console.ReadLine());

        Calculator calc1= new Calculator(x,y);
        
        Console.WriteLine("Sum (x + y)= "+ calc1.Add());

        Console.WriteLine("Difference (x - y)= " + calc1.Subtract());
        
        Console.WriteLine("Product (x * y)= " + calc1.Multiply());
        
        Console.WriteLine("Quotient (x / y)= " + calc1.Divide());
        
    }
}