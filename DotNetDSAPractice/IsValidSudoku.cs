//https://github.com/idivyanshusoni

public class IsValidSudoku
{
    public bool Perform(string[] input)
    {
        var board = CreateBoard(input);

        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxs = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxs[i] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char value = board[i][j];

                if (value == '.')
                    continue;

                int boxIndex = (i / 3) * 3 + (j / 3);

                if (rows[i].Contains(value) || cols[j].Contains(value) || boxs[boxIndex].Contains(value))
                    return false;

                rows[i].Add(value);
                cols[j].Add(value);
                boxs[boxIndex].Add(value);
            }
        }

        return true;
    }

    private char[][] CreateBoard(string[] input)
    {
        char[][] board = new char[9][];

        for (int i = 0; i < 9; i++)
            board[i] = input[i].ToCharArray();

        return board;
    }
}