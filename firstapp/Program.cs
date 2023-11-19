
//fibonacci series
using System.Net;

static void ShowFibonacciSeriesNumber(int level)
{
    int firstNumber = 0;
    int secondNumber = 1;
    Console.Write(firstNumber + " , " + secondNumber + " , ");
    int sum;
    for (int i = 2; i < level; i++)
    {
        sum = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = sum;
        Console.Write(secondNumber + ", ");
    }
}

// ShowFibonacciSeriesNumber(5);


//Prime number in a given range
static bool IsPrime(int n){
    int count = 0;

    // 0, 1 negative numbers are not prime
    if(n < 2)
        return false;

    for(int i=2; i<n ; i++){
    if(n%i==0){
        return false;
    }
}
return true;
}

// bool status=IsPrime(10);
int lower =1;
int upper =100;
for(int i=lower; i<=upper ; i++){
  if(IsPrime(i));
  Console.WriteLine(i);

}

// sum of digits
static int SumOfDigits(int n){
    int sum=0;
    int remainder;
    while(n!=0){
    remainder= n%10;
    sum += remainder;
    n= n/10;
    } 
  return sum;
}

// int a=SumOfDigits(125);
// Console.WriteLine(a);

//reverse number
static int ReverseNumber(int n){
    int sum=0;
    int remainder;
    while(n!=0){
    remainder= n%10;
    sum =sum*10+ remainder;
    n= n/10;
    } 
  return sum;
}

// int a=SumOfDigits(125);
// Console.WriteLine(a);


//Abundant number
static bool IsAbundant(int number){
int sum=0;
for(int i=1; i<number; i++){
  if(number%i==0){
    sum+=number;
  }
  if(sum>number){
    return true;
  }
}
return false;
}

// bool status=IsAbundant(2);
// Console.WriteLine(status);



static bool PrimeOrNot(int a)
{
    int i;
    bool isPrime = true;
    if (a == 0 || a == 1)
    {
        isPrime = false;
    }
    for (i = 2; i <= a / 2; ++i)
    {
        if (a % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    return isPrime;
}

// bool status=PrimeOrNot(12);
// Console.WriteLine(status);



// quadrants in which a given coordinates lies

static void quadrants(int x,int y){
if(x>0 && y>0){
   Console.WriteLine("point: " + x +"," +y+" lies in the first quadrant");
}
else if(x<0 && y>0){
   Console.WriteLine("point: " + x +"," +y+" lies in the second quadrant");
}
else if(x<0 && y<0){
   Console.WriteLine("point: " + x +"," +y+" lies in the third quadrant");
}
else if(x>0 && y<0){
   Console.WriteLine("point: " + x +"," +y+" lies in the forth quadrant");
}
else if(x==0 && y==0){
   Console.WriteLine("point: " + x +"," +y+" lies in origin");
}
else if(x!=0 && y==0){
   Console.WriteLine("point: " + x +"," +y+" lies in x-axis");
}
else if(x==0 && y!=0){
   Console.WriteLine("point: " + x +"," +y+" lies in y-axis");
}
}
// int o=quadrants(1,2);
// Console.WriteLine(o);



static int HCF(int number1,int number2){
//Highest Common Factor(HCF)

int num1 = 12;
int num2 = 36;
int HCF = 1;

for(int i=1; i<=num1 && i<=num2; i++ ){
    if(num1%i==0 && num2%i==0){
        HCF=i;
    }
  }
}
Console.WriteLine(HCF);

// get count of digits
static int GetCountOfDigits(int number){
int digit=0;
   while(number>0){
    digit++;
    number=number/10;
}
    return digit;
}

int pb = GetCountOfDigits(12);
Console.WriteLine(pb);