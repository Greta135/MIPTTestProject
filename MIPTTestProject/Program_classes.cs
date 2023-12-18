using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace MIPTTestProject
{
    internal class Program

    {
        static void Main(string[] args)
        {
            PrivilegeMaster master = new PrivilegeMaster();
            Customer customer = new Customer();
            Seller seller = new Seller();

            
        }
    }
    class User
    {
        private string Autorization
        { 
            get 
            {
                return Autorization;
            }
            set
            {
                Autorization = value;
            }
        }
        public string Order;
        public void DeleteOrder(int id)
        {
            Console.WriteLine("delete order by id");
        }
        public void CreateOrder(string newValue)
        {
            Console.WriteLine("create new order");
        }
        public void SendOrder(string newValue)
        {
            Console.WriteLine("SendOrder is Successed");
        }
        
    }
    class Customer : User
    {
    }
    class Admin : User
    {
    }
    class Seller : User
    {
    }
    class PrivilegeMaster
    {
        public string Privilege
        {
            get { return Privilege; }
        }

    }
}﻿
