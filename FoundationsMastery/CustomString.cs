using FoundationsMastery.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery 
{
    public class CustomString : ICustomString
    {
        public CustomString(IEnumerable<char> contents)
        {
            this.Contents = contents; //set the value of the contents property from what is passed in the constructor
        }

        public CustomString()//this is a constructor
        {
            this.Contents = new List<char>();
        }

        public IEnumerable<char> Contents { get; set; } //this will have value from the constructor
       
        //public CustomString(char[] x) //not currently using this 
        //{
            
        //}

        public int Length //get the length of the contents ienumerable
        {
            get
            {
              return Contents.Count();
            }
        }

        public void Clear() //clear means the this.Contents should be empty
        {
            Contents = new List<char>(); //Ienumerables are interfaces and cannot be instatiated - here you are setting this to list so it will work
            Contents.ToList().Clear();// Ienumerable doesnt have a definition for .Clear() need to conver to list
        }
        
        //rhs
        public string Concat(IEnumerable<char> rhs) // concat = adding two Ienumerables into one string
        {
            string concats = "";
            foreach (char a in Contents) //contents is a property of this class
            {
                concats += a; //left hand side
            }
            foreach (char a in rhs) 
            {
                concats += a; //right hand side
            }
            return concats;
        }

        public string Interleave(IEnumerable<char> rhs) //USE A FOR LOOP!!!!
        {
            //ternary operator : (bool) ? what the value is if it's true : what the value is if its false
            var length = (rhs.Count() > Contents.Count()) ? Contents.Count() : rhs.Count();
            var conList = Contents.ToList();
            var rhsList = rhs.ToList();
            var zipper = "";

            for (var i = 0; i < length; i++)
            {
                zipper += conList[i];
                zipper += rhsList[i];
            }
            return zipper;
        }

        public string Print() //print to console and return a string
        {
            string print = "";
            foreach (char a in this.Contents)
            {
                print += a; //this is looping over whatever you pass in
            }
            Console.WriteLine(print);
            return print;
        }
    }
}
