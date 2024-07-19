// See https://aka.ms/new-console-template for more information

int[] scores = new int[6];
scores=GetTestScores();
int highScore=GetHighestScore(scores);
Console.WriteLine("Highest Score  is {0}:", highScore);
double averageScore = GetAverageScore(scores);
Console.WriteLine("Average Score  is {0}:", averageScore);
double lowScore = GetLowestScore(scores);
Console.WriteLine("Lowest Score  is {0}:", lowScore);
static int[] GetTestScores()
{
    int[] scoresNew = new int[6];

    for (int i = 0; i < 6; i++)
    {
       

        Console.WriteLine("Enter test score {0}:", i + 1);
        scoresNew[i] = int.Parse(Console.ReadLine());
    }
    return scoresNew;
}

static int GetHighestScore(int[] scores)
{
    int highestScore = scores.Max();
   
    return highestScore;
}

static Double GetAverageScore(int[] scores)
{
    double averageScore =  scores.Average();

    return averageScore;
}


static int GetLowestScore(int[] scores)
{
    int lowScore = scores.Min();

    return lowScore;
}