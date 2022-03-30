class fibonnaci
{ 
    
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter no. of fabonnacci series ");
        int s = int.Parse(System.Console.ReadLine());

        int n1 = 0;
        int n2 = 1;
        System.Console.WriteLine(n1);
        System.Console.WriteLine(n2);
        
        for(int n3 =2; n3 <=s; n3++)
        {
            n3 = n1 + n2;
            System.Console.WriteLine(n3);


            n1 = n2;

            n2 = n3;
            
            

        }

    }

}