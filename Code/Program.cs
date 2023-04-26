using System;

class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    n++;
    char[] space = new char[n];
    for(int i = 0; i < n; i++){
      space[i] = '_';
    }
    bool isend = true;

    while(isend){
      // loop input
      int num1 = int.Parse(Console.ReadLine());
      int num2 = int.Parse(Console.ReadLine());
      
      // this is ass af, I'm braindead now
      bool num1_isvalid = num1 < 0;
      bool num2_isvalid = num2 < 0;
      if(num1 < 0){num1 = 0;}
      if(num2 < 0){num2 = 0;}
      bool num1_isplace = space[num1] != 'X';
      bool num2_isplace = space[num2] != 'X';
      if(space[num1] != 'X'){num1_isvalid = true;} 
      if(space[num2] != 'X'){num2_isvalid = true;}
      bool invalid = false;
      
      //count empty space
      int counter = 0;
      if(num1_isplace){counter--;}
      if(num2_isplace){counter--;}
      for(int i = 0; i < n; i++){
        if (space[i] != 'X'){
          counter++;
        }
      }

      // condition
      if(counter < 1){
        Console.WriteLine("The entrance can’t be reserved.");
        invalid = true;
      }

      if(!(num1_isvalid && num2_isvalid)){
        Console.WriteLine("The stall is reserved.");
        invalid = true;
      }

      if(!invalid){
        space[num1] = 'X';
        space[num2] = 'X';
        Print(space,n);
      } 

      // end condition
      if(counter == 1){
        Console.WriteLine("All stall are reserved.");
        isend = false;
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