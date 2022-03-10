using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.PaymentDetails;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            HomePage();

            Console.ReadLine();
        }


        #region User Data
        public static List<Root> UserList(int pageNo)
        {
            List<string> StatusList = new List<string>();
            List<Root> JsonUserList = null;
            try
            {
                WebClient client = new WebClient();
                String JsonText = client.DownloadString(@"https://api-devakademi.sahibinden.com/v1/api/users?pageNo=" + pageNo + "");
                Root JsonUser = JsonConvert.DeserializeObject<Root>(JsonText);
                List<User> JsonUserList1 = JsonUser.data;
                foreach (var item in JsonUserList1)
                {
                    StatusList.Add(item.status);
                    Console.WriteLine("id:" + item.id + "  firstName:" + item.firstName + "  lastName:" + item.lastName + "  status:" + item.status);
                }


            }
            catch (Exception ex)
            {
                JsonUserList = null;
            }
            return JsonUserList;
        }
        #endregion


        #region PaymentData
        public static List<PaymentDetails.Root> PaymentList(int pageNo)
        {
            List<PaymentDetails.Root> JsonPaymentList = null;
            try
            {
                WebClient client = new WebClient();
                String JsonText = client.DownloadString(@"https://api-devakademi.sahibinden.com/v1/api/payment-details?pageNo=" + pageNo + "");
                PaymentDetails.Root JsonPayment = JsonConvert.DeserializeObject<PaymentDetails.Root>(JsonText);
                List<Datum> JsonPaymentList1 = JsonPayment.data;
                foreach (var item in JsonPaymentList1)
                {
                    Console.WriteLine("id:" + item.id + "  classifiedId:" + item.classifiedId + "  createdDate:" + item.createdDate + "  amount: " + item.amount + "  discount:" + item.discount);
                }


            }
            catch (Exception ex)
            {
                JsonPaymentList = null;
            }
            return JsonPaymentList;
        }
        #endregion

        #region ClassifiedsData
        public static List<Classifieds.Root> ClassiFieldList(int pageNo)
        {
            List<string> lst = new List<string>();
            List<Classifieds.Root> JsonDescriptionList = null;
            try
            {
                WebClient client = new WebClient();
                String JsonText = client.DownloadString(@"https://api-devakademi.sahibinden.com/v1/api/classifieds?pageNo=" + pageNo + "");
                Classifieds.Root JsonDescription = JsonConvert.DeserializeObject<Classifieds.Root>(JsonText);
                List<Classifieds.Datum> JsonDescriptionList1 = JsonDescription.data;

                foreach (var item in JsonDescriptionList1)
                {

                    Console.WriteLine("Id: " + item.id + "  UserID: " + item.userId + "  title: " + item.title);
                }

            }
            catch (Exception ex)
            {
                JsonDescriptionList = null;

            }
            return JsonDescriptionList;

        }
        #endregion

        #region LogData
        public static List<Log.Root> LogList(int pageNo)
        {
            List<Log.Root> JsonDescriptionList = null;
            try
            {
                WebClient client = new WebClient();
                String JsonText = client.DownloadString(@"https://api-devakademi.sahibinden.com/v1/api/access-logs?pageNo=" + pageNo + "");
                Log.Root JsonDescription = JsonConvert.DeserializeObject<Log.Root>(JsonText);
                List<Log.Datum> JsonDescriptionList1 = JsonDescription.data;

                foreach (var item in JsonDescriptionList1)
                {

                    Console.WriteLine("id" + item.id + " userID:" + item.userId + " endpoint: " + item.endpoint + " createDate:" + item.createdDate);
                }

            }
            catch (Exception ex)
            {
                JsonDescriptionList = null;

            }
            return JsonDescriptionList;

        }
        #endregion


        #region DataWriter
        public static void DataWriter()
        {
            Console.WriteLine("*****MENU*****");
            Console.WriteLine("1---User List");
            Console.WriteLine("2---Payment Details");
            Console.WriteLine("3---Classifieds List");
            Console.WriteLine("4---Log List");
            Console.WriteLine("Please make a choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter a page number");
                    int useNumber = Convert.ToInt32(Console.ReadLine());
                    UserList(useNumber);
                    break;
                case 2:
                    Console.WriteLine("Please enter a page number");
                    int payNumber = Convert.ToInt32(Console.ReadLine());
                    PaymentList(payNumber);
                    break;
                case 3:
                    Console.WriteLine("Please enter a page number");
                    int classNumber = Convert.ToInt32(Console.ReadLine());
                    ClassiFieldList(classNumber);
                    break;
                case 4:
                    Console.WriteLine("Please enter a page number");
                    int logNumber = Convert.ToInt32(Console.ReadLine());
                    LogList(logNumber);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region statusList
        public static List<Root> StatusList(int pageNo)
        {
            int act = 0, psv = 0;
            List<Root> JsonUserList = null;
            try
            {
                WebClient client = new WebClient();
                String JsonText = client.DownloadString(@"https://api-devakademi.sahibinden.com/v1/api/users?pageNo=" + pageNo + "");
                Root JsonUser = JsonConvert.DeserializeObject<Root>(JsonText);
                List<User> JsonUserList1 = JsonUser.data;
                foreach (var item in JsonUserList1)
                {

                    if (item.status == "ACTIVE")
                    {
                        act++;
                    }
                    else
                    {
                        psv++;
                    }
                }
                Console.WriteLine("Active User:" + act);
                Console.WriteLine("Passive User:" + psv);



            }
            catch (Exception ex)
            {
                JsonUserList = null;
            }
            return JsonUserList;
        }
        #endregion

        #region Home Page
        public static void HomePage()
        {
            Console.WriteLine("*****HOME MENU*****");
            Console.WriteLine("1---FOR DATA");
            Console.WriteLine("2---USER STATUS CONTROL");
            Console.WriteLine("Please make a choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    DataWriter();
                    break;
                case 2:
                    Console.WriteLine("Please enter a page number");
                    int statusNumber = Convert.ToInt32(Console.ReadLine());
                    StatusList(statusNumber);
                    break;

                default:
                    break;
            }
        }
        #endregion
    }
}
