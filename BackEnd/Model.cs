﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectContainerDLL;

namespace Backend
{
    /**
     * Enteprise logic class
     * On create: create new DB manager (cascading creation)
     */
    class Model
    {
        //Declarations
        private Hotel hotel;

        //Creator
        public Model()
        {
            //hotel = new Hotel("Magic", "Solheimsviken 5"); // TODO matcher dette med DB? Hva med DB Lasting?
        }

        //TODO functions
        //TODO Conect to DB
        public bool MakeReservation(int roomNumber, DateTime from, DateTime to, string fName, string lName)
        {   
            return false;
        }
        public List<Booking> GetBookings(DateTime from = DateTime.now, DateTime to = DateTime.now)
        {
            return null;
        }

        public List<Booking> GetBookings(int roomNumer)
        {
            return null;
        }

        public List<Booking> GetBookings(string romType)
        {
            return null;
        }

        public List<Room> GetAvailibleRooms(DateTime from = DateTime.now, DateTime to = DateTime.now)
        {
            return null;
        }

        public List<Room> GetAvailibleRooms(string type, DateTime from = DateTime.now, DateTime to = DateTime.now)
        {
            return null;
        }

        public List<Room> GetAllRooms(string type, DateTime from = DateTime.now, DateTime to = DateTime.now)
        {
            return null;
        }

        public List<Room> getOccupiedRooms(DateTime from = DateTime.now, DateTime to = DateTime.now)
        {
            return null;
        }

        public List<Room> getOccupiedRooms(string Type, DateTime from = DateTime.now, DateTime to = DateTime.now)
        {
            return null;
        }


        /*
         * Ideas for functions:
         * "makeBooking" takes in info (subs to event from views) from views (web + desktop), sends it to Model for use
         * "checkIn" and "checkOut" 
         * "deleteBooking"
         * "searchBooking" takes info from event, sends info to model, model returns list, send event with list
         * "viewBooking" get info from app, search model, return object
         * "raiseIssue" subs to even from desktop and app
         * "payment"
         *  
         */
    }
}
