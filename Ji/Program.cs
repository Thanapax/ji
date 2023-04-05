using System;

class Program {
    static void Main(string[] args) {
        //High();
        //even();
        arrange();
    }
    static void High() {
        int[] num = new int[15];
        for (int i = 0; i <= 14; i++) {
            num[i] = int.Parse(Console.ReadLine());
        }
        while(true) {
            Console.Write("Input n : ");
            int s = int.Parse(Console.ReadLine());
            if (s > 0 && s <= 15) {
            Console.WriteLine(num[s-1]);
            }
            else {
                Console.WriteLine("Good bye");
                break;
            }
        }
    }
    static void even() {
        Console.Write("Input n : ");
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        for (int i = 0; i <= n-1; i++) {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("*************************");
        for (int i = 0; i <= n-1; i++) {
            if(num[i] % 2 == 0) {
                Console.WriteLine(num[i]);
            }
        }
    }
    static void arrange() {
        Console.Write("Input n : ");
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        for (int i = 0; i <= n-1; i++) {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("*************************");
        for (int i = 0; i <= n-1; i++) {
            if (num[i] < num[i+1]) {
                num[i] = num[i+1];
            }
            Console.WriteLine(num[i]);
        }
    }
}