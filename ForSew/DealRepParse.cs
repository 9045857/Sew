﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSew
{
    public class DealRepParse
    {
        private const string stringDivider = "|";
        private const string boughtType = "Куплены";
        private const string soldType = "Проданы";

        public static Deal ParseCreateDeal(string dealData)
        {
            string dealItem = PickAndCutItem(ref dealData);
            DateTime dealMoment = ParseMoment(dealItem);

            string removingBlock = PickAndCutItem(ref dealData);

            dealItem = PickAndCutItem(ref dealData);
            DealTypes dealType = ParseType(dealItem);

            dealItem = PickAndCutItem(ref dealData);
            float dealAmount = ParseAmount(dealItem);

            return new Deal(dealMoment, dealType, dealAmount);
        }

        private static string PickAndCutItem(ref string dealData)
        {
            int dividerPosition = dealData.IndexOf(stringDivider);

            if (dividerPosition < 0)
            {
                return dealData.Replace(" ", "");
            }

            string pickedData = dealData.Substring(0, dividerPosition);
            pickedData = pickedData.Replace(" ", "");

            dealData = dealData.Substring(dividerPosition + 1);

            return pickedData;
        }

        private static DateTime ParseMoment(string dealMoment)
        {
            //пример входящего формата 2018/01/01/11:06
            int itemsCount = 5;
            string[] momentItems = new string[itemsCount];

            string universalDivider = "/";
            string badDivider = ":";
            dealMoment = dealMoment.Replace(badDivider, universalDivider);

            for (int i = 0; i < itemsCount - 1; i++)
            {
                int dividerPosition = dealMoment.IndexOf(universalDivider);

                string pickedData = dealMoment.Substring(0, dividerPosition);

                dealMoment = dealMoment.Substring(dividerPosition + 1);

                momentItems[i] = pickedData;
            }

            momentItems[itemsCount - 1] = dealMoment;

            int year = Convert.ToInt32(momentItems[0]);
            int month = Convert.ToInt32(momentItems[1]);
            int day = Convert.ToInt32(momentItems[2]);
            int hour = Convert.ToInt32(momentItems[3]);
            int minute = Convert.ToInt32(momentItems[4]);
            int second = 0;

            return new DateTime(year, month, day, hour, minute, second);
        }

        private static DealTypes ParseType(string dealType)
        {
            switch (dealType)
            {
                case boughtType:
                    return DealTypes.Bought;
                case soldType:
                    return DealTypes.Sold;
                default:
                    return DealTypes.None;
            }
        }

        private static float ParseAmount(string dealAmount)
        {
            //TODO добавить региональный вариант, что бы убрать эфект запятой
            return float.Parse(dealAmount);
        }


    }
}
