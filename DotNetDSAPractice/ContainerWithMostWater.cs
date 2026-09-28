//https://github.com/idivyanshusoni

public class ContainerWithMostWater
{
    public object Perform(int[] heights)
    {
        int left = 0;
        int right = heights.Length - 1;

        //volume is represented by area
        int maxVolume = 0;

        while (left < right)
        {
            int width = right - left;
            int height = Math.Min(heights[left], heights[right]);

            int volume = width * height;
            maxVolume = Math.Max(maxVolume, volume);

            if (heights[left] < heights[right])
                left++;
            else
                right--;
        }

        return maxVolume;
    }
}