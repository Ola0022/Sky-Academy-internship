class Calculator{
    public int x { get; set; }
    public int y { get; set; }

    public Calculator(int X, int Y){
        x = X; y = Y;
    }
    public int Add(){
        return x + y;
    }
    public int Subtract(){
        return x - y;
    }
    public int Multiply(){
        return x * y;
    }
    public string Divide(){
        if (y == 0) return "Cannot divide by zero";
        return (x / y).ToString();
    }
}

