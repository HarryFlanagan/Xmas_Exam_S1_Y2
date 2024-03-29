﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***Author: Harry Flanagan***/
/***Date: 11/12/2019***/

namespace XmasExam_HarryFlanagan
{
    /*Enums*/
    public enum Position
    {
        GoalKeeper,
        Defender,
        Midfielder,
        Forward
    }
   class Player : IComparable<Player>
    {


        /*Properties*/
        public string  FirstName { get; set; }
        public string Surname { get; set; }
        public Position PreferedPosistion { get; set; }
        public  DateTime DateOfBirth { get; set; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                // Calculate the age.
                _age = DateTime.Now.Year - DateOfBirth.Year;         
            }
        }

        /*Constructor*/
        public Player(string firstName, string surname, Position preferedPostion, DateTime dateOfBirth)
        {
            FirstName = firstName;
            Surname = surname;
            PreferedPosistion = preferedPostion;
            DateOfBirth = dateOfBirth;
            Age = _age;
        }
        /*Methods*/
        public override string ToString()
        {

            return $"{FirstName} {Surname} {Age} {PreferedPosistion}";
        }

        //Sorting
        public int CompareTo(Player other)
        {
            int returnValue = this.PreferedPosistion.CompareTo(other.PreferedPosistion); //Compare Prefered Position

            if (returnValue == 0)
            {
                returnValue = this.FirstName.CompareTo(other.FirstName); //Compare First Name after it has compared the Prefered Position
            }

            return returnValue; //Return the value
        }


    }

}
