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
      int firstnum = int.Parse(Console.ReadLine());
      int secondnum = int.Parse(Console.ReadLine());

      bool first = false;
      bool second = false;
      bool isplace1 = false;
      bool isplace2 = false;
      bool carslot = true;

      if(firstnum < 0){
        firstnum = 0;
        first = true;
      }
      if(space[firstnum] != 'X'){
        first = true;
        isplace1 = true;
      } 

      if(secondnum < 0){
        secondnum = 0;
        second = true;
      }
      if(space[secondnum] != 'X'){
        second = true;
        isplace2 = true;
      }
      
      
      counter = 0;
      if(isplace1){counter--;}
      if(isplace2){counter--;}

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



      if(first && second && carslot){
        space[firstnum] = 'X';
        space[secondnum] = 'X';
        Print(space,n);
      } 
      if((!first || !second) && carslot) {
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