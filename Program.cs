
List<int> scores = [3, 45, 82, 97, 92, 100, 81, 60];

// LINQ
//IEnumerable<int> scoreQuery =
//    from score in scores
//    where score > 80
//    orderby score descending
//    //select $"The score is lower 80 is {score}";
//    select score;

// LINQ
var scoreQuery = scores.Where(s => s > 80)
                       .OrderByDescending(s => s);

List<int> myScores = scoreQuery.ToList();

foreach (var score in myScores)
{ 
    Console.WriteLine(score);
}