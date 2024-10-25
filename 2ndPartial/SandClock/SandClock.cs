class SandClock
{
    int[][] map = [
        [1,2,2,2],
        [0,1,2,0],
        [1,2,2,2],
        [0,0,0,0,]
    ];

    public void Map()
    {
        for (int i = 0; i < map.Length; i++)
        {
            for (int j = 0; j < map.Length; j++)
            {
                Write(map[i][j]);
                Write(" ");
            }
            WriteLine(" ");
        }

        WriteLine($"most: {GetLength(map)}");
    }
    public int suma(int i, int j, int[][] map)
    {
        return map[i][j] + map[i - 1][j] + map[i - 1][j - 1] + map[i - 1][j + 1]
        + map[i + 1][j] + map[i + 1][j - 1] + map[i + 1][j + 1];
    }

    public int GetLength(int[][] map)
    {
        int maxvalue = -99999;
        int sum = 0;
        for (int i = 1; i < map.Length - 1; i++)
        {
            for (int j = 1; j < map.Length - 1; j++)
            {
                sum = suma(i, j, map);
                if (sum > maxvalue)
                    maxvalue = sum;
            }
        }
        return maxvalue;

    }
}
