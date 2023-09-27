public class Breakout
{
    //A, A + B, A + B + C...
    //
    //On the {A} day of christmas, my true love gave to me {B}
    //A + B
    //[B]
    //
    //
    //We need a class to hold A and B and relate the two somehow
    //We Need to store all of our classes of A and B
    //We Need to iterate through them according to the rules

    List<Pair> pairs = new List<Pair>(){
        new Pair("first", "a partidge in a pear tree"),
        new Pair("second", "two turtle doves"),
        new Pair("third", "three French hens"),
        new Pair("fourth", "Four calling birds"),
        new Pair("fifth", "five golden rings"),
        new Pair("sixth", "six geese a laying"),
        new Pair("seventh", "seven swans a swimming"),
        new Pair("eighth", "eight maids a milking"),
        new Pair("ninth", "nine ladies dancing"),
        new Pair("tenth", "ten lords a leaping"),
        new Pair("eleventh", "eleven pipers piping"),
        new Pair("twelfth", "twelve drummers drumming")
    };


    string[] days = new string[] {
        "first",
        "second",
        "third",
        "fourth",
        "fifth",
        "sixth",
        "seventh",
        "eighth",
        "ninth",
        "tenth",
        "eleventh",
        "twelfth"
    };

    string [] phrases = new string[] {
       "a partidge in a pear tree",
       "two turtle doves",
       "three French hens",
       "Four calling birds",
       "five golden rings",
       "six geese a laying",
       "seven swans a swimming",
       "eight maids a milking",
       "nine ladies dancing",
       "ten lords a leaping",
       "eleven pipers piping",
       "twelve drummers drumming"
    };


    public void Run()
    {

    }


    public void Run2()
    {
        for(int i = 0; i < days.Length; i++)
        {
            string result = FormatPhrase(days[i], phrases[i]);
            //Concat the repeating portion
            result += FormatRepeat(i, phrases);
            Console.WriteLine(result);
        }
    }

    private static string FormatPhrase(string day, string phrase)
    {
        return $"On the {day} day of Christmas my true love gave to me {phrase}";
    }

    private static string FormatRepeat(int idx, string[] phrases)
    {
        //If we are at the first element, there are no repeating phrases
        if(idx == 0)
        {
            return string.Empty;
        }
        //Initialize return value;
        string returnVal = string.Empty;
        //Reverse through array of phrases from idx
        for(int i = GetPrevious(idx); i >= 0; i--)
        {
            //concat to the final string
            returnVal += GetSeperator(i) + phrases[i];
        }
        return returnVal;
    }

    private static int GetPrevious(int idx)
    {
        //Since we dont want to print our initial phrase twice we have
        //to get the previous value
        return idx -= 1;
    }

    private static string GetSeperator(int idx)
    {
        //We have variable seperator
        //if we are on the last element we seperate with and
        //for everything else its a comma
        //oxford comma be damned
        if(idx == 0)
        {
            return " and ";
        }
        return ", ";
    }
}

public class Pair
{
    public Pair(string day, string gift)
    {
        Day = day;
        Gift = gift;
    }
    public string Day { get; set; }
    public string Gift { get; set; }
}
