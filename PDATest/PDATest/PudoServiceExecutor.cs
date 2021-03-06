﻿using PDATestProject.Models;
using PDATestProject.PDAPudoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public static class PudoServiceExecutor
    {

        private static PdaPudoServiceClient pudoClient = new PdaPudoServiceClient();

        private static DefaultReturnModel initDefaultReturn(DefaultReturnModel returnModel, DefaultModel data, string requestName)
        {
            returnModel.SummaryMessage = "REQUEST: " + requestName + " at " +
                (DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss")) + " completed in ";
            //returnModel.SummaryMessage = "Request:" + Environment.NewLine + requestName + Environment.NewLine;
            returnModel.ParametersPart += data.ToString();
            returnModel.watch = System.Diagnostics.Stopwatch.StartNew();

            return returnModel;
        }

        private static BaseRequest initDefaultParameters(BaseRequest request, DefaultModel data)
        {
            if (data.languageCode != null)
            {
                request.LanguageCode = (LanguageCodeType)Enum.Parse(typeof(LanguageCodeType), data.languageCode);
            }
            if (data.offline != null)
            {
                request.OfflineMode = data.offline.Equals("Igen");
            }
            request.TerminalID = data.terminalId;
            request.EventCreated = data.createDate;

            if (data.transactionId != null)
            {
                request.TransactionID = data.transactionId;
            }
            return request;
        }

        private static DefaultReturnModel createSummaryMessage(DefaultReturnModel data, BaseResponse response)
        {
            data.watch.Stop();

            data.SummaryMessage += data.watch.ElapsedMilliseconds + " ms" + Environment.NewLine;
            data.SummaryMessage += "**********************************************************" + Environment.NewLine;
            data.SummaryMessage += "Result: " + (response.Result ? "SUCCESS " : "FAILED ") + " Error code: " +
                response.ErrorCode + " Error msg:" + response.ErrorMessage + Environment.NewLine;
            data.SummaryMessage += "Results:" + Environment.NewLine + 
                (data.ResultPart.Trim().Equals("") ? "no result or table output" : data.ResultPart) + Environment.NewLine;
            data.SummaryMessage += Environment.NewLine + data.ParametersPart + Environment.NewLine;
            data.SummaryMessage += "**********************************************************" + Environment.NewLine;
            data.SummaryMessage += Environment.NewLine ;

            /*data.SummaryMessage += Environment.NewLine + "EXECUTION:" + (DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss")) +
                Environment.NewLine + "EXECUTION TIME (ms): " + data.watch.ElapsedMilliseconds + Environment.NewLine + 
                "RESULT: " + (response.Result ? "SUCCESS " : "FAILED ") + Environment.NewLine + "ERROR CODE: " +
                response.ErrorCode + Environment.NewLine + "ERROR MESSAGE: " + response.ErrorMessage;*/

            return data;
        }

        internal static DeliveryReturnModel findParcelForDelivery(DeliveryModel deliveryModel)
        {
            try
            {
                DeliveryReturnModel returnModel = (DeliveryReturnModel)initDefaultReturn(
                    new DeliveryReturnModel(), deliveryModel, "findParcelForDelivery");

                FindParcelForDeliveryRequest request = (FindParcelForDeliveryRequest)initDefaultParameters(
                    new FindParcelForDeliveryRequest(), deliveryModel);
                request.Barcode = deliveryModel.packageCode;
                
                FindParcelForDeliveryResponse response = pudoClient.FindParcelForDelivery(request);

                returnModel = (DeliveryReturnModel)createSummaryMessage(returnModel, response);
                if (response.Result)
                {
                    foreach (ParcelMinimal parcelMinimal in response.ParcelMinimals)
                    {
                        DeliveryParcelMinimumReturnModel newItem = new DeliveryParcelMinimumReturnModel();
                        newItem.Barcode = parcelMinimal.Barcode;
                        newItem.Damaged = parcelMinimal.Damaged;
                        newItem.LinkedCount = parcelMinimal.LinkedCount;
                        newItem.NextLinkedBarcode = parcelMinimal.NextLinkedBarcode;
                        newItem.ParcelState = parcelMinimal.ParcelState;
                        newItem.PriceAtDelivery = parcelMinimal.PriceAtDelivery;
                        newItem.ReturnDate = parcelMinimal.ReturnDate;

                        returnModel.datas.Add(newItem);
                    }
                }
                return returnModel;

            }
            catch (Exception e)
            {
                return (DeliveryReturnModel)returnErrorMessage(new DeliveryReturnModel(), e);
            }
        }

        internal static DeliveryReturnModel postCancelDelivery(DeliveryModel deliveryModel)
        {
            try
            {
                DeliveryReturnModel returnModel = (DeliveryReturnModel)initDefaultReturn(
                    new DeliveryReturnModel(), deliveryModel, "postCancelDelivery");

                PostCancelDeliveryRequest request = (PostCancelDeliveryRequest)initDefaultParameters(
                    new PostCancelDeliveryRequest(), deliveryModel);

                List<DeliveryContainer> containers = new List<DeliveryContainer>();
                foreach (DeliveryParcelMinimumReturnModel data in deliveryModel.datas)
                {
                    DeliveryContainer newItem = new DeliveryContainer();
                    newItem.Barcode = data.Barcode;
                    newItem.Damaged = deliveryModel.damaged;
                    containers.Add(newItem);
                }
                request.DeliveryParcels = containers.ToArray();

                PostCancelDeliveryResponse response = pudoClient.PostCancelDelivery(request);

                //create return object with base properties
                if (response.Result)
                {
                    returnModel.ResultPart += parcelResultsToString(response.ParcelResults);
                }
                return (DeliveryReturnModel)createSummaryMessage(returnModel, response);
            }
            catch (Exception e)
            {
                return (DeliveryReturnModel)returnErrorMessage(new DeliveryReturnModel(), e);
            }
        }

        internal static DeliveryReturnModel postRefuseDelivery(DeliveryModel deliveryModel)
        {
            try
            {
                DeliveryReturnModel returnModel = (DeliveryReturnModel)initDefaultReturn(
                    new DeliveryReturnModel(), deliveryModel, "postRefuseDelivery");

                PostRefuseDeliveryRequest request = (PostRefuseDeliveryRequest)initDefaultParameters(
                    new PostRefuseDeliveryRequest(), deliveryModel);

                List<DeliveryContainer> containers = new List<DeliveryContainer>();
                foreach (DeliveryParcelMinimumReturnModel data in deliveryModel.datas)
                {
                    DeliveryContainer newItem = new DeliveryContainer();
                    newItem.Barcode = data.Barcode;
                    newItem.Damaged = deliveryModel.damaged;
                    containers.Add(newItem);
                }
                request.RefuseParcels = containers.ToArray();
                request.IdentificationType = deliveryModel.refuseIdType;
                request.IdentifyDocumentNo = deliveryModel.refuseDocNo;
                request.RefuseReason = deliveryModel.reason;
                request.SignatureData = getTestSigniture();
                           
                PostRefuseDeliveryResponse response = pudoClient.PostRefuseDelivery(request);

                //create return object with base properties
                if (response.Result)
                {
                    returnModel.ResultPart += parcelResultsToString(response.ParcelResults);
                }
                return (DeliveryReturnModel)createSummaryMessage(returnModel, response);
            }
            catch (Exception e)
            {
                return (DeliveryReturnModel)returnErrorMessage(new DeliveryReturnModel(), e);
            }
        }

        private static SignatureData getTestSigniture()
        {
            SignatureData data = new SignatureData();
            data.Filename = "test.txt";
            String str = "test";
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            data.Data = bytes;
            return data;
        }

        internal static DeliveryReturnModel postDelivery(DeliveryModel deliveryModel)
        {
            try
            {
                DeliveryReturnModel returnModel = (DeliveryReturnModel)initDefaultReturn(
                    new DeliveryReturnModel(), deliveryModel, "postDelivery");

                PostDeliveryRequest request = (PostDeliveryRequest)initDefaultParameters(
                    new PostDeliveryRequest(), deliveryModel);

                List<DeliveryContainer> containers = new List<DeliveryContainer>();
                foreach (DeliveryParcelMinimumReturnModel data in deliveryModel.datas)
                {
                    DeliveryContainer newItem = new DeliveryContainer();
                    newItem.Barcode = data.Barcode;
                    newItem.Damaged = deliveryModel.damaged;
                    containers.Add(newItem);
                }
                request.DeliveryParcels = containers.ToArray();
                request.IdentificationType = deliveryModel.refuseIdType;
                request.IdentifyDocumentNo = deliveryModel.refuseDocNo;
                request.PaymentMethod = deliveryModel.reason;
                request.SignatureData = getTestSigniture();

                PostDeliveryResponse response = pudoClient.PostDelivery(request);

                //create return object with base properties
                if (response.Result)
                {
                    returnModel.ResultPart += parcelResultsToString(response.ParcelResults);
                }
                return (DeliveryReturnModel)createSummaryMessage(returnModel, response);
            }
            catch (Exception e)
            {
                return (DeliveryReturnModel)returnErrorMessage(new DeliveryReturnModel(), e);
            }
        }

        internal static DefaultReturnModel getHoliday(HolidayModel holidayModel)
        {
            try
            {
                DefaultReturnModel returnModel = initDefaultReturn(
                    new DefaultReturnModel(), holidayModel, "getHoliday");

                // init request with default parameters
                GetHolidaysRequest request = (GetHolidaysRequest)initDefaultParameters(
                    new GetHolidaysRequest(), holidayModel);

                //execute service call
                GetHolidaysResponse response = pudoClient.GetHolidays(request);

                //initialize custom values 
                if (response.Result)
                {
                    returnModel.ResultPart += holidaysToString(response.Holidays);
                }
                return createSummaryMessage(returnModel, response);
            }
            catch (Exception e)
            {
                return returnErrorMessage(new DefaultReturnModel(), e);
            }
        }

        private static string holidaysToString(Holidays holidays)
        {
            string holidayString = "";
            for (int i = 0; i < holidays.Entries.Length; i++)
            {
                holidayString += Environment.NewLine + "Holiday" + (i + 1) + ": ";
                if (holidays.Entries[0].From != null)
                {
                    holidayString += holidays.Entries[0].From.ToString("yyyy.MM.dd");
                }
                if (holidays.Entries[0].To != null)
                {
                    holidayString += " - " + holidays.Entries[0].To.ToString("yyyy.MM.dd");
                }
            }
            return holidayString;
        }

        internal static DefaultReturnModel setHoliday(HolidayModel holidayModel)
        {
            try
            {
                DefaultReturnModel returnModel = initDefaultReturn(
                    new DefaultReturnModel(), holidayModel, "setHoliday");

                // init request with default parameters
                SetHolidaysRequest request = (SetHolidaysRequest)initDefaultParameters(
                    new SetHolidaysRequest(), holidayModel);

                // add unique parameters
                List<HolidaysEntry> holidayList = new List<HolidaysEntry>();
                if (holidayModel.holiday1From.CompareTo(holidayModel.holiday1To) < 0)
                {
                    HolidaysEntry newEntry = new HolidaysEntry();
                    newEntry.From = holidayModel.holiday1From;
                    newEntry.To = holidayModel.holiday1To;
                    holidayList.Add(newEntry);
                }
                if (holidayModel.holiday2From.CompareTo(holidayModel.holiday2To) < 0)
                {
                    HolidaysEntry newEntry = new HolidaysEntry();
                    newEntry.From = holidayModel.holiday2From;
                    newEntry.To = holidayModel.holiday2To;
                    holidayList.Add(newEntry);
                }
                if (holidayModel.holiday3From.CompareTo(holidayModel.holiday3To) < 0)
                {
                    HolidaysEntry newEntry = new HolidaysEntry();
                    newEntry.From = holidayModel.holiday3From;
                    newEntry.To = holidayModel.holiday3To;
                    holidayList.Add(newEntry);
                }
                if (holidayModel.holiday4From.CompareTo(holidayModel.holiday4To) < 0)
                {
                    HolidaysEntry newEntry = new HolidaysEntry();
                    newEntry.From = holidayModel.holiday4From;
                    newEntry.To = holidayModel.holiday4To;
                    holidayList.Add(newEntry);
                }

                Holidays holidays = new Holidays();

                holidays.Entries = holidayList.ToArray();

                request.Holidays = holidays;
                //execute service call
                SetHolidaysResponse response = pudoClient.SetHolidays(request);

                //create return object with base properties
                returnModel = createSummaryMessage(returnModel, response);

                return returnModel;
            }
            catch (Exception e)
            {
                return (PackageReturnModel)returnErrorMessage(new PackageReturnModel(), e);
            }
        }

        internal static MasterDataReturnModel findInsertedDictionarySince(MasterDataModel masterModelModel)
        {
            try
            {
                MasterDataReturnModel returnModel = (MasterDataReturnModel)initDefaultReturn(
                    new MasterDataReturnModel(), masterModelModel, "findInsertedDictionarySince");

                FindInsertedDictionarySinceRequest request = (FindInsertedDictionarySinceRequest)initDefaultParameters(
                     new FindInsertedDictionarySinceRequest(), masterModelModel);

                request.Since = masterModelModel.date;

                //execute service call
                FindInsertedDictionarySinceResponse response = pudoClient.FindInsertedDictionarySince(request);

                //create return object with base properties
                returnModel = (MasterDataReturnModel)createSummaryMessage(returnModel, response);
                if (response.Result)
                {
                    returnModel.dictionaries.Clear();
                    foreach (Dictionary dictionary in response.Dictionaries)
                    {
                        DictionaryReturnModel newItem = new DictionaryReturnModel();
                        newItem.Description = dictionary.Description;
                        newItem.DictionaryClass = dictionary.DictionaryClass.ToString();
                        newItem.KeyValue = dictionary.KeyValue;
                        returnModel.dictionaries.Add(newItem);

                    }
                }
                return returnModel;
            }
            catch (Exception e)
            {
                return (MasterDataReturnModel)returnErrorMessage(new MasterDataReturnModel(), e);
            }
        }

        internal static MasterDataReturnModel findInsertedPartnerSince(MasterDataModel masterModelModel)
        {
            try
            {
                MasterDataReturnModel returnModel = (MasterDataReturnModel)initDefaultReturn(
                    new MasterDataReturnModel(), masterModelModel, "findInsertedPartnerSince");

                FindUpsertedPartnerSinceRequest request = (FindUpsertedPartnerSinceRequest)initDefaultParameters(
                    new FindUpsertedPartnerSinceRequest(), masterModelModel);

                request.Since = masterModelModel.date;

                //execute service call
                FindUpsertedPartnerSinceResponse response = pudoClient.FindUpsertedPartnerSince(request);

                //create return object with base properties
                returnModel = (MasterDataReturnModel)createSummaryMessage(returnModel, response);
                if (response.Result)
                {
                    returnModel.partners.Clear();
                    foreach (Partner partner in response.Partners)
                    {
                        PartnerReturnModel newItem = new PartnerReturnModel();
                        newItem.PartnerID = partner.PartnerID;
                        newItem.PartnerName = partner.PartnerName;
                        returnModel.partners.Add(newItem);
                    }
                }

                return returnModel;
            }
            catch (Exception e)
            {
                return (MasterDataReturnModel)returnErrorMessage(new MasterDataReturnModel(), e);
            }
        }

        internal static MasterDataReturnModel findInsertedParcelSince(MasterDataModel masterModelModel)
        {
            try
            {
                MasterDataReturnModel returnModel = (MasterDataReturnModel)initDefaultReturn(
                    new MasterDataReturnModel(), masterModelModel, "findInsertedParcelSince");

                FindInsertedParcelSinceRequest request = (FindInsertedParcelSinceRequest)initDefaultParameters(
                    new FindInsertedParcelSinceRequest(), masterModelModel);

                request.Since = masterModelModel.date;

                //execute service call
                FindInsertedParcelSinceResponse response = pudoClient.FindInsertedParcelSince(request);

                //create return object with base properties
                returnModel = (MasterDataReturnModel)createSummaryMessage(returnModel, response);
                if (response.Result)
                {
                    returnModel.parcels.Clear();
                    foreach (Parcel parcel in response.Parcels)
                    {

                        ParcelReturnModel data = new ParcelReturnModel();
                        data.BagBarcode = parcel.BagBarcode;
                        data.Barcode = parcel.Barcode;
                        data.Currency = parcel.Currency;
                        data.CustomerAddress = parcel.CustomerAddress;
                        data.CustomerName = parcel.CustomerName;
                        data.CustomerPostalCode = parcel.CustomerPostalCode;
                        data.Damaged = parcel.Damaged;
                        data.DestinationLocationID = parcel.DestinationLocationID;
                        data.LinkedCount = parcel.LinkedCount;
                        data.LocationID = parcel.LocationID;

                        data.NextLinkedBarcode = parcel.NextLinkedBarcode;
                        data.OldBarcode = parcel.OldBarcode;
                        data.ParcelState = parcel.ParcelState;
                        data.ParcelWorkflow = parcel.ParcelWorkflow;
                        data.PartnerID = parcel.PartnerID;

                        data.PriceAtDelivery = parcel.PriceAtDelivery;
                        data.ReturnDate = parcel.ReturnDate;
                        data.ShipmentID = parcel.ShipmentID;

                        returnModel.parcels.Add(data);
                    }
                }
                return returnModel;
            }
            catch (Exception e)
            {
                return (MasterDataReturnModel)returnErrorMessage(new MasterDataReturnModel(), e);
            }
        }

        internal static MasterDataReturnModel findDeletedDictionarySince(MasterDataModel masterModelModel)
        {
            try
            {
                MasterDataReturnModel returnModel = (MasterDataReturnModel)initDefaultReturn(
                    new MasterDataReturnModel(), masterModelModel, "findDeletedDictionarySince");

                FindDeletedDictionarySinceRequest request = (FindDeletedDictionarySinceRequest)initDefaultParameters(
                    new FindDeletedDictionarySinceRequest(), masterModelModel);

                request.Since = masterModelModel.date;

                //execute service call
                FindDeletedDictionarySinceResponse response = pudoClient.FindDeletedDictionarySince(request);

                //create return object with base properties
                returnModel = (MasterDataReturnModel)createSummaryMessage(returnModel, response);
                if (response.Result)
                {
                    returnModel.dictionaries.Clear();
                    foreach (Dictionary dictionary in response.Dictionaries)
                    {
                        DictionaryReturnModel newItem = new DictionaryReturnModel();
                        newItem.Description = dictionary.Description;
                        newItem.DictionaryClass = dictionary.DictionaryClass.ToString();
                        newItem.KeyValue = dictionary.KeyValue;
                        returnModel.dictionaries.Add(newItem);

                    }
                }

                return returnModel;
            }
            catch (Exception e)
            {
                return (MasterDataReturnModel)returnErrorMessage(new MasterDataReturnModel(), e);
            }
        }

        internal static MasterDataReturnModel findDeletedPartnerSince(MasterDataModel masterModelModel)
        {
            try
            {
                MasterDataReturnModel returnModel = (MasterDataReturnModel)initDefaultReturn(
                    new MasterDataReturnModel(), masterModelModel, "findDeletedPartnerSince");

                FindDeletedPartnerSinceRequest request = (FindDeletedPartnerSinceRequest)initDefaultParameters(
                    new FindDeletedPartnerSinceRequest(), masterModelModel);

                request.Since = masterModelModel.date;

                //execute service call
                FindDeletedPartnerSinceResponse response = pudoClient.FindDeletedPartnerSince(request);

                //create return object with base properties
                returnModel = (MasterDataReturnModel)createSummaryMessage(returnModel, response);
                if (response.Result)
                {
                    returnModel.partners.Clear();
                    foreach (Partner partner in response.Partners)
                    {
                        PartnerReturnModel newItem = new PartnerReturnModel();
                        newItem.PartnerID = partner.PartnerID;
                        newItem.PartnerName = partner.PartnerName;
                        returnModel.partners.Add(newItem);
                    }
                }
                return returnModel;
            }
            catch (Exception e)
            {
                return (MasterDataReturnModel)returnErrorMessage(new MasterDataReturnModel(), e);
            }
        }

        internal static MasterDataReturnModel findDeletedParcelSince(MasterDataModel masterModelModel)
        {
            try
            {
                MasterDataReturnModel returnModel = (MasterDataReturnModel)initDefaultReturn(
                    new MasterDataReturnModel(), masterModelModel, "findDeletedParcelSince");

                FindDeletedParcelSinceRequest request = (FindDeletedParcelSinceRequest)initDefaultParameters(
                  new FindDeletedParcelSinceRequest(), masterModelModel);

                request.Since = masterModelModel.date;

                //execute service call
                FindDeletedParcelSinceResponse response = pudoClient.FindDeletedParcelSince(request);

                //create return object with base properties
                if (response.Result)
                {
                    returnModel.SummaryMessage += Environment.NewLine + "Result list:" + Environment.NewLine;
                    foreach (string barcode in response.BarcodeList)
                    {
                        returnModel.ResultPart += barcode + Environment.NewLine;
                    }
                }

                return (MasterDataReturnModel)createSummaryMessage(returnModel, response);
            }
            catch (Exception e)
            {
                return (MasterDataReturnModel)returnErrorMessage(new MasterDataReturnModel(), e);
            }
        }

        internal static DefaultReturnModel getOpeningHours(OpeningHoursModel openingHoursModel)
        {
            // init request with default parameters
            try
            {
                DefaultReturnModel returnModel = (DefaultReturnModel)initDefaultReturn(
                    new DefaultReturnModel(), openingHoursModel, "getOpeningHours");

                GetOpeningHoursRequest request = (GetOpeningHoursRequest)initDefaultParameters(
                new GetOpeningHoursRequest(), openingHoursModel);

                //execute service call
                GetOpeningHoursResponse response = pudoClient.GetOpeningHours(request);

                //initialize custom values
                if (response.Result)
                {
                    returnModel.ResultPart += openingHoursToString(response.OpeningHours);
                }
                return (DefaultReturnModel)createSummaryMessage(returnModel, response);
            }
            catch (Exception e)
            {
                return returnErrorMessage(new DefaultReturnModel(), e);
            }
        }

        private static string openingHoursToString(OpeningHours openingHours)
        {
            string result = "";
            // Monday to string
            result += openingHoursEntryToString("Monday", openingHours.Monday);
            // Tuesday to string
            result += openingHoursEntryToString("Tuesday", openingHours.Tuesday);
            // Wednesday to string
            result += openingHoursEntryToString("Wednesday", openingHours.Wednesday);
            // Thursday to string
            result += openingHoursEntryToString("Thursday", openingHours.Thursday);
            // Friday to string
            result += openingHoursEntryToString("Friday", openingHours.Friday);
            // Saturday to string
            result += openingHoursEntryToString("Saturday", openingHours.Saturday);
            // Sunday to string
            result += openingHoursEntryToString("Sunday", openingHours.Sunday);

            return result;
        }

        private static string openingHoursEntryToString(String entryName, OpeningHoursEntry openingHoursEntry)
        {
            string result = Environment.NewLine + entryName + ":";
            if (openingHoursEntry.OpeningTimeAM.HasValue)
            {
                result += openingHoursEntry.OpeningTimeAM.Value.ToString();
                if (openingHoursEntry.ClosingTimeAM.HasValue)
                {
                    result += " - " + openingHoursEntry.ClosingTimeAM.Value.ToString();
                }
            }
            if (openingHoursEntry.OpeningTimePM.HasValue)
            {
                result += openingHoursEntry.OpeningTimePM.Value.ToString();
                if (openingHoursEntry.OpeningTimePM.HasValue)
                {
                    result += " - " + openingHoursEntry.OpeningTimePM.Value.ToString();
                }
            }
            return result;
        }

        internal static DefaultReturnModel setOpeningHours(OpeningHoursModel openingHoursModel)
        {
            try
            {
                DefaultReturnModel returnModel = (DefaultReturnModel)initDefaultReturn(
                    new DefaultReturnModel(), openingHoursModel, "setOpeningHours");

                // init request with default parameters
                SetOpeningHoursRequest request = (SetOpeningHoursRequest)initDefaultParameters(
                    new SetOpeningHoursRequest(), openingHoursModel);

                // add unique parameters
                request.OpeningHours = new OpeningHours();
                request.OpeningHours.Monday = parse(openingHoursModel.mondayFirts, openingHoursModel.mondaySecond);
                request.OpeningHours.Tuesday = parse(openingHoursModel.tuesdayFirts, openingHoursModel.tuesdaySecond);
                request.OpeningHours.Wednesday = parse(openingHoursModel.wednesdayFirts, openingHoursModel.wednesdaySecond);
                request.OpeningHours.Thursday = parse(openingHoursModel.thursdayFirts, openingHoursModel.thursdaySecond);
                request.OpeningHours.Friday = parse(openingHoursModel.fridayFirts, openingHoursModel.fridaySecond);
                request.OpeningHours.Saturday = parse(openingHoursModel.saturdayFirts, openingHoursModel.saturdaySecond);
                request.OpeningHours.Sunday = parse(openingHoursModel.sundayFirts, openingHoursModel.sundaySecond);

                //execute service call
                SetOpeningHoursResponse response = pudoClient.SetOpeningHours(request);

                //create return object with base properties
                returnModel = (DefaultReturnModel)createSummaryMessage(returnModel, response);

                return returnModel;
            }
            catch (Exception e)
            {
                return returnErrorMessage(new DefaultReturnModel(), e);
            }
        }

        private static OpeningHoursEntry parse(String amPart, String pmPart)
        {
            OpeningHoursEntry entry = new OpeningHoursEntry();


            string[] pmParts = new string[0];
            string[] amParts = new string[0];

            // default input string example: 06:00 - 11:10
            if (amPart != null)
            {
                amParts = amPart.Split('-');
            }
            // default input string example: 12:00 - 14:24
            if (pmPart != null)
            {
                pmParts = pmPart.Split('-');
            }

            try
            {
                // have elements
                if (amParts.Length > 0)
                {
                    entry.OpeningTimeAM = TimeSpan.Parse(amParts[0].Trim());
                    // have 2 elements
                    if (amParts.Length > 1)
                    {
                        entry.ClosingTimeAM = TimeSpan.Parse(amParts[1].Trim());
                    }
                }
                // have elements
                if (pmParts.Length > 0)
                {
                    entry.OpeningTimePM = TimeSpan.Parse(pmParts[0].Trim());
                    // have 2 elements
                    if (pmParts.Length > 1)
                    {
                        entry.ClosingTimePM = TimeSpan.Parse(pmParts[1].Trim());
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("{0}: Bad Format", amPart);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0}: Overflow", amPart);
            }

            return entry;
        }

        internal static PackageReturnModel findParcelByBarCode(PackageModel packageModel)
        {
            try
            {
                PackageReturnModel returnModel = (PackageReturnModel)initDefaultReturn(
                    new PackageReturnModel(), packageModel, "findParcelByBarCode");

                // init request with default parameters
                FindParcelByBarcodeRequest request = (FindParcelByBarcodeRequest)initDefaultParameters(
                    new FindParcelByBarcodeRequest(), packageModel);
                // add unique parameters
                request.Barcode = packageModel.packageCode == null ? "" : packageModel.packageCode;

                //execute service call
                FindParcelByBarcodeResponse response = pudoClient.FindParcelByBarcode(request);

                //create return object with base properties
                returnModel = (PackageReturnModel)createSummaryMessage(returnModel, response);

                //initialize custom values
                return initPackageReturnParcelComposites(returnModel, response.ParcelComposites);
            }
            catch (Exception e)
            {
                return (PackageReturnModel)returnErrorMessage(new PackageReturnModel(), e);
            }
        }

        internal static PackageReturnModel findParcelByFilter(PackageModel packageModel)
        {

            try
            {
                PackageReturnModel returnModel = (PackageReturnModel)initDefaultReturn(
                    new PackageReturnModel(), packageModel, "findParcelByFilter");

                // init request with default parameters
                FindParcelByFilterRequest request = (FindParcelByFilterRequest)initDefaultParameters(
                    new FindParcelByFilterRequest(), packageModel);

                // add unique parameters
                request.BarcodeFilter = packageModel.filterPackageCode;
                request.CustomerAddressFilter = packageModel.customerAddress;
                request.CustomerNameFilter = packageModel.customerName;
                request.CustomerZipFilter = packageModel.customerZip;

                //execute service call
                FindParcelByFilterResponse response = pudoClient.FindParcelByFilter(request);

                //create return object with base properties
                returnModel = (PackageReturnModel)createSummaryMessage(returnModel, response);

                //initialize custom values
                return initPackageReturnParcelComposites(returnModel, response.ParcelComposites);
            }
            catch (Exception e)
            {
                return (PackageReturnModel)returnErrorMessage(new PackageReturnModel(), e);
            }
        }

        private static DefaultReturnModel returnErrorMessage(DefaultReturnModel returnModel, Exception e)
        {
            returnModel.watch.Stop();
            
            returnModel.SummaryMessage = "ERROR: " + e.Message + Environment.NewLine +
                "EXECUTION TIME (ms):" + returnModel.watch.ElapsedMilliseconds;

            return returnModel;
        }

        private static PackageReturnModel initPackageReturnParcelComposites(PackageReturnModel returnModel, ParcelComposite[] composites)
        {
            if (composites != null)
            {
                foreach (ParcelComposite composite in composites)
                {
                    ParcelCompositeReturnModel data = new ParcelCompositeReturnModel();
                    data.BagBarcode = composite.Parcel.BagBarcode;
                    data.Barcode = composite.Parcel.Barcode;
                    data.Currency = composite.Parcel.Currency;
                    data.CustomerAddress = composite.Parcel.CustomerAddress;
                    data.CustomerName = composite.Parcel.CustomerName;
                    data.CustomerPostalCode = composite.Parcel.CustomerPostalCode;
                    data.Damaged = composite.Parcel.Damaged;
                    data.DestinationLocationID = composite.Parcel.DestinationLocationID;
                    data.LinkedCount = composite.Parcel.LinkedCount;
                    data.LocationID = composite.Parcel.LocationID;
                    data.LocationName = composite.Location.LocationName;
                    data.NextLinkedBarcode = composite.Parcel.NextLinkedBarcode;
                    data.OldBarcode = composite.Parcel.OldBarcode;
                    data.ParcelState = composite.Parcel.ParcelState;
                    data.ParcelWorkflow = composite.Parcel.ParcelWorkflow;
                    data.PartnerID = composite.Parcel.PartnerID;
                    data.PartnerName = composite.Partner.PartnerName;
                    data.PriceAtDelivery = composite.Parcel.PriceAtDelivery;
                    data.ReturnDate = composite.Parcel.ReturnDate;
                    data.ShipmentID = composite.Parcel.ShipmentID;

                    returnModel.datas.Add(data);

                }
            }
            return returnModel;
        }

        internal static PartnersReturnModel findPartnerById(PartnerModel partnerModel)
        {
            try
            {

                PartnersReturnModel returnModel = (PartnersReturnModel)initDefaultReturn(
                    new PartnersReturnModel(), partnerModel, "findPartnerById");

                // init request with default parameters
                FindPartnerByIDRequest request = (FindPartnerByIDRequest)initDefaultParameters(
                    new FindPartnerByIDRequest(), partnerModel);

                // add unique parameters
                request.PartnerID = partnerModel.partnerId == null ? "" : partnerModel.partnerId;

                //execute service call
                FindPartnerByIDResponse response = pudoClient.FindPartnerByID(request);

                //create return object with base properties
                returnModel = (PartnersReturnModel)createSummaryMessage(returnModel, response);
                if (response.Result)
                {
                    if (response.Partner != null)
                    {
                        PartnerReturnModel newItem = new PartnerReturnModel();
                        newItem.PartnerID = response.Partner.PartnerID;
                        newItem.PartnerName = response.Partner.PartnerName;

                        returnModel.partners.Add(newItem);
                    }
                }
                //initialize custom values
                return returnModel;
            }
            catch (Exception e)
            {
                return (PartnersReturnModel)returnErrorMessage(new PartnersReturnModel(), e);
            }
        }

        internal static PartnersReturnModel findPartnerByFilter(PartnerModel partnerModel)
        {
            try
            {
                PartnersReturnModel returnModel = (PartnersReturnModel)initDefaultReturn(
                    new PartnersReturnModel(), partnerModel, "findPartnerByFilter");

                // init request with default parameters
                FindPartnerByFilterRequest request = (FindPartnerByFilterRequest)initDefaultParameters(
                    new FindPartnerByFilterRequest(), partnerModel);

                // add unique parameters
                request.PartnerNameFilter = partnerModel.partnerNamePart == null ? "" : partnerModel.partnerNamePart;

                //execute service call
                FindPartnerByFilterResponse response = pudoClient.FindPartnerByFilter(request);

                //create return object with base properties
                returnModel = (PartnersReturnModel)createSummaryMessage(returnModel, response);

                //initialize custom values
                if (response.Result)
                {
                    foreach (Partner partner in response.Partners)
                    {
                        PartnerReturnModel newItem = new PartnerReturnModel();
                        newItem.PartnerID = partner.PartnerID;
                        newItem.PartnerName = partner.PartnerName;

                        returnModel.partners.Add(newItem);
                    }
                }
                return returnModel;
            }
            catch (Exception e)
            {
                return (PartnersReturnModel)returnErrorMessage(new PartnersReturnModel(), e);
            }
        }

        internal static PartnersReturnModel countPartnerByFilter(PartnerModel partnerModel)
        {
            try
            {

                PartnersReturnModel returnModel = (PartnersReturnModel)initDefaultReturn(
                    new PartnersReturnModel(), partnerModel, "countPartnerByFilter");

                // init request with default parameters
                CountPartnerByFilterRequest request = (CountPartnerByFilterRequest)initDefaultParameters(
                    new CountPartnerByFilterRequest(), partnerModel);

                // add unique parameters
                request.PartnerNameFilter = partnerModel.partnerNamePart;

                //execute service call
                CountPartnerByFilterResponse response = pudoClient.CountPartnerByFilter(request);

                //initialize custom values
                if (response.Result)
                {
                    returnModel.ResultPart += "Result count: " + response.PartnerCount;
                }
                return (PartnersReturnModel)createSummaryMessage(returnModel, response);
            }
            catch (Exception e)
            {
                return (PartnersReturnModel)returnErrorMessage(new PartnersReturnModel(), e);
            }
        }

        internal static ReceiveReturnModel findParcelForReceive(ReceiveModel receiveModel)
        {
            try
            {
                ReceiveReturnModel returnModel = (ReceiveReturnModel)initDefaultReturn(
                    new ReceiveReturnModel(), receiveModel, "findParcelForReceive");

                FindParcelForReceiveRequest request = (FindParcelForReceiveRequest)initDefaultParameters(
                    new FindParcelForReceiveRequest(), receiveModel);
                // add unique parameters
                request.Barcode = receiveModel.barcode;

                //execute service call
                FindParcelForReceiveResponse response = pudoClient.FindParcelForReceive(request);

                //create return object with base properties
                returnModel = (ReceiveReturnModel)createSummaryMessage(returnModel, response);

                //initialize custom values
                return initReceiveReturnParcelComposites(returnModel, response.ParcelComposites);
            }
            catch (Exception e)
            {
                return (ReceiveReturnModel)returnErrorMessage(new ReceiveReturnModel(), e);
            }
        }

        private static ReceiveReturnModel initReceiveReturnParcelComposites(ReceiveReturnModel returnModel, ParcelComposite[] composites)
        {
            if (composites != null)
            {
                foreach (ParcelComposite composite in composites)
                {
                    ParcelCompositeSelectableReturnModel data = new ParcelCompositeSelectableReturnModel();
                    data.BagBarcode = composite.Parcel.BagBarcode;
                    data.Barcode = composite.Parcel.Barcode;
                    data.Currency = composite.Parcel.Currency;
                    data.CustomerAddress = composite.Parcel.CustomerAddress;
                    data.CustomerName = composite.Parcel.CustomerName;
                    data.CustomerPostalCode = composite.Parcel.CustomerPostalCode;
                    data.Damaged = composite.Parcel.Damaged;
                    data.DestinationLocationID = composite.Parcel.DestinationLocationID;
                    data.LinkedCount = composite.Parcel.LinkedCount;
                    data.LocationID = composite.Parcel.LocationID;
                    data.LocationName = composite.Location.LocationName;
                    data.NextLinkedBarcode = composite.Parcel.NextLinkedBarcode;
                    data.OldBarcode = composite.Parcel.OldBarcode;
                    data.ParcelState = composite.Parcel.ParcelState;
                    data.ParcelWorkflow = composite.Parcel.ParcelWorkflow;
                    data.PartnerID = composite.Parcel.PartnerID;
                    data.PartnerName = composite.Partner.PartnerName;
                    data.PriceAtDelivery = composite.Parcel.PriceAtDelivery;
                    data.ReturnDate = composite.Parcel.ReturnDate;
                    data.ShipmentID = composite.Parcel.ShipmentID;
                    data.Selected = false;

                    returnModel.datas.Add(data);

                }
            }
            return returnModel;
        }

        internal static ReceiveReturnModel postReceive(ReceiveModel receiveModel)
        {
            try
            {
                ReceiveReturnModel returnModel = (ReceiveReturnModel)initDefaultReturn(
                    new ReceiveReturnModel(), receiveModel, "postReceive");

                PostReceiveRequest request = (PostReceiveRequest)initDefaultParameters(
                    new PostReceiveRequest(), receiveModel);

                // add unique parameters
                List<ReceptionContainer> receptionContainers = new List<ReceptionContainer>();
                List<DiscrepancyContainer> discrepancyContainer = new List<DiscrepancyContainer>();
                foreach (ParcelCompositeSelectableReturnModel data in receiveModel.gridModel)
                {
                    if (data.Selected)
                    {
                        ReceptionContainer newItem = new ReceptionContainer();
                        newItem.Barcode = data.Barcode;
                        newItem.Damaged = data.Damaged;
                        receptionContainers.Add(newItem);
                    }
                    else
                    {
                        DiscrepancyContainer newItem = new DiscrepancyContainer();
                        newItem.Barcode = data.Barcode;
                        // TODO lehet, hogy ezt a táblából kellene beletenni
                        newItem.Discrepancy = DiscrepancyType.Shortage;
                        discrepancyContainer.Add(newItem);
                    }
                }

                request.DiscrepancyParcels = discrepancyContainer.ToArray();
                request.ReceptionParcels = receptionContainers.ToArray();

                //execute service call
                PostReceiveResponse response = pudoClient.PostReceive(request);

                if (response.Result)
                {
                    returnModel.ResultPart += parcelResultsToString(response.ParcelResults);
                }
                return (ReceiveReturnModel)createSummaryMessage(returnModel, response);
            }
            catch (Exception e)
            {
                return (ReceiveReturnModel)returnErrorMessage(new ReceiveReturnModel(), e);
            }
        }

        private static string parcelResultsToString(ParcelResult[] results)
        {
            string resultString = "";
            //string resultString = Environment.NewLine + "Parcel Results:" + Environment.NewLine;
            foreach (ParcelResult result in results)
            {
                resultString += result.Barcode + " - " + result.ActualStatus + Environment.NewLine;
            }

            return resultString;

        }

        internal static ReturnReturnModel findParcelForReturn(ReturnModel returnedModel)
        {
            try
            {
                ReturnReturnModel returnModel = (ReturnReturnModel)initDefaultReturn(
                    new ReturnReturnModel(), returnedModel, "findParcelForReturn");

                FindParcelForReturnRequest request = (FindParcelForReturnRequest)initDefaultParameters(
                    new FindParcelForReturnRequest(), returnedModel);

                //execute service call
                FindParcelForReturnResponse response = pudoClient.FindParcelForReturn(request);

                //create return object with base properties
                returnModel = (ReturnReturnModel)createSummaryMessage(returnModel, response);
                if (response.Result)
                {
                    foreach (ParcelMinimal parcel in response.ParcelMinimals)
                    {
                        ReturnParcelReturnModel newItem = new ReturnParcelReturnModel();
                        newItem.Barcode = parcel.Barcode;
                        newItem.Damaged = parcel.Damaged;
                        newItem.LinkedCount = parcel.LinkedCount;
                        newItem.NextLinkedBarcode = parcel.NextLinkedBarcode;
                        newItem.ParcelState = parcel.ParcelState;
                        newItem.PriceAtDelivery = parcel.PriceAtDelivery;
                        newItem.ReturnDate = parcel.ReturnDate;
                        newItem.Selected = false;

                        returnModel.data.Add(newItem);
                    }
                }

                return returnModel;
            }
            catch (Exception e)
            {
                return (ReturnReturnModel)returnErrorMessage(new ReturnReturnModel(), e);
            }
        }

        internal static ReturnReturnModel postReturn(ReturnModel returnedModel)
        {
            try
            {
                ReturnReturnModel returnModel = (ReturnReturnModel)initDefaultReturn(
                    new ReturnReturnModel(), returnedModel, "postReturn");

                PostReturnRequest request = (PostReturnRequest)initDefaultParameters(
                  new PostReturnRequest(), returnedModel);

                List<ReturnContainer> container = new List<ReturnContainer>();
                List<PostingContainer> sortage = new List<PostingContainer>();

                foreach (ReturnParcelReturnModel parcel in returnedModel.data)
                {
                    if (parcel.Selected)
                    {
                        ReturnContainer returnContainer = new ReturnContainer();
                        returnContainer.BagBarcode = returnedModel.bagBarcode;
                        returnContainer.Barcode = parcel.Barcode;
                        container.Add(returnContainer);
                    }
                    else
                    {
                        PostingContainer postringContainer = new PostingContainer();
                        postringContainer.Barcode = parcel.Barcode;
                        sortage.Add(postringContainer);
                    }
                }
                request.ReturnParcels = container.ToArray();
                request.ShortageParcels = sortage.ToArray();

                //execute service call
                PostReturnResponse response = pudoClient.PostReturn(request);

                //create return object with base properties
                returnModel = (ReturnReturnModel)createSummaryMessage(returnModel, response);

                return returnModel;
            }
            catch (Exception e)
            {
                return (ReturnReturnModel)returnErrorMessage(new ReturnReturnModel(), e);
            }
        }

        // TODO még ne töröld
        internal static ReturnPreRegReturnModel findParcelForDelivery(ReturnPreRegModel returnPreRegModel)
        {
            try
            {
                FindParcelForDeliveryRequest request = (FindParcelForDeliveryRequest)initDefaultParameters(
              new FindParcelForDeliveryRequest(), returnPreRegModel);
                // add unique parameters
                request.Barcode = returnPreRegModel.packageCode;

                //execute service call
                FindParcelForDeliveryResponse response = pudoClient.FindParcelForDelivery(request);

                //create return object with base properties
                ReturnPreRegReturnModel returnModel = (ReturnPreRegReturnModel)createSummaryMessage(
                    initDefaultReturn(new ReturnPreRegReturnModel(), returnPreRegModel, "findParcelForDelivery"), response);
                if (response.Result)
                {
                    //initialize custom values
                    foreach (ParcelMinimal minimal in response.ParcelMinimals)
                    {
                        ParcelMinimalReturnModel newItem = new ParcelMinimalReturnModel();
                        newItem.Barcode = minimal.Barcode;
                        newItem.Damaged = minimal.Damaged;
                        newItem.LinkedCount = minimal.LinkedCount;
                        newItem.NextLinkedBarcode = minimal.NextLinkedBarcode;
                        newItem.ParcelState = minimal.ParcelState;
                        newItem.PriceAtDelivery = minimal.PriceAtDelivery;
                        newItem.ReturnDate = minimal.ReturnDate;

                        // returnModel.data.Add(newItem);
                    }
                }

                return returnModel;
            }
            catch (Exception e)
            {
                return (ReturnPreRegReturnModel)returnErrorMessage(new ReturnPreRegReturnModel(), e);
            }
        }

        internal static ReturnPreRegReturnModel postRefuseCustRetPrereg(ReturnPreRegModel returnPreRegModel)
        {
            try
            {
                ReturnPreRegReturnModel returnModel = (ReturnPreRegReturnModel)
                    initDefaultReturn(new ReturnPreRegReturnModel(), returnPreRegModel, "postRefuseCustRetPrereg");

                PostRefuseCustomerReturnPreRegisteredRequest request = (PostRefuseCustomerReturnPreRegisteredRequest)initDefaultParameters(
                    new PostRefuseCustomerReturnPreRegisteredRequest(), returnPreRegModel);
                // add unique parameters

                // set first selected to refused
                foreach (ParcelCompositeReturnModel parcelMinimal in returnPreRegModel.data)
                {
                    RefuseCustomerReturnPreRegisteredContainer container = new RefuseCustomerReturnPreRegisteredContainer();
                    container.Barcode = parcelMinimal.Barcode;
                    container.Damaged = returnPreRegModel.damaged;
                    request.RefuseCustomerReturnParcel = container;
                    break;
                }
                request.RefuseReason = returnPreRegModel.refuseReason;

                //execute service call
                PostRefuseCustomerReturnPreRegisteredResponse response = pudoClient.PostRefuseCustomerReturnPreRegistered(request);

                //create return object with base properties
                returnModel = (ReturnPreRegReturnModel)createSummaryMessage(returnModel, response);

                //initialize custom values
                if (response.Result)
                {
                    returnModel.SummaryMessage += Environment.NewLine + "Parcel result: " +
                        response.ParcelResult.Barcode + " : " + response.ParcelResult.ActualStatus;
                }
                return returnModel;
            }
            catch (Exception e)
            {
                return (ReturnPreRegReturnModel)returnErrorMessage(new ReturnPreRegReturnModel(), e);
            }
        }

        internal static ReturnPreRegReturnModel postCustRetPrereg(ReturnPreRegModel returnPreRegModel)
        {
            try
            {
                ReturnPreRegReturnModel returnModel = (ReturnPreRegReturnModel)initDefaultReturn(
                    new ReturnPreRegReturnModel(), returnPreRegModel, "PostCustomerReturnPreRegistered");

                PostCustomerReturnPreRegisteredRequest request = (PostCustomerReturnPreRegisteredRequest)initDefaultParameters(
                    new PostCustomerReturnPreRegisteredRequest(), returnPreRegModel);
                // add unique parameters

                // set first selected to refused
                foreach (ParcelCompositeReturnModel parcelMinimal in returnPreRegModel.data)
                {
                    CustomerReturnPreRegisteredContainer container = new CustomerReturnPreRegisteredContainer();
                    container.Barcode = parcelMinimal.Barcode;
                    container.Damaged = returnPreRegModel.damaged;
                    request.CustomerReturnParcel = container;
                    break;
                }

                //execute service call
                PostCustomerReturnPreRegisteredResponse response = pudoClient.PostCustomerReturnPreRegistered(request);
              
                //initialize custom values
                if (response.Result)
                {
                    returnModel.ResultPart +=  "Parcel result: "
                        + response.ParcelResult.Barcode + " : " + response.ParcelResult.ActualStatus;
                }
                return  (ReturnPreRegReturnModel)createSummaryMessage(returnModel, response);
            }
            catch (Exception e)
            {
                return (ReturnPreRegReturnModel)returnErrorMessage(new ReturnPreRegReturnModel(), e);
            }
        }

        internal static ReturnPreRegReturnModel postCustRetUnexpected(ReturnPreRegModel returnPreRegModel)
        {
            try
            {
                ReturnPreRegReturnModel returnModel = (ReturnPreRegReturnModel)initDefaultReturn(
                    new ReturnPreRegReturnModel(), returnPreRegModel, "postCustRetUnexpected");

                PostCustomerReturnUnexpectedRequest request = (PostCustomerReturnUnexpectedRequest)initDefaultParameters(
                new PostCustomerReturnUnexpectedRequest(), returnPreRegModel);
                // add unique parameters

                // set first selected to refused
                foreach (ParcelCompositeReturnModel parcelMinimal in returnPreRegModel.data)
                {
                    CustomerReturnUnexpectedContainer container = new CustomerReturnUnexpectedContainer();
                    container.Barcode = parcelMinimal.Barcode;
                    container.Damaged = returnPreRegModel.damaged;
                    container.CustomerName = returnPreRegModel.customerName;
                    container.NoLabel = returnPreRegModel.noLabel;
                    container.OldBarcode = parcelMinimal.Barcode;
                    container.PartnerID = returnPreRegModel.partnerId;

                    request.CustomerReturnParcel = container;
                    break;
                }

                //execute service call
                PostCustomerReturnUnexpectedResponse response = pudoClient.PostCustomerReturnUnexpected(request);

                //initialize custom values
                if (response.Result)
                {
                    returnModel.ResultPart += "Parcel result: " +
                        response.ParcelResult.Barcode + " : " + response.ParcelResult.ActualStatus;
                }
                return (ReturnPreRegReturnModel)createSummaryMessage(returnModel, response);
            }
            catch (Exception e)
            {
                return (ReturnPreRegReturnModel)returnErrorMessage(new ReturnPreRegReturnModel(), e);
            }
        }

        internal static ReturnPreRegReturnModel findParcelForCustRetPreReg(ReturnPreRegModel returnPreRegModel)
        {
            try
            {
                ReturnPreRegReturnModel returnModel = (ReturnPreRegReturnModel)initDefaultReturn(
                    new ReturnPreRegReturnModel(), returnPreRegModel, "FindParcelForCustomerReturnPreRegistered");

                FindParcelForCustomerReturnPreRegisteredRequest request = (FindParcelForCustomerReturnPreRegisteredRequest)initDefaultParameters(
                    new FindParcelForCustomerReturnPreRegisteredRequest(), returnPreRegModel);
                // add unique parameters
                request.Barcode = returnPreRegModel.packageCode;

                //execute service call
                FindParcelForCustomerReturnPreRegisteredResponse response = pudoClient.FindParcelForCustomerReturnPreRegistered(request);

                //create return object with base properties
                returnModel = (ReturnPreRegReturnModel)createSummaryMessage(returnModel, response);
                if (response.Result)
                {
                    ParcelComposite composite = response.ParcelComposite;
                    ParcelCompositeReturnModel data = new ParcelCompositeReturnModel();

                    data.BagBarcode = composite.Parcel.BagBarcode;
                    data.Barcode = composite.Parcel.Barcode;
                    data.Currency = composite.Parcel.Currency;
                    data.CustomerAddress = composite.Parcel.CustomerAddress;
                    data.CustomerName = composite.Parcel.CustomerName;
                    data.CustomerPostalCode = composite.Parcel.CustomerPostalCode;
                    data.Damaged = composite.Parcel.Damaged;
                    data.DestinationLocationID = composite.Parcel.DestinationLocationID;
                    data.LinkedCount = composite.Parcel.LinkedCount;
                    data.LocationID = composite.Parcel.LocationID;
                    data.LocationName = composite.Location.LocationName;
                    data.NextLinkedBarcode = composite.Parcel.NextLinkedBarcode;
                    data.OldBarcode = composite.Parcel.OldBarcode;
                    data.ParcelState = composite.Parcel.ParcelState;
                    data.ParcelWorkflow = composite.Parcel.ParcelWorkflow;
                    data.PartnerID = composite.Parcel.PartnerID;
                    data.PartnerName = composite.Partner.PartnerName;
                    data.PriceAtDelivery = composite.Parcel.PriceAtDelivery;
                    data.ReturnDate = composite.Parcel.ReturnDate;
                    data.ShipmentID = composite.Parcel.ShipmentID;

                    returnModel.data.Add(data);

                }

                return returnModel;
            }
            catch (Exception e)
            {
                return (ReturnPreRegReturnModel)returnErrorMessage(new ReturnPreRegReturnModel(), e);
            }
        }
    }
}
