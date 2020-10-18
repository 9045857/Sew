using System;

namespace ForSew
{
    public class DealRepParse : ParseLog
    {
        public event AccountWarnings Notify;

        private const string stringDivider = "|";
        private const string boughtType = "Куплены";
        private const string soldType = "Проданы";

        public Deal ParseCreateDeal(string dealData)
        {
            string dealLine = dealData;

            string dealItem = PickAndCutItem(ref dealLine);
            DateTime dealMoment = new DateTime();
            if (!TryParseMoment(dealItem, ref dealMoment))
            {
                Notify?.Invoke(string.Format(Warnings.DealDateTimeDontParsed, dealItem));
                return null;
            }

            string removingBlock = PickAndCutItem(ref dealLine);

            dealItem = PickAndCutItem(ref dealLine);
            DealTypes dealType = new DealTypes();
            if (!TryParseType(dealItem, ref dealType))
            {
                Notify?.Invoke(string.Format(Warnings.DealTypeDontParsed, dealItem));
                return null;
            }

            dealItem = PickAndCutItem(ref dealLine);
            float dealAmount = 0;
            if (!TryParseAmount(dealItem, ref dealAmount))
            {
                Notify?.Invoke(string.Format(Warnings.DealAmontDontParsed, dealItem));
                return null;
            }

            return new Deal(dealMoment, dealType, dealAmount);
        }

        private string PickAndCutItem(ref string dealData)
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

        private bool TryParseMoment(string dealMoment, ref DateTime dateTime)
        {
            try
            {
                //пример входящего формата 2018/01/01/11:06
                int itemsCount = 5;
                string[] momentItems = new string[itemsCount];

                string universalDivider = "/";
                string badDivider = ":";
                string moment = dealMoment.Replace(badDivider, universalDivider);

                for (int i = 0; i < itemsCount - 1; i++)
                {
                    int dividerPosition = moment.IndexOf(universalDivider);
                    string pickedData = moment.Substring(0, dividerPosition);

                    moment = moment.Substring(dividerPosition + 1);

                    momentItems[i] = pickedData;
                }

                momentItems[itemsCount - 1] = moment;

                if (!int.TryParse(momentItems[0], out int year))
                {
                    return false;
                }
                if (!int.TryParse(momentItems[1], out int month))
                {
                    return false;
                }
                if (!int.TryParse(momentItems[2], out int day))
                {
                    return false;
                }
                if (!int.TryParse(momentItems[3], out int hour))
                {
                    return false;
                }
                if (!int.TryParse(momentItems[4], out int minute))
                {
                    return false;
                }
                int second = 0;

                dateTime = new DateTime(year, month, day, hour, minute, second);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool TryParseType(string dealTypeItem, ref DealTypes dealType)
        {
            switch (dealTypeItem)
            {
                case boughtType:
                    dealType = DealTypes.Bought;
                    return true;
                case soldType:
                    dealType = DealTypes.Sold;
                    return true;
                default:
                    dealType = DealTypes.None;
                    return false;
            }
        }

        private bool TryParseAmount(string dealAmountItem, ref float dealAmount)
        {
            //TODO добавить региональный вариант, что бы убрать эфект запятой
            try
            {
                dealAmount = Convert.ToSingle(dealAmountItem);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
