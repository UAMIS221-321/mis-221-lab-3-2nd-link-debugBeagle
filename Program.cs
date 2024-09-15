//main




string enjoymentLevel = GetEnjoymentlevel();

string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);

DisplayStadiumDetails (stadium, game);
  


//end main

 static string GetEnjoymentlevel(){ 
    Console.Clear();
    System.Console.WriteLine("Hey what enjoyment level are you at? Please choose from the following: boring, average, fun, and epic");
    string enjoymentLevel = Console.ReadLine();
    string lowerCaseUserEnjoyment = enjoymentLevel.ToLower().Trim();
    return lowerCaseUserEnjoyment;
}


static string GetStadiumRecommendation(string lowerCaseUserEnjoyment){
    if(lowerCaseUserEnjoyment == "boring"){
        return "Neyland Stadium";

    }
    else if(lowerCaseUserEnjoyment == "average"){
        return "Jordan Hare stadium";
    }
    else if(lowerCaseUserEnjoyment == "fun"){
        return "Tiger stadium";
    
    }
    else if(lowerCaseUserEnjoyment == "epic"){
        return "Saban field at Byrant-Denny Stadium";

    }
    else{
        return "that is a invaild response";
    }

}


static string GetGameRecommendation(string GetStadiumRecommendation){
    if( GetStadiumRecommendation == "Neyland Stadium"){
        return "UT vs Kent State";

    }
    else if( GetStadiumRecommendation == "Jordan Hare stadium"){
        return "Auburn vs kentucty";
    }
    else if( GetStadiumRecommendation == "Tiger stadium"){
        return "LSU vs Alabama";
    
    }
    else if( GetStadiumRecommendation == "Saban field at Byrant-Denny Stadium"){
        return "Alabama vs Auburn";

    }
    else{
        return "that is a invaild response";
    }

}



static void DisplayStadiumDetails(string stadium, string game)
{

    System.Console.WriteLine($" Your stadium choice is {stadium} and the best game for you is {game}");

}