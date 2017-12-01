using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace TwitterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var CONSUMER_KEY = "type your CONSUMER_KEY here";
            var CONSUMER_SECRET = "type your CONSUMER_SECRET here";
            var ACCESS_TOKEN = "type your ACCESS_TOKEN here";
            var ACCESS_TOKEN_SECRET = "type your ACCESS_TOKEN_SECRET here";

            Auth.SetUserCredentials(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
            var user = User.GetAuthenticatedUser();

            Console.WriteLine("Please write your tweet");
            string tweetBody = Console.ReadLine();

            if (tweetBody.Length <= 140)
                Tweet.PublishTweet(tweetBody);
            else
                Console.WriteLine("Faild to publish, your tweet is more than 140 characters");

            Console.ReadKey();

        }
    }
}
