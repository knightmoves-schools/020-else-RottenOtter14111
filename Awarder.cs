namespace knightmoves;
public class Awarder
{
    // Add your code here
    public string CalculateAward(points){
        if(points > 99){
            return "First Place";
        }
        if(points > 49 && points < 100){
            return "Second Place";
        } else {
            return "Participation Award";
        }
    }
}

