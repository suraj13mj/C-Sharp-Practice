using System;

public class Loops
{
    public static void Main()
    {
        Loops lp = new Loops();
        //lp.WHILE();
        //lp.DOWHILE();
        //lp.coffeBill();
        //lp.FOR();
        lp.FOREACH();

    }

    public void WHILE ()
    {
        Console.WriteLine("Enter the value of N:");
        int N = int.Parse(Console.ReadLine());
        int start = 0;

        //while Loop

        while (start <= N)
        {
            Console.Write(start + " ");
            start += 2;
        }

    }

    public void DOWHILE()
    {
        string choice = "";
        do{
            Console.WriteLine("Enter the value of N:");
            int N = int.Parse(Console.ReadLine());
            int start = 0;

            while(start <= N)
            {
                Console.WriteLine(start);
                start += 2;
            }

            do{
                Console.WriteLine("Do you want to continue with this Console Program : YES or NO..?");
                choice = Console.ReadLine().ToUpper();
                if(choice != "YES" && choice != "NO"){
                    Console.WriteLine("Invalid choice : Please Enter a valid choice..");
                }
            }while(choice != "YES" && choice != "NO");


        }while(choice == "YES");
    }

    public void coffeBill(){
        int totalbillamount = 0, coffee_selected;
        string repeat = "";
        Console.WriteLine("Welcome to Starbucks...!!");

        do{
            do{
                Console.WriteLine("Please select the Coffee of your choice \n1.Small : Rs 10 \n2.Medium : Rs 20 \n3.Large: Rs 30");
                coffee_selected = int.Parse(Console.ReadLine());
                switch(coffee_selected){
                    case 1: 
                        Console.WriteLine("You have selected a Small coffee");
                        totalbillamount += 10;
                        break;
                    case 2:
                        Console.WriteLine("You have selected a Medium coffee");
                        totalbillamount += 20;
                        break;
                    case 3:
                        Console.WriteLine("You have selected a Large coffee");
                        totalbillamount += 30;
                        break;
                    default:
                        Console.WriteLine("Invalid choice: Enter a valid coffee size");
                        break;
                }
            }while(coffee_selected!=1 && coffee_selected!=2 && coffee_selected!=3);
            do{
                Console.WriteLine("Do you want to buy another coffee...? YES or NO");
                repeat = Console.ReadLine().ToUpper();
                if(repeat!="YES" && repeat!="NO"){
                    Console.WriteLine("Invalid Selection..Please Enter YES or NO");
                }
            }while(repeat!="YES" && repeat!="NO");
        }while(repeat=="YES");
        
        Console.WriteLine("Your Coffee Bill is Rs {0}",totalbillamount);
    }



    public void FOR()
    {
        int[] even_numbers = new int[50];
        int size;
        Console.WriteLine("Enter the value of size:");
        size = int.Parse(Console.ReadLine());
        for(int i=0,num=0; i < size; num++ )
        {
            if (num % 2 == 1)
                continue;
            even_numbers[i] = num;
            i++;
        }

        Console.WriteLine("The Even Numbers are:\n");
        for(int i=0; i < size; i++)
        {
            Console.WriteLine(even_numbers[i]);
        }
    }

    public void FOREACH()
    {
       int[] even_numbers = new int[20];
       int size;
        Console.WriteLine("Enter the value of size:");
        size = int.Parse(Console.ReadLine());
        for(int i=0,num=0; i < size; num++ )
        {
            if (num % 2 == 1)
                continue;
            even_numbers[i] = num;
            i++;
        } 

        // foreach
        Console.WriteLine("The Even Numbers are:\n");
        foreach( int num in even_numbers)
            Console.WriteLine(num);

    }
}