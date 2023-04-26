using System;

class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    n++;
    int counter = 0;
    char[] space = new char[n];
    for(int i = 0; i < n; i++){
      space[i] = '_';
    }
    bool isend = true;

    while(isend){
      int num1 = int.Parse(Console.ReadLine());
      int num2 = int.Parse(Console.ReadLine());

      bool num1_isvalid = false;
      bool num2_isvalid = false;
      bool num1_isplace = false;
      bool num2_isplace = false;
      bool carslot = true;

      if(num1 < 0){
        num1 = 0;
        num1_isvalid = true;
      }
      if(space[num1] != 'X'){
        num1_isvalid = true;
        num1_isplace = true;
      } 

      if(num2 < 0){
        num2 = 0;
        num2_isvalid = true;
      }
      if(space[num2] != 'X'){
        num2_isvalid = true;
        num2_isplace = true;
      }
      
      counter = 0;
      if(num1_isplace){counter--;}
      if(num2_isplace){counter--;}

      for(int i = 0; i < n; i++){
        if (space[i] != 'X'){
          counter++;
        }
      }

      if(counter == 1){
        Console.WriteLine("All stall are reserved.");
        isend = false;
      }

      if(counter < 1){
        Console.WriteLine("The entrance can’t be reserved.");
        isend = true;
        carslot = false;
      }

      if(num1_isvalid && num2_isvalid && carslot){
        space[num1] = 'X';
        space[num2] = 'X';
        Print(space,n);
      } 

      if((!num1_isvalid || !num2_isvalid) && carslot) {
        Console.WriteLine("The stall is reserved.");
      }
    }
  }

  static void Print(char[] space,int n){
    for(int i = 1; i < n; i++){
      Console.Write("{0} ",space[i]);
    }
    Console.WriteLine("");
  }
}