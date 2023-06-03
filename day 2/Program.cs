
            /////////////////////////////////////////////////////////
            /////    Calculator : giorgi kiparoidze           ///////
            /////////////////////////////////////////////////////////

using System;

namespace myworld{
    class Myprogram{
        //kalkulatoris funcqcia
        public static int Calculator(int a, char b, int c){
            switch(b){
                case '+': a+=c;break;
                case '-': a-=c;break;
                case '*': a*=c;break;
                case '/': a/=c;break;
            }
            return a;
        }

        //operatoris gadamowmebis funqcia
        public static bool OperatorCheck(char a){
            if (a == '+' || a=='-' || a=='*' || a=='/')
            return true;
            else{
                Console.WriteLine("shemotanili operatori ar aris misagebi!");
                return false;
            }
        }

        public static void Main(string[] args){
            

            Console.WriteLine("Calculator");

            //shemovitanot pirveli cvladi
            lable_A:
            Console.WriteLine("shemoitanet pirveli cvladi kalkulatoristvis :");
            string? userInput = Console.ReadLine();
            int firstNumber; 
            bool numberCheck = int.TryParse(userInput, out firstNumber);
            
            //shemotanili cvladis gadamowmeba (aris tu ara ricxvi)
            if(!numberCheck){
                Console.WriteLine("shemotanili cvladi ar aris ricxvi");
                goto lable_A;
            }

            //operatoris shemotana
            lable_B:
            Console.WriteLine("shemoitanet operatori operaciistvis : ");
            string? userInput1 = Console.ReadLine();
            char oper;
            bool operatorCheck = char.TryParse(userInput1, out oper);

            //shemotanili operatoris gadamowmeba
            if(!operatorCheck){
                Console.WriteLine("shemotanili cvladi ar aris misagebi");
                goto lable_B;
            }
            if (!OperatorCheck(oper)){
                goto lable_B;
            }

            //shemovitanot meore  cvladi
            lable_C:
            Console.WriteLine("shemoitanet meore cvladi kalkulatoristvis :");
            string? userInput2 = Console.ReadLine();
            int secondNumber; 
            bool numberCheck1 = int.TryParse(userInput2, out secondNumber);
            
            //shemotanili cvladis gadamowmeba (aris tu ara ricxvi)
            if(!numberCheck1){
                Console.WriteLine("shemotanili cvladi ar aris ricxvi");
                goto lable_C;
            }

            //string cvladi sadac shevinaxavs operaciebs
            userInput = userInput + userInput1 + userInput2;
            firstNumber = Calculator(firstNumber, oper, secondNumber);

            lable_D:
            Console.WriteLine("gsurt operaciis gagrdzeleba? (daweret ki an ara)");
            string? gagrdzeleba = Console.ReadLine();
            if(gagrdzeleba == "ki"){
                goto lable_B;
            }
            else if(gagrdzeleba == "ara"){
                Console.WriteLine($"{userInput}={firstNumber}");
            }
            else{
                Console.WriteLine("migebuli pasuxi ar sheesabameba pirobebs");
                goto lable_D;
            }

            //sxva operaciistvis lupis gaaqtiureba
            lable_E:
            Console.WriteLine("gsurt sxva operaciis shesruleba? (daweret ki an ara)");
            string? otherOperation = Console.ReadLine();
            if(otherOperation == "ki") goto lable_A;
            else if (otherOperation == "ara") return;
            else{
                Console.WriteLine("pasuxi aradamakmayofilebelia!");
                goto lable_E;
            }
        }
    }
}