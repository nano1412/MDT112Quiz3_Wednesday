using System;

class Program{
  static void Main(string[] args){
    // initial variables
    int n = int.Parse(Console.ReadLine());
    n++;
    char[] slot = new char[n];
    for(int i = 0; i < n; i++){
      slot[i] = '_';
    }
    bool isnotend = true;

    while(isnotend){
      // loop input
      int num1 = int.Parse(Console.ReadLine());
      int num2 = int.Parse(Console.ReadLine());

      // declear condition booleen and reset once reach again
      bool num1_valid = false;
      bool num2_valid = false;
      bool num1_isplace = false;
      bool num2_isplace = false;
      bool carslot = true;

      // check if the slot are empty and check if num1 and num2 are being place
      Input(ref num1,ref num1_valid, ref num1_isplace, slot[num1]);
      Input(ref num2,ref num2_valid, ref num2_isplace, slot[num2]);
      
      // calculate how many slot left if num1 and num2 are being place before actually place them on to the slot
      int counter = 0;
      if(num1_isplace){counter--;}
      if(num2_isplace){counter--;}
      for(int i = 0; i < n; i++){
        if (slot[i] != 'X'){
          counter++;
        }
      }

      // Condition
      if(!num1_valid || !num2_valid) {
        Console.WriteLine("The stall is reserved.");
      }

      if(counter < 1){
        Console.WriteLine("The entrance can’t be reserved.");
        carslot = false;
      }

      // End condition
      if(counter == 1){
        Console.WriteLine("All stall are reserved.");
        isnotend = false;
      }

      // actually place num1 and num2 on to the array after every condition are checked and print it out
      if(num1_valid && num2_valid && carslot){
        slot[num1] = 'X';
        slot[num2] = 'X';
        Print(slot,n);
      } 
    }
  }
  static void Input(ref int num,ref bool valid, ref bool isplace, char isnotX){
    if(num < 0){
      num = 0;
      valid = true;
    }
    if(isnotX != 'X'){
      valid = true;
      isplace = true;
    } 
  }

  static void Print(char[] slot,int n){
    for(int i = 1; i < n; i++){
      Console.Write("{0} ",slot[i]);
    }
    Console.WriteLine("");
  }
}