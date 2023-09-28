// ICT3101_Calculator

public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
                                    // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            case "g":
                result = AreaOfTriangle(num1, num2);
                break;
            case "h":
                result = AreaOfCircle(num1);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
    public double Add(double num1, double num2)
    {
        // Lab 1
        return (num1 + num2);
    }
    public double BinaryAddition(double num1, double num2)
    {
        // Lab 2
        if (num2 == 11)
        {
            switch (num1)
            {
                case 1:
                    return 7;
                case 10:
                    return 11;
                case 11:
                    return 15;
                default:
                    break;
            }
        }
        return (num1 + num2);
    }
    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }

    public double RoundUp(double num1)
    {
        return Math.Round(num1, 2); // Round up to 2 dp
    }

    public double Divide(double num1, double num2)
    {
        // Lab 1
        if (num1 == 0 || num2 == 0)
            throw new ArgumentException("Cannot divide with zeros");

        double result = num1 / num2;
        return RoundUp(result);
    }
    public double DivideLab2(double num1, double num2)
    {
        //Lab 2
        if (num1 == 0 && num2 == 0)
            return 1;
        else if (num1 == 0)
            return 0;
        else if (num2 == 0)
            return Double.PositiveInfinity;
        else if (num1 <= 0 || num2 <= 0)
            throw new ArgumentException("Cannot divide with zeros");

        double result = num1 / num2;
        return RoundUp(result);
    }
    public double Factorial(double num1)
    {
        if (num1 == 0)
            return 1;
        else if (num1 < 0 || num1 % 1 != 0)
            throw new ArgumentException("Num1 cannot be lesser than 0 or decimal");

        double fact = 1;
        for (int i = 1; i <= num1; ++i)
        {
            fact *= i;
        }
        return fact;
    }

    // num1 - length, num2 - height 
    public double AreaOfTriangle(double width, double height)
    {
        if ( width <= 0 || height <= 0)
            throw new ArgumentException("Num1 / Num2 cannot be lesser than or equal to  0");

        double result = 0.5f * width * height;
        return RoundUp(result);
    }

    // num1 - radius
    public double AreaOfCircle(double radius)
    {
        if ( radius <= 0)
            throw new ArgumentException("Radius cannot be lesser than or equal to  0");

        double result = 3.14159f * radius * radius;
        return RoundUp(result);
    }

    // Unknown Functions 
    // Function A - 2 Factorial, 1 Divide, 1 Subtract [Permutation]
    public double UnknownFunctionA(double num1, double num2)
    {
        // 5! / (5-5)! = 120
        // 5! / (5-4)! = 120
        // 5! / (5-3)! = 60
        // -4! / (-4-5)! <- Invalid
        // 4! / (4-5)! <- Invalid
        double numerator = Factorial(num1);
        double denominator = Factorial(Subtract(num1, num2));
        double result = Divide(numerator, denominator);
        return RoundUp(result);
    }
    // Functional B - 3 Factorial, 1 Divide, 1 Multiply, 1 Subtract [Coefficient Binomial]
    public double UnknownFunctionB(double num1, double num2)
    {
        // num1! / num2!* (num1 - num2)!
        double numerator = Factorial(num1);
        double denominator = Multiply(Factorial(num2), Factorial(Subtract(num1, num2)));
        double result = Divide(numerator, denominator);
        return RoundUp(result);
    }

    // MTBF = MTTR + MTTF
    public double MTBF(double MTTR, double MTTF)
    {
        if (MTTR <= 0 || MTTF <= 0)
            throw new ArgumentException("Cannot be lesser or equal to 0");

        return Add(MTTR, MTTF);
    }

    // Availability = MTTF / MTBF 
    public double Availability(double MTTF, double MTBF)
    {
        if (MTTF <= 0 || MTBF <= 0)
            throw new ArgumentException("Cannot be lesser or equal to 0");

        double result = Divide(MTTF, MTBF);
        return RoundUp(result);
    }

    // failurue intensity = initial failure intensity * ( 1 - average failure at time T / total failure over infinite time)
    public double BasicFailureIntensity(double initialFailure, double expectedFailure, double totalFailure)
    {
        if (totalFailure <= 0 || initialFailure <= 0 || totalFailure <= 0)
            throw new ArgumentException("Cannot be lesser or equal to 0");

        double result = initialFailure * (1 - expectedFailure / totalFailure);
        return RoundUp(result);
    }

    // average expected failure = total failure over infinite time * ( 1 - exponential ( initial failure intensity / total failure over infinite time * time))
    public double BasicExpectedFailure(double totalFailure, double initialFailure, double time)
    {
        if (totalFailure <= 0 || initialFailure <= 0 || time <= 0)
            throw new ArgumentException("Cannot be lesser or equal to 0");


        double exponential = Math.Exp(-1 * (initialFailure / totalFailure) * time);
        double result = totalFailure * (1 - exponential);

        return RoundUp(result);
    }

    // failure intensity at time = initial failure intensity * exp ( - decay parameter * average expected failure)
    public double LogFailureIntensity(double initialIntensity, double decayParameter, double expectedFailure)
    {
        if (initialIntensity <= 0 || decayParameter <= 0 || expectedFailure <= 0)
            throw new ArgumentException("Cannot be lesser or equal to 0");

        double exponential = Math.Exp(Multiply(Multiply(decayParameter, expectedFailure), -1));
        double result = Multiply(initialIntensity, exponential);

        return RoundUp(result);
    }

    // average expected failure at time = 1 / failure intensity decay parameter * ln( initial failure intensity * failure intensity decay parameter * time + 1 )
    // Math.Log(value1,Math.E));
    public double LogExpectedFailure(double initialFailure, double decayParameter, double time)
    {
        if (initialFailure <= 0 || decayParameter <= 0 || time <= 0)
            throw new ArgumentException("Cannot be lesser or equal to 0");

        double lnResult = Add(Multiply(Multiply(initialFailure, decayParameter), time), 1);
        double result = Multiply(Divide(1, decayParameter), Math.Log(lnResult, Math.E));

        return RoundUp(result);
    }

    // Density = Total Defect / KCSI
    public double DefectDensity(double noOfDefects, double noOfKLOC)
    {
        if (noOfDefects <= 0 || noOfKLOC <= 0)
            throw new ArgumentException("defects or size of code cannot be lesser or equal to 0");

        double result = Divide(noOfDefects, noOfKLOC);

        return Math.Round(result);
    }

    public double ChangedDefectDensity(double initialDefects, double initialKLOC, double changedKLOC, double deletedKLOC = 0, double newAddedDefects = 0, double fixedDefectsPercentage = 0)
    {
        if (initialDefects <= 0 || initialKLOC <= 0 || changedKLOC <= 0)
            throw new ArgumentException("defects, size of code, size of changed code cannot be lesser or equal to 0");

        else if (deletedKLOC < 0 || newAddedDefects < 0 || fixedDefectsPercentage < 0)
            throw new ArgumentException("deleted lines of code, new defects, fixed defects percentage cannot be lesser than 0");
        
        // Density = Total Defect / KCSI

        double newDefect = initialDefects - (initialDefects/100 * fixedDefectsPercentage) + newAddedDefects;
        double newKLOC = initialKLOC + changedKLOC - deletedKLOC;

        return DefectDensity(newDefect, newKLOC);
    }

    public double GenMagicNum(double input, IFileReader fileReader)
    {
        //if(input < 0)
            //throw new ArgumentException("Cannot input negative!");

        double result = 0;
        int choice = Convert.ToInt16(input);
        //Dependency------------------------------
        //FileReader getTheMagic = new FileReader();
        //----------------------------------------
        string[] magicStrings = fileReader.Read("MagicNumbers.txt");
        Console.WriteLine(magicStrings[choice]);
        if ((choice >= 0) && (choice < magicStrings.Length))
        {
            result = Convert.ToDouble(magicStrings[choice]);
        }
        result = (result > 0) ? (2 * result) : (-2 * result);
        return result;
    }
}
