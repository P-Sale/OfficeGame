using System;


namespace start
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] characters = new[]{"Micheal Scott", "Holly Flax", "Stanley Hudson", "Kevin Malone", "Meredith Palmer",
            "Kelly Kapoor", "Jim Halpert", "Pam Beesly", "Dwight Schrute", "Creed Bratton", "Robert California"};
            Random rand = new Random();
            int index = rand.Next(characters.Length);
            int index2 = rand.Next(characters.Length);

            Console.WriteLine(@"
  _______ _             ____   __  __ _            _______   _       _       
 |__   __| |           / __ \ / _|/ _(_)          |__   __| (_)     (_)      
    | |  | |__   ___  | |  | | |_| |_ _  ___ ___     | |_ __ ___   ___  __ _ 
    | |  | |_ \ / _ \ | |  | |  _|  _| |/ __/ _ \    | | ,__| \ \ / / |/ _  |
    | |  | | | |  __/ | |__| | | | | | | (_|  __/    | | |  | |\ V /| | (_| |
    |_|  |_| |_|\___|  \____/|_| |_| |_|\___\___|    |_|_|  |_| \_/ |_|\__,_|
                                                                             "
                                                                             
);
            Console.WriteLine("\tWelcome to the the biggest (that's what she said) office trivia game!");     //Game introduction and name input
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\tDo you want to play by yourself or go head to head with a friend?");         //single or two player selection 
            Console.WriteLine();
            Console.WriteLine("\tType '1' for by yourself or '2' for full on Dunder Mifflin battle mode");
            string input = Console.ReadLine();
            while (input != "1" & input != "2")         //catch to esure the player selects a proper game path
            {
                Console.WriteLine("Please READ the instructions...if you are messing up now then it doesn't look good for you.");
                input = Console.ReadLine();
            }
            Console.Clear();

            if (input == "1")
            {
                Console.WriteLine("Alright, time for sad lonely mode.....sorry, I didnt mean that.");                   //single player route
                Console.ReadLine();
                Player p1 = new Player();
                p1.name = characters[index];
                Console.WriteLine("Sad lonely player, you will now be known as " + p1.name);
                Console.ReadLine();
                Console.Clear();
                /////////////////////////////////////question 1//////////////////////////////////////////////////////////
                Console.WriteLine("Question 1: Who was the first VP of Northeast sales in the show?");
                Console.WriteLine("\ta.....Ryan");
                Console.WriteLine("\tb.....Jan");
                Console.WriteLine("\tc.....Michael");
                Console.WriteLine("\td.....Stanley");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a1 = Console.ReadLine();

                while (a1 != "a" & a1 != "b" & a1 != "c" & a1 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a1 = Console.ReadLine();
                }

                switch (a1)
                {
                    case "a":
                        Console.WriteLine("that is not right, ryan was VP of Northeast sales after jan");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Jan was the first VP of Northeast sales in the show.");
                        break;
                    case "b":
                        Console.WriteLine("Wow " + p1.name + "....you're right");
                        p1.score += 1;
                        break;
                    case "c":
                        Console.WriteLine("Michael was never the VP of Northeast sales....genius.");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Jan was the first VP of Northeast sales in the show.");
                        break;
                    case "d":
                        Console.WriteLine("Stanley could've been VP of Northeast sales....but then pretzel day happened....");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Jan was the first VP of Northeast sales in the show.");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ooooooo " + p1.name + " here we gooooo....its gonna be goooooood....");
                Console.WriteLine("\t\t Current Score: " + p1.score);
                Console.ReadLine();
                Console.Clear();
                //////////////////////////////////question 2//////////////////////////////////////////////////////////
                Console.WriteLine("Question 2: What state did Michael and Holly move to?");
                Console.WriteLine("\ta.....Colorado");
                Console.WriteLine("\tb.....Texas");
                Console.WriteLine("\tc.....They stayed in Pennsylvania");
                Console.WriteLine("\td.....Washington");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a2 = Console.ReadLine();

                while (a2 != "a" & a2 != "b" & a2 != "c" & a2 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a2 = Console.ReadLine();
                }

                switch (a2)
                {
                    case "a":
                        Console.WriteLine("Jeeze " + p1.name + " do you watch anything else?");
                        p1.score += 1;
                        break;
                    case "b":
                        Console.WriteLine("Texas....really?.....really...");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Michael and Holly moved to Colorado.");
                        break;
                    case "c":
                        Console.WriteLine("If fairy tales were real....if only...");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Michael and Holly moved to Colorado.");
                        break;
                    case "d":
                        Console.WriteLine("Michael loves snow...not rain");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Michael and Holly moved to Colorado.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("That was tough....but we're getting tougher " + p1.name + "!");
                Console.WriteLine("\t\tCurrent Score: " + p1.score);
                Console.ReadLine();
                Console.Clear();
                ////////////////////////////////////question 3//////////////////////////////////////////////////////////
                Console.WriteLine("Question 3: What was the name of Michael's rival paper company?");
                Console.WriteLine("\ta.....Really good paper");
                Console.WriteLine("\tb.....Paper 'r Us");
                Console.WriteLine("\tc.....Mifflin Dunder paper");
                Console.WriteLine("\td.....Michael Scott Paper Co");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a3 = Console.ReadLine();

                while (a3 != "a" & a3 != "b" & a3 != "c" & a3 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a3 = Console.ReadLine();
                }

                switch (a3)
                {
                    case "a":
                        Console.WriteLine("Paper is more evil than good");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("His company was called the Michael Scott Paper Co");
                        break;
                    case "b":
                        Console.WriteLine("Theres no 'us' in paper");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("His company was called the Michael Scott Paper Co");
                        break;
                    case "c":
                        Console.WriteLine("A name switch?...did you watch the show?");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("His company was called the Michael Scott Paper Co");
                        break;
                    case "d":
                        Console.WriteLine("...Get a life " + p1.name);
                        p1.score += 1;
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("This is getting interesting " + p1.name);
                Console.WriteLine("\t\tCurrent Score: " + p1.score);
                Console.ReadLine();
                Console.Clear();
                ////////////////////////////question 4//////////////////////////////////////////////////////////
                Console.WriteLine("Question 4: What bar did the Dunder Mifflin crew go to the most?");
                Console.WriteLine("\ta.....Chilies");
                Console.WriteLine("\tb.....The Viking");
                Console.WriteLine("\tc.....Poor Richards");
                Console.WriteLine("\td.....The Bar");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a4 = Console.ReadLine();

                while (a4 != "a" & a4 != "b" & a4 != "c" & a4 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a4 = Console.ReadLine();
                }

                switch (a4)
                {
                    case "a":
                        Console.WriteLine("So close...but only featured twice in the show");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("They most often went to Poor Richards");
                        break;
                    case "b":
                        Console.WriteLine("I wish");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("They most often went to Poor Richards");
                        break;
                    case "c":
                        Console.WriteLine("This is getting scary " + p1.name);
                        p1.score += 1;
                        break;
                    case "d":
                        Console.WriteLine("Maybe just give up....");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("They most often went to Poor Richards");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(p1.name + ", you are on fireeeeee!");
                Console.WriteLine("\t\tCurrent Score: " + p1.score);
                Console.ReadLine();
                Console.Clear();
                ////////////////////////////question 5//////////////////////////////////////////////////////////
                Console.WriteLine("Question 5: Who started the fire in the microwave on accident?");
                Console.WriteLine("\ta.....Andy");
                Console.WriteLine("\tb.....Ryan");
                Console.WriteLine("\tc.....Dwight");
                Console.WriteLine("\td.....What fire?");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a5 = Console.ReadLine();

                while (a5 != "a" & a5 != "b" & a5 != "c" & a5 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a5 = Console.ReadLine();
                }

                switch (a5)
                {
                    case "a":
                        Console.WriteLine("The only fire thing about Andy is his accapella");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Ryan started the microwave fire with a cheesy pita");
                        break;
                    case "b":
                        Console.WriteLine("RYAN STARTED THE FIIIIIYYAAAAAA");
                        p1.score += 1;
                        break;
                    case "c":
                        Console.WriteLine("Dwight is the Dunder Mifflin Fire Marshall ya dunce");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Ryan started the microwave fire with a cheesy pita");
                        break;
                    case "d":
                        Console.WriteLine("Did you ever watch the show?????");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Ryan started the microwave fire with a cheesy pita");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Alright " + p1.name + ", you have finsihed the game!");
                Console.WriteLine("\t\tYour final score is: " + p1.score);                                  //single player final score and overall grade
                Console.WriteLine();
                if (p1.score <= 2)
                {
                    Console.WriteLine("Wow.....thats a lowwwww score...maybe study next time.");
                }
                else if (p1.score > 2 && p1.score < 5)
                {
                    Console.WriteLine("Good....not great....but good");
                }
                else
                {
                    Console.WriteLine("Congratulations! A perfect score!!!!");
                }
                Console.ReadLine();
                Console.Clear();
            }
            else if (input == "2")
            {
                Console.WriteLine("Oooooooo a battle royal! \nFor the Challenge you will be given new identities from the cast, be sure to act accordingly.");
                Console.ReadLine();
                Player p1 = new Player();
                p1.name = characters[index]; 
                Player p2 = new Player();
                p2.name = characters[index2];
                while (p2.name == p1.name)
                {
                    p2.name = characters[rand.Next(characters.Length)];
                }
                Console.WriteLine("Player 1, you will be known as " + p1.name);
                Console.WriteLine();
                Console.WriteLine("Player 2, you will be known as " + p2.name);
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Annnnnnnnnd now! A Office Trivia showdown between " + p1.name + " and " + p2.name);
                Console.ReadLine();
                Console.Clear();
                /////////////////////////////////////question 1 player 1//////////////////////////////////////////////////////////            //two player route
                Console.WriteLine(p1.name + "- Question 1: Who was the first VP of Northeast sales in the show?");
                Console.WriteLine("\ta.....Ryan");
                Console.WriteLine("\tb.....Jan");
                Console.WriteLine("\tc.....Michael");
                Console.WriteLine("\td.....Stanley");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a1 = Console.ReadLine();

                while (a1 != "a" & a1 != "b" & a1 != "c" & a1 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a1 = Console.ReadLine();
                }

                switch (a1)
                {
                    case "a":
                        Console.WriteLine("that is not right, ryan was VP of Northeast sales after jan");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Jan was the first VP of Northeast sales in the show.");
                        break;
                    case "b":
                        Console.WriteLine("Wow " + p1.name + "....you're right");
                        p1.score += 1;
                        break;
                    case "c":
                        Console.WriteLine("Michael was never the VP of Northeast sales....genius.");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Jan was the first VP of Northeast sales in the show.");
                        break;
                    case "d":
                        Console.WriteLine("Stanley could've been VP of Northeast sales....but then pretzel day happened....");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Jan was the first VP of Northeast sales in the show.");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\t\t Current Score: " + p1.name + " " + p1.score);
                Console.WriteLine("\t\t Current Score: " + p2.name + " " + p2.score);
                Console.ReadLine();
                Console.Clear();

                /////////////////////////////////////question 1 player 2//////////////////////////////////////////////////////////
                Console.WriteLine(p2.name + "- Question 1: How much is a Shrute Buck worth?");
                Console.WriteLine("\ta.....$1");
                Console.WriteLine("\tb.....1/100th of a cent");
                Console.WriteLine("\tc.....5 cents");
                Console.WriteLine("\td.....$200");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a2 = Console.ReadLine();

                while (a2 != "a" & a2 != "b" & a2 != "c" & a2 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a2 = Console.ReadLine();
                }

                switch (a2)
                {
                    case "a":
                        Console.WriteLine("Come on...its just a piece of paper");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("A Schrute buck is worth 1/100th of a cent");
                        break;
                    case "b":
                        Console.WriteLine("That or 1,000,000,000 Stanley nickles");
                        p2.score += 1;
                        break;
                    case "c":
                        Console.WriteLine("no....just no");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("A Schrute buck is worth 1/100th of a cent");
                        break;
                    case "d":
                        Console.WriteLine("Dwight wishes");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("A Schrute buck is worth 1/100th of a cent");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\t\t Current Score: " + p1.name + " " + p1.score);
                Console.WriteLine("\t\t Current Score: " + p2.name + " " + p2.score);
                Console.ReadLine();
                Console.Clear();

                /////////////////////////////////////question 2 player 1//////////////////////////////////////////////////////////
                Console.WriteLine(p1.name + "- Question 2: What is the name of Jan's candle buisness?");
                Console.WriteLine("\ta.....Wicks of Love");
                Console.WriteLine("\tb.....Scents by Jan");
                Console.WriteLine("\tc.....Jan's Candles");
                Console.WriteLine("\td.....Serenity by Jan");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a3 = Console.ReadLine(); ;

                while (a3 != "a" & a3 != "b" & a3 != "c" & a3 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a3 = Console.ReadLine();
                }

                switch (a3)
                {
                    case "a":
                        Console.WriteLine("Wicks of Love? Absolutely not.");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Jan's buisness was called Serenity by Jan");
                        break;
                    case "b":
                        Console.WriteLine("This answer made no 'scents'.....get it?");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Jan's buisness was called Serenity by Jan");
                        break;
                    case "c":
                        Console.WriteLine("I mean....kinda....they were Jan's candles");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Jan's buisness was called Serenity by Jan");
                        break;
                    case "d":
                        Console.WriteLine("I bet Hunter loved her candle scents");
                        p1.score += 1;
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\t\t Current Score: " + p1.name + " " + p1.score);
                Console.WriteLine("\t\t Current Score: " + p2.name + " " + p2.score);
                Console.ReadLine();
                Console.Clear();

                /////////////////////////////////////question 2 player 2//////////////////////////////////////////////////////////
                Console.WriteLine(p2.name + "- Question 2: Where does Michael go for the most authentic slice of New York pizza");
                Console.WriteLine("\ta.....Times Square");
                Console.WriteLine("\tb.....Sbarros");
                Console.WriteLine("\tc.....A homeless shelter");
                Console.WriteLine("\td.....Pizza by Alfredo");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a4 = Console.ReadLine(); ;

                while (a4 != "a" & a4 != "b" & a4 != "c" & a4 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a4 = Console.ReadLine();
                }

                switch (a4)
                {
                    case "a":
                        Console.WriteLine("Theres no Sbarros in Times Square");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Michael went to Sbarros for the most authentic New York pizza");
                        break;
                    case "b":
                        Console.WriteLine("Much more authenic than Sbarros in Scranton");
                        p2.score += 1;
                        break;
                    case "c":
                        Console.WriteLine("New York authentic, yes. pizza though? no.");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Michael went to Sbarros for the most authentic New York pizza");
                        break;
                    case "d":
                        Console.WriteLine("this is a Scranton only treat");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Michael went to Sbarros for the most authentic New York pizza");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\t\t Current Score: " + p1.name + " " + p1.score);
                Console.WriteLine("\t\t Current Score: " + p2.name + " " + p2.score);
                Console.ReadLine();
                Console.Clear();

                /////////////////////////////////////question 3 player 1//////////////////////////////////////////////////////////
                Console.WriteLine(p1.name + "- Question 3: What was the worst part of prison for Prison Mike");
                Console.WriteLine("\ta.....The Dementors");
                Console.WriteLine("\tb.....The Gruel");
                Console.WriteLine("\tc.....No Crime");
                Console.WriteLine("\td.....Only Vanilla Ice Cream");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a5 = Console.ReadLine(); ;

                while (a5 != "a" & a5 != "b" & a5 != "c" & a5 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a5 = Console.ReadLine();
                }

                switch (a5)
                {
                    case "a":
                        Console.WriteLine("'They were flying all over the place and they were scary'");
                        p1.score += 1;
                        break;
                    case "b":
                        Console.WriteLine("Gruel was all they had to eat, but not the scariest part");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("The worst part of prision, according to Prision Mike, was the dementors");
                        break;
                    case "c":
                        Console.WriteLine("False, although Prison Mike needed the break from crime after all the robbing and stealing he did");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("The worst part of prision, according to Prision Mike, was the dementors");
                        break;
                    case "d":
                        Console.WriteLine("Theres no ice cream in prison!");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("The worst part of prision, according to Prision Mike, was the dementors");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\t\t Current Score: " + p1.name + " " + p1.score);
                Console.WriteLine("\t\t Current Score: " + p2.name + " " + p2.score);
                Console.ReadLine();
                Console.Clear();

                /////////////////////////////////////question 3 player 2//////////////////////////////////////////////////////////
                Console.WriteLine(p2.name + "- Question 3: Where did Toby move to for a few years");
                Console.WriteLine("\ta.....Costa Rica");
                Console.WriteLine("\tb.....Colorado");
                Console.WriteLine("\tc.....Vermont");
                Console.WriteLine("\td.....Mexico");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a6 = Console.ReadLine(); ;

                while (a6 != "a" & a6 != "b" & a6 != "c" & a6 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a6 = Console.ReadLine();
                }

                switch (a6)
                {
                    case "a":
                        Console.WriteLine("And mysteriously moved back right when the Scranton Strangler started attacking...");
                        p2.score += 1;
                        break;
                    case "b":
                        Console.WriteLine("No mountains for Toby");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Toby went to Costa Rica");
                        break;
                    case "c":
                        Console.WriteLine("Maybe he would've moved to Vermont after marrying Pam");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Toby went to Costa Rica");
                        break;
                    case "d":
                        Console.WriteLine("Keep going south and you would've been right");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Toby went to Costa Rica");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\t\t Current Score: " + p1.name + " " + p1.score);
                Console.WriteLine("\t\t Current Score: " + p2.name + " " + p2.score);
                Console.ReadLine();
                Console.Clear();

                /////////////////////////////////////question 4 player 1//////////////////////////////////////////////////////////
                Console.WriteLine(p1.name + "- Question 4: Whos is Pyhllis married to?");
                Console.WriteLine("\ta.....An unnamed, off screen character");
                Console.WriteLine("\tb.....Shes a single lady in town");
                Console.WriteLine("\tc.....Bob Vance");
                Console.WriteLine("\td.....Stanley");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a7 = Console.ReadLine(); ;

                while (a7 != "a" & a7 != "b" & a7 != "c" & a7 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a7 = Console.ReadLine();
                }

                switch (a7)
                {
                    case "a":
                        Console.WriteLine("Big false, he works in the same building");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Phyllis was married to Bob Vance");
                        break;
                    case "b":
                        Console.WriteLine("Early on in the show she was, but then she settles down");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Phyllis was married to Bob Vance");
                        break;
                    case "c":
                        Console.WriteLine("Bob Vance, Vance Refridgeration");
                        p1.score += 1;
                        break;
                    case "d":
                        Console.WriteLine("Stanley is faithful to his wife and his mistress, no time for Phyllis");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Phyllis was married to Bob Vance");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\t\t Current Score: " + p1.name + " " + p1.score);
                Console.WriteLine("\t\t Current Score: " + p2.name + " " + p2.score);
                Console.ReadLine();
                Console.Clear();

                /////////////////////////////////////question 4 player 2//////////////////////////////////////////////////////////
                Console.WriteLine(p2.name + "- Question 4: What company bought out Dunder Mifflin");
                Console.WriteLine("\ta.....Office Depot");
                Console.WriteLine("\tb.....Staples");
                Console.WriteLine("\tc.....Vance Refridgeration");
                Console.WriteLine("\td.....Sabre");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a8 = Console.ReadLine(); ;

                while (a8 != "a" & a8 != "b" & a8 != "c" & a8 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a8 = Console.ReadLine();
                }

                switch (a8)
                {
                    case "a":
                        Console.WriteLine("They only took all of their customers, but not the company");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Dunder Mifflin was bought by Sabre");
                        break;
                    case "b":
                        Console.WriteLine("They took Dwight for a brief period but could never take the Dunder Mifflin name");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Dunder Mifflin was bought by Sabre");
                        break;
                    case "c":
                        Console.WriteLine("Bob Vance would do it just to be closer to Phyllis");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("Dunder Mifflin was bought by Sabre");
                        break;
                    case "d":
                        Console.WriteLine("And gave us the abomination know as....Gabe");
                        p2.score += 1;
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\t\t Current Score: " + p1.name + " " + p1.score);
                Console.WriteLine("\t\t Current Score: " + p2.name + " " + p2.score);
                Console.ReadLine();
                Console.Clear();

                /////////////////////////////////////question 5 player 1//////////////////////////////////////////////////////////
                Console.WriteLine(p1.name + "- Question 5: What is embroidered on the company hats when the branch visits Gettysburg");
                Console.WriteLine("\ta.....Dunderhead");
                Console.WriteLine("\tb.....DM does GB");
                Console.WriteLine("\tc.....DM Tour");
                Console.WriteLine("\td.....Scranton DM");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a9 = Console.ReadLine(); ;

                while (a9 != "a" & a9 != "b" & a9 != "c" & a9 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a9 = Console.ReadLine();
                }

                switch (a9)
                {
                    case "a":
                        Console.WriteLine("You're a dunderhead for thinkning that was right");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("The hats said 'DM does GB'");
                        break;
                    case "b":
                        Console.WriteLine("'and I'm pretty sure DM does GB means something sexual'");
                        p1.score += 1;
                        break;
                    case "c":
                        Console.WriteLine("A bit too obvious to be right");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("The hats said 'DM does GB'");
                        break;
                    case "d":
                        Console.WriteLine("They would've gotten mixed up with the Scranton DnD convention");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("The hats said 'DM does GB'");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\t\t Current Score: " + p1.name + " " + p1.score);
                Console.WriteLine("\t\t Current Score: " + p2.name + " " + p2.score);
                Console.ReadLine();
                Console.Clear();

                /////////////////////////////////////question 5 player 2//////////////////////////////////////////////////////////
                Console.WriteLine(p2.name + "- Question 5: What does Creed grow in his desk drawer");
                Console.WriteLine("\ta.....Mung Beans");
                Console.WriteLine("\tb.....Baby Potatoes");
                Console.WriteLine("\tc.....A Small Mouse");
                Console.WriteLine("\td.....A Petridish of Bacteria");
                Console.WriteLine();
                Console.WriteLine("Input the letter of your choice: ");
                string a10 = Console.ReadLine(); ;

                while (a10 != "a" & a10 != "b" & a10 != "c" & a10 != "d")
                {
                    Console.WriteLine("Answers are case sensitive.....also come on...this shouldn't be so hard...just pick the right one.");
                    a10 = Console.ReadLine();
                }

                switch (a10)
                {
                    case "a":
                        Console.WriteLine("'They smell like death'");
                        p2.score += 1;
                        break;
                    case "b":
                        Console.WriteLine("Not enough space for potatoes");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("The correct answer is Mung Beans.");
                        break;
                    case "c":
                        Console.WriteLine("Any pest in that building is not small");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("The correct answer is Mung Beans.");
                        break;
                    case "d":
                        Console.WriteLine("Creed has better things to do than grow bacteria");
                        Console.WriteLine();
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("The correct answer is Mung Beans.");
                        break;
                }

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("And the winner is.........");
                Console.ReadLine();                                                                 //two player winner and loser area
                if (p1.score > p2.score)
                {
                    Console.WriteLine(p1.name + "! Suck it " + p2.name + "!");
                    Console.WriteLine("Winner: " + p1.score);
                    Console.WriteLine("Loser: " + p2.score);
                }
                else if (p1.score < p2.score)
                {
                    Console.WriteLine(p2.name + "! Suck it " + p1.name + "!");
                    Console.WriteLine("Winner: " + p2.score);
                    Console.WriteLine("Loser: " + p1.score);
                }
                else
                {
                    Console.WriteLine("A tie!?!?!?! Really? A duel to the death it is then.....");
                    Console.WriteLine("Everyone's dumb score: " + p1.score);
                }
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("thank you for playing!");                                        //ending for both playing routes
            Console.ReadLine();
        }
    }
}
