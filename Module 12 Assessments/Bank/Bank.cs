﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Bank
    {
        public List<Account> Accounts { get; set; }
        public Bank()
        {
            Accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public void ListAccounts()
        {
            foreach (Account account in Accounts)
            {
                Console.WriteLine(account);
            }
        }
    }
}
