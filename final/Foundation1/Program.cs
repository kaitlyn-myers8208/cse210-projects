using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Top High Energy Action Videos of Studio C", "Studio C", 2423);
        Comment comment1 = new Comment("@babblingbrook", "Any sketch with Jason is high energy!!");
        Comment comment2 = new Comment("@anirudhjasti", "Possibly the most underrated show in the history of the world.");
        Comment comment3 = new Comment("@shaniqualafaye8124", "The things Jason does for Studio C is amazing...");
        video1.Comments.Add(comment1);
        video1.Comments.Add(comment2);
        video1.Comments.Add(comment3);
        
        Video video2 = new Video("GOOGLE TRANSLATE MAKES BANANA BREAD!", "Imbrandonfarris", 406);
        Comment comment4 = new Comment("@courtneyvial3799", "I have never seen anyone hug an oven until today. Not just any hug either, a big ol' tackle hug.");
        Comment comment5 = new Comment("@cragthesimp2156", "The fact that this man used to be in the food industry... I'd give him a five star review");
        Comment comment6 = new Comment("@Michelle-fx", "I bet that Brandon has the best immune system after all these videos");
        video2.Comments.Add(comment4);
        video2.Comments.Add(comment5);
        video2.Comments.Add(comment6);

        Video video3 = new Video("Villain Therapy: VOLDEMORT", "Cinema Therapy", 1664);
        Comment comment7 = new Comment("@ashtingreene8725", "I love that the fandom recognizes that the problem is usually Dumbledore");
        Comment comment8 = new Comment("@whitedawg2583", "Ralph Fiennes performance as Lord Voldy is just something else, HE WAS HIM");
        Comment comment9 = new Comment("@revolution5298", "Y'all are so in sync it makes me laugh lol. I can tell you guys are good friends. Makes me happy!");
        video3.Comments.Add(comment7);
        video3.Comments.Add(comment8);
        video3.Comments.Add(comment9);


        video1.DisplayVideo();
        video2.DisplayVideo();
        video3.DisplayVideo();
    }
}