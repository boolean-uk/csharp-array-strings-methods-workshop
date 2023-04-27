
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace methodsstringsarrays.console
{
    /// <summary>
    /// This is a person class.  
    /// </summary>
    public class Person
    {
        private int _age;
        private Motorbike _myBike;
        private DateTime _dateIBoughtABike;
        private void HeartBeats()
        {
            Console.WriteLine("Heart is beating!");
        }
        
        
        public void WakesUp()
        {
            int x = 1;
            HeartBeats();
            Console.WriteLine("Waking up now");

        }
        public void InitializeMyAge()
        {
            _age = 30;
        }
        public int AgeNextYear()
        {
            return ++_age;
        }

        /// <summary>
        /// method to add on a number of years
        /// </summary>
        /// <param name="anyNumberOfYears">number of years to add on to persons age</param>
        /// <returns>int of age after number of years added on</returns>
        public int ageInHowManyYears(int anyNumberOfYears)
        {
            _age = _age + anyNumberOfYears;

            return _age;
        }

        public Motorbike doesSomething()
        {
            return _myBike;
        }

        public void JustBoughtAMotorbike(Motorbike bikeJustBought)
        {
            DateTime today = DateTime.Now;

            _dateIBoughtABike = today;
            _myBike = bikeJustBought;
        }
        public string WhatBikeHaveIJustBought()
        {

            return _myBike.Name;
        }

        /// <summary>
        /// this method will determine whether person is tall
        /// </summary>
        /// <returns>bool whether person is tall</returns>
        public bool IsTall()
        {
            //  test ? iftrue : iffalse 
            return _age > 60 ? false : true;
        }

        //line comment

        /*
         multiline comment
        */


        public string Name { get; set; }
        public int Age { get => _age; set => _age = value; }


        public Motorbike MyBike { get => _myBike; set => _myBike = value; }


    }
}
