//https://github.com/idivyanshusoni

public class XToThePowerN
{
    public double Perform(double x, int n)
    {
        long power = n;

        if (power < 0)
        {
            x = 1.0 / x;
            power = -power;
        }

        double result = 1.0;
        double currentPower = x;

        while (power > 0)
        {
            if (power % 2 == 1)
                result *= currentPower;

            currentPower *= currentPower;

            power /= 2;
        }

        return result;
    }
}