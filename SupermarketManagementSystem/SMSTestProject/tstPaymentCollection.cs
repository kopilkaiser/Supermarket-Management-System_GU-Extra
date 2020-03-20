using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SMSTestProject
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void ThisPaymentsPropertyOK()
        {
            //create the instance of the class we want to create 
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to teh property
            clsPayment TestPayment = new clsPayment();
            //set the properties of the test object
            TestPayment.PaymentId = 1;
            TestPayment.PayeeName = "Kopil Kaiser";
            TestPayment.Method = "Visa Debit";
            TestPayment.CardNumber = 9999999999999999.ToString();
            TestPayment.Amount = 200m;
            TestPayment.PaymentDate = DateTime.Now.Date;

            //assign the data to the proper
            AllPayments.ThisPayment = TestPayment;
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //careate an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create the payment of test data
            clsPayment TestPayment = new clsPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestPayment.PaymentId = 1;
            TestPayment.PayeeName = "Kopil Kaiser";
            TestPayment.Method = "Visa Debit";
            TestPayment.CardNumber = 1234567891012345.ToString();
            TestPayment.Amount = 200m;
            TestPayment.PaymentDate = DateTime.Now.Date;
            //set ThisPayment to the test data
            AllPayments.ThisPayment = TestPayment;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the promary key of the test data
            TestPayment.PaymentId = PrimaryKey;
            //find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the sane
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPayment TestPayment = new clsPayment();
            Int32 PrimaryKey = 0;
            //set the properties
            TestPayment.PaymentId = 1;
            TestPayment.PayeeName = "Kopil Kaiser";
            TestPayment.Method = "Visa Debit";
            TestPayment.CardNumber = "9999999999999999";
            TestPayment.Amount = 250.00m;
            TestPayment.PaymentDate = DateTime.Now.Date;
            AllPayments.ThisPayment = TestPayment;
            PrimaryKey = AllPayments.Add();
            TestPayment.PaymentId = PrimaryKey;
            //Find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            //Delete Record
            AllPayments.Delete();
            //test to see that the two values are the same
            Boolean Found = AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the same#
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of thge class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPayment TestPayment = new clsPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestPayment.PaymentId = 1;
            TestPayment.PayeeName = "Kopil Kaiser";
            TestPayment.Method = "Dabit Visa";
            TestPayment.CardNumber = 9999999999999999.ToString();
            TestPayment.Amount = 250.00m;
            TestPayment.PaymentDate = DateTime.Now.Date;
            //set ThisAddress to the test data
            AllPayments.ThisPayment = TestPayment;
            //add the record
            PrimaryKey = AllPayments.Add();
            //modify the test data
            TestPayment.PayeeName = "Mr.Kopil Kaiser";
            TestPayment.Method = "Dabit Visa";
            TestPayment.CardNumber = "9999999999999991";
            TestPayment.Amount = 25000.00m;
            TestPayment.PaymentDate = DateTime.Now.Date;
            //set the record based on the new test data
            AllPayments.ThisPayment = TestPayment;
            //update the record
            AllPayments.Update();
            //find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see this Payment matches with test data
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);

        }

        [TestMethod]
        public void ReportByMethodNoneFound()
        {
            clsPaymentCollection FillterPayments = new clsPaymentCollection();
            FillterPayments.ReportByMethod("MasterCard");
            Assert.AreNotEqual(0, FillterPayments.Count);
        }
    }
}
