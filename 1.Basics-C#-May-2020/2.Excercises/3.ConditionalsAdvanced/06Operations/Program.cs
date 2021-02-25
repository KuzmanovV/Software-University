    using System;

    namespace _06Operations
    {
        class Program
        {
            static void Main(string[] args)
            {
                /*N1 – цяло число в интервала [0...40 000]
                N2 – цяло число в интервала [0...40 000]
                Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“*/
                int N1 = int.Parse(Console.ReadLine());
                int N2 = int.Parse(Console.ReadLine());
                string optor = Console.ReadLine();
                string operation = "";
                double result = 0;
                string EO = "";
                if ((optor=="/" || optor=="%") && N2 == 0)
                {
                    operation = $"Cannot divide {N1} by zero";
                }
                else
                {
                    switch (optor)
                    {
                    case "+":
                        result = N1 + N2;
                    
                        operation = $"{N1} {optor} {N2} = {result} - ";
                        break;
                        case "-":
                        result = N1 - N2;
                    
                        operation = $"{N1} {optor} {N2} = {result} - ";
                        break;
                        case "*":
                        result = N1 * N2;
                    
                        operation = $"{N1} {optor} {N2} = {result} - ";
                        break;
                    case "/":
                    
                            result = N1*1.0 / N2;
                            operation = $"{N1} / {N2} = {result:f2}";
                  
                        break;
                    case "%":
                    
                            result = N1 % N2;
                            operation = $"{N1} % {N2} = {result}";
                
                        break;
                    }
                    if (optor=="+"||optor=="-"||optor=="*")
                    {
                    if (result%2 == 0)
                    {
                    EO = "even";
                    }
                    else
                    {
                    EO = "odd";
                    }
                    }
            
                operation += EO;
                }
            
                Console.WriteLine(operation);
            }
        }
    }
