
//fibonacci series
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







