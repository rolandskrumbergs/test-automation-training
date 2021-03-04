using System;
using System.Collections.Generic;
using TestAutomationTraining.Models;

namespace TestAutomationTraining.Business
{
    public static class OrderValidator
    {
        public static List<string> GetValidationErrors(Order order)
        {
            var resultList = new List<string>();

            var booksInvalid = false;
            if (order.AmountOfBooks < 0 || order.AmountOfBooks > 100)
            {
                booksInvalid = true;
                resultList.Add("Grāmatu daudzumam jābūt starp 0 un 100.");
            }

            var dvdsInvalid = false;
            if (order.AmountOfDvds < 0 || order.AmountOfDvds > 200)
            {
                dvdsInvalid = true;
                resultList.Add("DVD daudzumam jābūt starp 0 un 200.");
            }

            var shirtInvalid = false;
            if (order.AmountOfShirts < 0 || order.AmountOfShirts > 200)
            {
                shirtInvalid = true;
                resultList.Add("Kreklu daudzumam jābūt starp 0 un 200.");
            }

            if (booksInvalid && dvdsInvalid && shirtInvalid)
            {
                resultList.Add("Nepieciešams valids grāmatu, DVD un kreklu daudzums.");
            }

            if (string.IsNullOrEmpty(order.CustomerName))
            {
                resultList.Add("Klienta vārds ir obligāts.");
            }
            else
            {
                if (order.CustomerName.Length < 5 && order.CustomerName.Length > 20)
                {
                    resultList.Add("Klienta vārds ir jābūt 5-20 simbolu garumā.");
                }
            }

            if (!string.IsNullOrEmpty(order.Phone))
            {
                if (order.Phone.Length < 5 && order.Phone.Length > 15)
                {
                    resultList.Add("Klienta tālrunim ir jābūt 5-15 simbolu garumā.");
                }
            }

            if (!string.IsNullOrEmpty(order.Email))
            {
                if (order.Email.Length < 10 && order.Email.Length > 30)
                {
                    resultList.Add("Klienta epastam ir jābūt 10-30 simbolu garumā.");
                }
            }

            if (string.IsNullOrEmpty(order.Email) && string.IsNullOrEmpty(order.Phone))
            {
                resultList.Add("E-pasts vai tālrunis ir obligāts.");
            }

            if (order.IsCompany)
            {
                if (string.IsNullOrEmpty(order.Address))
                {
                    resultList.Add("Juridiskām personām adrese obligāta!");
                }

                if (string.IsNullOrEmpty(order.RegistrationNumber))
                {
                    resultList.Add("Juridiskām personām reģ.nr. obligāts!");
                }
            }

            if (!string.IsNullOrEmpty(order.Address))
            {
                if (order.Address.Length < 20 && order.Address.Length > 100)
                {
                    resultList.Add("Uzņēmuma adresei ir jābūt 20-100 simbolu garumā.");
                }
            }

            if (!string.IsNullOrEmpty(order.RegistrationNumber))
            {
                if (order.RegistrationNumber.Length != 11)
                {
                    resultList.Add("Uzņēmuma reģistrācijas numuram ir jābūt 11 simbolu garumā.");
                }
            }

            if (!string.IsNullOrEmpty(order.PVNRegistrationNumber))
            {
                if (order.PVNRegistrationNumber.Length != 13)
                {
                    resultList.Add("Uzņēmuma PVN reģistrācijas numuram ir jābūt 13 simbolu garumā.");
                }
            }

            if (string.IsNullOrEmpty(order.DeliveryAddress))
            {
                resultList.Add("Piegādes adrese ir obligāta.");
            }
            else
            {
                if (order.DeliveryAddress.Length < 20 && order.DeliveryAddress.Length > 100)
                {
                    resultList.Add("Piegādes adresei ir jābūt 20-100 simbolu garumā.");
                }
            }

            if (!string.IsNullOrEmpty(order.DeliveryDetails))
            {
                if (order.DeliveryDetails.Length > 2000)
                {
                    resultList.Add("Piegādes detaļām ir jābūt max 2000 simbolu garumā.");
                }
            }

            if (order.DeliveryDateTime != default)
            {
                if (order.DeliveryDateTime < DateTime.Now)
                {
                    resultList.Add("Piegādes datumam ir jābūt nākotnē.");
                }
            }

            return resultList;
        }
    }
}
