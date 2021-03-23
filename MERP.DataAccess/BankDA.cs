﻿using MERP.Engine.GlobalClass;
using MERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MERP.DataAccess
{
    public class BankDA
    {
        public static string IUD(Bank oBank, EnumDBOperation oDBOperation, string sUserID)
        {
            return GlobalHelpers.ExcecuteQurey("EXEC SP_IUD_Bank",
                oBank.BankID, oBank.BankName, oBank.BankAddress, (int)oBank.IsInActive, oBank.Remarks, (int)oDBOperation, sUserID);
        }
        public static string Gets(string sSQL, string sUserID)
        {
            if (sSQL == "") return "SELECT * FROM GEN.BankInfo";
            else return sSQL;
        }
        public static string Get(int nID, string sUserID)
        {
            return "SELECT * FROM GEN.BankInfo WHERE [BankID] =" + nID;
        }
        public static string Delete(int nBankID, string sUserID)
        {
            //return "DELETE FROM Bank WHERE BankID = " + nBankID;
            return "";
        }
    }
}