using PDATestProject.Datas;
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

        private static BaseRequest initDefaultParameters(BaseRequest request, DefaultData data){
            request.LanguageCode = (LanguageCodeType) Enum.Parse(typeof(LanguageCodeType), data.languageCode);
            request.OfflineMode = data.offline.Equals("Igen");
            request.TerminalID = data.terminalId;
            request.TransactionID = Convert.ToInt64(data.transactionId);
            return request;
        }

        private static DefaultReturnData createSummaryMessage(DefaultReturnData data, BaseResponse response)
        {
            data.summaryMessage = "RESULT: " + (response.Result ? "SUCCESS " : "FAILED ") + " - ERROR CODE: " + 
                response.ErrorCode + " - ERROR MESSAGE: " + response.ErrorMessage ; 

            return data;
        }

        internal static void findParcelForDelivery(DeliveryData deliveryData)
        {
            FindParcelForDeliveryRequest request = (FindParcelForDeliveryRequest)initDefaultParameters(
                new FindParcelForDeliveryRequest(), deliveryData);
            request.Barcode = deliveryData.packageCode;

            FindParcelForDeliveryResponse response = pudoClient.FindParcelForDelivery(request);
            
        }

        internal static void postCancelDelivery(DeliveryData deliveryData)
        {
            PostCancelDeliveryRequest request = (PostCancelDeliveryRequest)initDefaultParameters(
                new PostCancelDeliveryRequest(), deliveryData);
            //TODO kitölteni a megfelelő értékekkel 
            //request.DeliveryParcels = deliveryData.packageCode;

            PostCancelDeliveryResponse response = pudoClient.PostCancelDelivery(request);
        }

        internal static void postRefuseDelivery(DeliveryData deliveryData)
        {
            throw new NotImplementedException();
        }

        internal static void postDelivery(DeliveryData deliveryData)
        {
            throw new NotImplementedException();
        }

        internal static DefaultReturnData getHoliday(HolidayData holidayData)
        {
            // init request with default parameters
            GetHolidaysRequest request = (GetHolidaysRequest)initDefaultParameters(
                new GetHolidaysRequest(), holidayData);

            //execute service call
            GetHolidaysResponse response = pudoClient.GetHolidays(request);

            //create return object with base properties
            DefaultReturnData returnData = createSummaryMessage(new DefaultReturnData(), response);

            //initialize custom values 
            returnData.summaryMessage += holidaysToString(response.Holidays);
            return returnData;
        }

        private static string holidaysToString(Holidays holidays)
        {
            string holidayString = "\n";
            for (int i = 0; i <= holidays.Entries.Length; i++)
            {
                holidayString += "Holiday" + (i + 1) + ": ";
                if (holidays.Entries[0].From != null) { 
                    holidayString += holidays.Entries[0].From.ToString("yyyy.MM.dd");
                }
                if (holidays.Entries[0].To != null) {
                    holidayString += " - " + holidays.Entries[0].To.ToString("yyyy.MM.dd");
                }
            }
            return holidayString;
        }

        internal static DefaultReturnData setHoliday(HolidayData holidayData)
        {
            // init request with default parameters
            SetHolidaysRequest request = (SetHolidaysRequest)initDefaultParameters(
                new SetHolidaysRequest(), holidayData);

            // add unique parameters
            List<HolidaysEntry> holidayList = new List<HolidaysEntry>();
            if (holidayData.holiday1From.CompareTo(holidayData.holiday1To) < 0){
                HolidaysEntry newEntry = new HolidaysEntry();
                newEntry.From = holidayData.holiday1From;
                newEntry.To =  holidayData.holiday1To;
                holidayList.Add(newEntry);
            }
            if (holidayData.holiday2From.CompareTo(holidayData.holiday2To) < 0)
            {
                HolidaysEntry newEntry = new HolidaysEntry();
                newEntry.From = holidayData.holiday2From;
                newEntry.To = holidayData.holiday2To;
                holidayList.Add(newEntry);
            }
            if (holidayData.holiday3From.CompareTo(holidayData.holiday3To) < 0)
            {
                HolidaysEntry newEntry = new HolidaysEntry();
                newEntry.From = holidayData.holiday3From;
                newEntry.To = holidayData.holiday3To;
                holidayList.Add(newEntry);
            }
            if (holidayData.holiday4From.CompareTo(holidayData.holiday4To) < 0)
            {
                HolidaysEntry newEntry = new HolidaysEntry();
                newEntry.From = holidayData.holiday4From;
                newEntry.To = holidayData.holiday4To;
                holidayList.Add(newEntry);
            }

            request.Holidays.Entries = holidayList.ToArray();

            //execute service call
            SetHolidaysResponse response = pudoClient.SetHolidays(request);

            //create return object with base properties
            DefaultReturnData returnData = createSummaryMessage(new DefaultReturnData(), response);

            return returnData;
        }

        internal static void findInsertedDictionarySince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static void findInsertedPartnerSince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static void findInsertedParcelSince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static void findDeletedDictionarySince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static void findDeletedPartnerSince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static void findDeletedParcelSince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static DefaultReturnData getOpeningHours(OpeningHoursData openingHoursData)
        {
            // init request with default parameters
            GetOpeningHoursRequest request = (GetOpeningHoursRequest)initDefaultParameters(
                new GetOpeningHoursRequest(), openingHoursData);
           
            //execute service call
            GetOpeningHoursResponse response = pudoClient.GetOpeningHours(request);

            //create return object with base properties
            DefaultReturnData returnData = (DefaultReturnData) createSummaryMessage(new DefaultReturnData(), response);

            //initialize custom values
            returnData.summaryMessage += openingHoursToString(response.OpeningHours);
            return returnData;
        }

        private static string openingHoursToString(OpeningHours openingHours) {
            string result = "\n";
            // Monday to string
            result += openingHoursEntryToString("Monday",openingHours.Monday);
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
            string result = "\n" + entryName + ":";
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

        internal static DefaultReturnData setOpeningHours(OpeningHoursData openingHoursData)
        {
            // init request with default parameters
            SetOpeningHoursRequest request = (SetOpeningHoursRequest)initDefaultParameters(
                new SetOpeningHoursRequest(), openingHoursData);

            // add unique parameters
            request.OpeningHours.Monday = parse(openingHoursData.mondayFirts, openingHoursData.mondaySecond);
            request.OpeningHours.Tuesday = parse(openingHoursData.tuesdayFirts, openingHoursData.tuesdaySecond);
            request.OpeningHours.Wednesday = parse(openingHoursData.wednesdayFirts, openingHoursData.wednesdaySecond);
            request.OpeningHours.Thursday = parse(openingHoursData.thursdayFirts, openingHoursData.thursdaySecond);
            request.OpeningHours.Friday = parse(openingHoursData.fridayFirts, openingHoursData.fridaySecond);
            request.OpeningHours.Saturday = parse(openingHoursData.saturdayFirts, openingHoursData.saturdaySecond);
            request.OpeningHours.Sunday = parse(openingHoursData.sundayFirts, openingHoursData.sundaySecond);

            //execute service call
            SetOpeningHoursResponse response = pudoClient.SetOpeningHours(request);

            //create return object with base properties
            DefaultReturnData returnData = (DefaultReturnData) createSummaryMessage(new DefaultReturnData(), response);

            return returnData;
        }

        private static OpeningHoursEntry parse(String amPart, String pmPart)
        {
            OpeningHoursEntry entry = new OpeningHoursEntry();
            
            // default input string example: 06:00 - 11:10
            string[] amParts = amPart.Split('-');
            // default input string example: 12:00 - 14:24
            string[] pmParts = pmPart.Split('-');
           
            try {
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
                        entry.ClosingTimeAM = TimeSpan.Parse(pmParts[1].Trim());
                    }
                }
            }
            catch (FormatException) {
               Console.WriteLine("{0}: Bad Format", amPart);
            }   
            catch (OverflowException) {
               Console.WriteLine("{0}: Overflow", amPart);
            }

            return entry;
        }

        internal static PackageReturnData findParcelByBarCode(PackageData packageData)
        {
            // init request with default parameters
            FindParcelByBarcodeRequest request = (FindParcelByBarcodeRequest) initDefaultParameters(
                new FindParcelByBarcodeRequest(), packageData);
            // add unique parameters
            request.Barcode = packageData.packageCode;

            //execute service call
            FindParcelByBarcodeResponse response = pudoClient.FindParcelByBarcode(request);

            //create return object with base properties
            PackageReturnData returnData = (PackageReturnData) createSummaryMessage( new PackageReturnData(), response);

            //initialize custom values
            return initPackageReturnParcelComposites(returnData, response.ParcelComposites);
        }

        internal static PackageReturnData findParcelByFilter(PackageData packageData)
        {
            // init request with default parameters
            FindParcelByFilterRequest request = (FindParcelByFilterRequest)initDefaultParameters(
                new FindParcelByFilterRequest(), packageData);
            
            // add unique parameters
            request.BarcodeFilter = packageData.filterPackageCode;
            request.CustomerAddressFilter = packageData.customerAddress;
            request.CustomerNameFilter = packageData.customerName;
            request.CustomerZipFilter = packageData.customerZip;

            //execute service call
            FindParcelByFilterResponse response = pudoClient.FindParcelByFilter(request);

            //create return object with base properties
            PackageReturnData returnData = (PackageReturnData) createSummaryMessage(new PackageReturnData(), response);

            //initialize custom values
            return initPackageReturnParcelComposites(returnData, response.ParcelComposites);
        }

        private static PackageReturnData initPackageReturnParcelComposites(PackageReturnData returnData, ParcelComposite[] composites)
        {
            foreach (ParcelComposite composite in composites)
            {
                ParcelCompositeReturnData data = new ParcelCompositeReturnData();
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

                returnData.datas.Add(data);

            }
            return returnData;
        }

        internal static void findPartnerById(PartnerData partnerData)
        {
            throw new NotImplementedException();
        }

        internal static void findPartnerByFilter(PartnerData partnerData)
        {
            throw new NotImplementedException();
        }

        internal static void countPartnerByFilter(PartnerData partnerData)
        {
            throw new NotImplementedException();
        }

        internal static void findParcelForReceive(ReceiveData receiveData)
        {
            throw new NotImplementedException();
        }

        internal static void postReceive(ReceiveData receiveData)
        {
            throw new NotImplementedException();
        }

        internal static void findParcelForReturn(ReturnData returnData)
        {
            throw new NotImplementedException();
        }

        internal static void postReturn(ReturnData returnData)
        {
            throw new NotImplementedException();
        }

        internal static void findParcelForDelivery(ReturnPreRegData returnPreRegData)
        {
            throw new NotImplementedException();
        }

        internal static void postRefuseCustRetPrereg(ReturnPreRegData returnPreRegData)
        {
            throw new NotImplementedException();
        }

        internal static void postCustRetPrereg(ReturnPreRegData returnPreRegData)
        {
            throw new NotImplementedException();
        }

        internal static void postCustRetUnexpected(ReturnPreRegData returnPreRegData)
        {
            throw new NotImplementedException();
        }
    }
}
