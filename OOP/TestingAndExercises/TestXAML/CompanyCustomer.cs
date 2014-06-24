﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourierManager
{
    
    public class CompanyCustomer: Customer
    {
        public CompanyStatute Statute { get; set; }
        public string CompanyName { get; set; }
        public int ClientNumber { get; private set; }
        private List<string> ClientsList { get; set; }
        public CompanyCustomer(string companyName,string address, ulong idNumber, ulong phone) 
            : base(address, idNumber, phone)
        {
            this.Statute = CompanyStatute.New;
            this.CompanyName = companyName;
            this.ClientsList = this.ReadClientData();
            
            if (this.IsANewCustomer == true)
            {
                this.ClientNumber = this.ClientsList.Count;
                this.SaveClientData();
            }
        }
        public override List<string> ReadClientData()
        {
            List<string> companyCustomers = new List<string>();
             
             StreamReader reader = new StreamReader(@"..\..\CompanyCustomers.txt");
             int lineCounter = 1;   //count the number of the lines - this value is the ClientsNumber for every customer
             using (reader)
             {
                 string currentLine = reader.ReadLine();
                 
                 while (currentLine != null)
                 {
                     string[] splitLine = currentLine.Split('*');
                     if (splitLine[3] == this.IDNumber.ToString())
                     {
                         this.IsANewCustomer = false;
                         this.ClientNumber = lineCounter;
                     }
                     companyCustomers.Add(currentLine);
                     currentLine = reader.ReadLine();
                     lineCounter++;
                 }
             }
            return companyCustomers;
        }
        public override void SaveClientData()
        {
            StreamWriter writer = new StreamWriter(@"..\..\CompanyCustomers.txt", true);
            using (writer)
            {
                string currentCompany = String.Format("{0}*{1}*{2}*{3}*{4}*{5}",this.ClientNumber, this.CompanyName, this.Address,
                                this.IDNumber, this.Phone, this.Statute);
                writer.WriteLine(currentCompany); 
            }
        }
    }
}
