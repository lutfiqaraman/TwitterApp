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
            var CONSUMER_KEY = "your CONSUMER_KEY is here";
            var CONSUMER_SECRET = "your CONSUMER_SECRET is here";
            var ACCESS_TOKEN = "your ACCESS_TOKEN is here";
            var ACCESS_TOKEN_SECRET = "your ACCESS_TOKEN_SECRET is here";

            Auth.SetUserCredentials(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
            var AuthenticatedUser = User.GetAuthenticatedUser();

            if (AuthenticatedUser == null)
            {
                var latestException = ExceptionHandler.GetLastException();
                Console.WriteLine("Error occured : {0} ", latestException.TwitterDescription);
            }
            else
            {
                Console.WriteLine("Please write your tweet:");
                string tweetBody = Console.ReadLine();

                if (tweetBody.Length <= 140)
                {
                    Tweet.PublishTweet(tweetBody);
                    Console.WriteLine("Published successfully");
                }
                else
                {
                    Console.WriteLine("Faild to publish, your tweet is more than 140 characters");
                }
            }

            Console.ReadKey();

        }
    }
}
