using System;

public class Question1
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swapping: ");
            Console.WriteLine($"num1 = {num1}");
            Console.WriteLine($"num2 = {num2}");

            // Swapping the numbers using assignment operators via Temporary Variable
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping: ");
            Console.WriteLine($"num1 = {num1}");
            Console.WriteLine($"num2 = {num2}");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Invalid input format. Please enter an integer.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}



public class Velocity
{
    public static void Main()
    {
        double distance, time, velocity;

        Console.Write("Enter the distance in meters: ");
        distance = double.Parse(Console.ReadLine());

        Console.Write("Enter the time in seconds: ");
        time = double.Parse(Console.ReadLine());

        velocity = distance / time;

        Console.WriteLine("The velocity is: " + velocity + " meters/second.");
    }
}


public class Acceleration
{
    public static void Main()
    {
        double velocity1, velocity2, time, acceleration;

        Console.Write("Enter the initial velocity in meters/second: ");
        velocity1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the final velocity in meters/second: ");
        velocity2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the time in seconds: ");
        time = double.Parse(Console.ReadLine());

        acceleration = (velocity2 - velocity1) / time;

        Console.WriteLine("The acceleration is: " + acceleration + " meters/second².");
    }
}


class Question2a
{
    static void Main(string[] args)
    {
        // take input from user
        Console.Write("Enter the initial velocity (u): ");
        double u = double.Parse(Console.ReadLine());

        Console.Write("Enter the acceleration (a): ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter the time (t): ");
        double t = double.Parse(Console.ReadLine());

        // calculate the final velocity
        double v = u + a * t;

        // print the result
        Console.WriteLine($"The final velocity is {v} m/s");
    }
}

class Question2b
{
    static void Main(string[] args)
    {
        double s, u, t, a;

        Console.WriteLine("Enter the initial velocity (u): ");
        u = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time taken (t): ");
        t = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the acceleration (a): ");
        a = Convert.ToDouble(Console.ReadLine());

        s = u * t + 0.5 * a * t * t;

        Console.WriteLine("The distance traveled is: " + s);
    }
}

class Question2c
{
    static void Main(string[] args)
    {
        double s, v, a, t;

        Console.Write("Enter initial velocity v (m/s): ");
        v = double.Parse(Console.ReadLine());

        Console.Write("Enter acceleration a (m/s^2): ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Enter time t (s): ");
        t = double.Parse(Console.ReadLine());

        s = v * t - 0.5 * a * Math.Pow(t, 2);

        Console.WriteLine("The distance covered is: " + s + " m");
    }
}
class Question2d
{
    static void Main(string[] args)
    {
        float acceleration, initial_velocity, final_velocity, distance;
        Console.Write("Enter the acceleration: ");
        acceleration = float.Parse(Console.ReadLine());
        Console.Write("Enter the initial velocity: ");
        initial_velocity = float.Parse(Console.ReadLine());
        Console.Write("Enter the final velocity: ");
        final_velocity = float.Parse(Console.ReadLine());
        distance = (float)((Math.Pow(final_velocity, 2) - Math.Pow(initial_velocity, 2)) / (2 * acceleration));
        Console.WriteLine("The distance traveled is: " + distance);
    }
}



class Question2e
{
    static void Main(string[] args)
    {
        double s, u, v, t;
        Console.WriteLine("Enter the initial velocity u:");
        u = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the final velocity v:");
        v = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the time taken t:");
        t = Convert.ToDouble(Console.ReadLine());

        s = 0.5 * (u + v) * t;
        Console.WriteLine("The value of s is: " + s);
    }
}



class Question3
{
    static void Main(string[] args)
    {
        // Take 10 float inputs from the user
        float[] nums = new float[10];
        for (int i = 0; i < 10; i++)
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.Write("Enter float number {0}: ", i + 1);
                if (float.TryParse(Console.ReadLine(), out float input))
                {
                    nums[i] = input;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a float value.");
                }
            }
        }

        // Calculate product, sum, square, and difference
        float product = 1.0f;
        float sum = 0.0f;
        float square = 0.0f;
        float difference = 0.0f;
        for (int i = 0; i < 10; i++)
        {
            product *= nums[i];
            sum += nums[i];
            square += nums[i] * nums[i];
            if (i > 0)
            {
                difference -= nums[i];
            }
            else
            {
                difference = nums[i];
            }
        }

        // Print results
        Console.WriteLine("Product: {0}", product);
        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Square: {0}", square);
        Console.WriteLine("Difference: {0}", difference);
    }
}


class Voltage
{
    static void Main()
    {
        float current, resistance, voltage;
        Console.Write("Enter the current (in amperes): ");
        current = float.Parse(Console.ReadLine());
        Console.Write("Enter the resistance (in ohms): ");
        resistance = float.Parse(Console.ReadLine());
        voltage = current * resistance;
        Console.WriteLine("The voltage (in volts) is: " + voltage);
    }
}

class Power
{
    static void Main(string[] args)
    {
        double voltage, current, power;

        Console.Write("Enter the voltage: ");
        voltage = double.Parse(Console.ReadLine());

        Console.Write("Enter the current: ");
        current = double.Parse(Console.ReadLine());

        power = voltage * current;

        Console.WriteLine("Power = " + power + " watts");
    }
}
class Series
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of resistors: ");
        int n = int.Parse(Console.ReadLine());
        double total = 0.0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter the resistance of resistor " + i + ": ");
            double r = double.Parse(Console.ReadLine());
            total += r;
        }
        Console.WriteLine("The total resistance of the " + n + " resistors in series is " + total + " ohms.");
    }
}

class Parallel
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of resistors: ");
        int n = int.Parse(Console.ReadLine());
        double total = 0.0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter the resistance of resistor " + i + ": ");
            double r = double.Parse(Console.ReadLine());
            total += 1.0 / r;
        }
        double parallel_resistance = 1.0 / total;
        Console.WriteLine("The total resistance of the " + n + " resistors in parallel is " + parallel_resistance + " ohms.");
    }
}

class IdealTransformerAction
{
    static void Main(string[] args)
    {
        double inputVoltage, outputVoltage, inputCurrent, outputCurrent, turnsRatio;

        // Get input parameters from user
        Console.Write("Enter the input voltage: ");
        inputVoltage = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the output voltage: ");
        outputVoltage = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the input current: ");
        inputCurrent = Convert.ToDouble(Console.ReadLine());

        // Calculate turns ratio
        turnsRatio = outputVoltage / inputVoltage;

        // Calculate output current
        outputCurrent = inputCurrent / turnsRatio;

        // Print results
        Console.WriteLine("Turns ratio: " + turnsRatio);
        Console.WriteLine("Output current: " + outputCurrent);
    }
}


class Question5
{
    static void Main(string[] args)
    {
        Console.Write("Enter your marks: ");
        if (!float.TryParse(Console.ReadLine(), out float marks))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        string grade;
        if (marks > 89)
        {
            grade = "A+";
        }
        else if (marks > 79)
        {
            grade = "B";
        }
        else if (marks > 69)
        {
            grade = "C";
        }
        else if (marks > 49)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine("Your grade is: {0}", grade);
    }
}

class Question6
{
    static void Main(string[] args)
    {
        Console.Write("Enter a character: ");
        char input = Console.ReadKey().KeyChar;

        switch (Char.ToUpper(input))
        {
            case 'J':
                Console.WriteLine("\nJanuary June July");
                break;
            case 'F':
                Console.WriteLine("\nFebruary");
                break;
            case 'M':
                Console.WriteLine("\nMarch May");
                break;
            case 'A':
                Console.WriteLine("\nApril August");
                break;
            case 'S':
                Console.WriteLine("\nSeptember");
                break;
            case 'O':
                Console.WriteLine("\nOctober");
                break;
            case 'D':
                Console.WriteLine("\nDecember");
                break;
            default:
                Console.WriteLine("\nInvalid input. Please enter a valid character.");
                break;
        }
    }
}

class Question7
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        int n, sum = 0;
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i)) sum += i;
        }

        Console.WriteLine($"The sum of all prime numbers between 1 and {n} is {sum}");
    }
}

class Question8a
{
    static void Main()
    {
        int n;
        Console.Write("Enter the number of rows: ");
        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

class Question8b
{
    static void Main()
    {
        int n;
        Console.Write("Enter the number of rows: ");
        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

class Question8c
{
    static void Main(string[] args)
    {
        int n = 0;
        Console.Write("Enter the number of rows: ");
        n = Convert.ToInt32(Console.ReadLine());
        int num = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
    }
}


class Question8d
{
    static void Main(string[] args)
    {
        int n = 0;
        Console.Write("Enter the number of rows: ");
        n = Convert.ToInt32(Console.ReadLine());
        char c = 'A';

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(c + " ");
                c++;
            }
            Console.WriteLine();
        }
    }
}

class Question8e
{
    static void Main(string[] args)
    {
        int n = 0;
        Console.Write("Enter the number of rows: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

class Question9
{
    public static void Main()
    {
        // Take input for the array
        Console.WriteLine("Enter the elements of the array, separated by spaces:");
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');
        int[] arr = Array.ConvertAll(elements, int.Parse);

        // Find and print leaders in the array
        Console.WriteLine("Leaders in the array:");
        int n = arr.Length;
        int maxSoFar = arr[n - 1];
        Console.Write(maxSoFar + " ");
        for (int i = n - 2; i >= 0; i--)
        {
            if (arr[i] > maxSoFar)
            {
                maxSoFar = arr[i];
                Console.Write(maxSoFar + " ");
            }
        }
    }
}

class Question10
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int evenCount = 0, oddCount = 0, primeCount = 0;

        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }

            bool isPrime = true;
            if (arr[i] <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int j = 2; j <= Math.Sqrt(arr[i]); j++)
                {
                    if (arr[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                primeCount++;
            }
        }

        Console.WriteLine("Number of even integers: " + evenCount);
        Console.WriteLine("Number of odd integers: " + oddCount);
        Console.WriteLine("Number of prime integers: " + primeCount);
    }
}


class Question11
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please enter a string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("\nPlease select an operation:");
            Console.WriteLine("1. Find the length of the string");
            Console.WriteLine("2. Reverse the string");
            Console.WriteLine("3. Convert the string to uppercase");
            Console.WriteLine("4. Convert the string to lowercase");
            Console.WriteLine("5. Count the number of occurrences of a character in the string");
            Console.WriteLine("6. Replace all occurrences of a character in the string with another character");
            Console.WriteLine("7. Exit the program");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("The length of the string is: " + inputString.Length);
                    break;
                case 2:
                    char[] charArray = inputString.ToCharArray();
                    Array.Reverse(charArray);
                    Console.WriteLine("The reversed string is: " + new string(charArray));
                    break;
                case 3:
                    Console.WriteLine("The uppercase string is: " + inputString.ToUpper());
                    break;
                case 4:
                    Console.WriteLine("The lowercase string is: " + inputString.ToLower());
                    break;
                case 5:
                    Console.WriteLine("Please enter the character to count: ");
                    char charToCount = Console.ReadLine()[0];
                    int count = 0;
                    foreach (char c in inputString)
                    {
                        if (c == charToCount)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("The character '" + charToCount + "' appears " + count + " times in the string.");
                    break;
                case 6:
                    Console.WriteLine("Please enter the character to replace: ");
                    char charToReplace = Console.ReadLine()[0];
                    Console.WriteLine("Please enter the new character: ");
                    char newChar = Console.ReadLine()[0];
                    string replacedString = inputString.Replace(charToReplace, newChar);
                    Console.WriteLine("The new string is: " + replacedString);
                    break;
                case 7:
                    Console.WriteLine("Exiting the program...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }
}
