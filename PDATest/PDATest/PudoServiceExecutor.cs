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

        internal static DeliveryReturnData findParcelForDelivery(DeliveryData deliveryData)
        {
            FindParcelForDeliveryRequest request = (FindParcelForDeliveryRequest)initDefaultParameters(
                new FindParcelForDeliveryRequest(), deliveryData);
            request.Barcode = deliveryData.packageCode;

            FindParcelForDeliveryResponse response = pudoClient.FindParcelForDelivery(request);

            DeliveryReturnData returnData = (DeliveryReturnData)createSummaryMessage(new DeliveryReturnData(), response);

            foreach (ParcelMinimal parcelMinimal in response.ParcelMinimals)
            {
                DeliveryParleccMinimumReturnData newItem = new DeliveryParleccMinimumReturnData();
                newItem.Barcode = parcelMinimal.Barcode;
                newItem.Damaged = parcelMinimal.Damaged;
                newItem.LinkedCount = parcelMinimal.LinkedCount;
                newItem.NextLinkedBarcode = parcelMinimal.NextLinkedBarcode;
                newItem.ParcelState = parcelMinimal.ParcelState;
                newItem.PriceAtDelivery = parcelMinimal.PriceAtDelivery;
                newItem.ReturnDate = parcelMinimal.ReturnDate;

                returnData.datas.Add(newItem);
            }
            return returnData;
        }

        internal static DeliveryReturnData postCancelDelivery(DeliveryData deliveryData)
        {
            PostCancelDeliveryRequest request = (PostCancelDeliveryRequest)initDefaultParameters(
                new PostCancelDeliveryRequest(), deliveryData);
            
            List<DeliveryContainer> containers = new List<DeliveryContainer>();
            foreach (DeliveryParleccMinimumReturnData data in deliveryData.datas){
                DeliveryContainer newItem = new DeliveryContainer();
                newItem.Barcode = data.Barcode;
                newItem.Damaged = deliveryData.damaged;
                containers.Add(newItem);
            }
            request.DeliveryParcels = containers.ToArray();
            
            PostCancelDeliveryResponse response = pudoClient.PostCancelDelivery(request);

            //create return object with base properties
            DeliveryReturnData returnData = (DeliveryReturnData)createSummaryMessage(new DeliveryReturnData(), response);

            returnData.summaryMessage += parcelResultsToString(response.ParcelResults);

            return returnData;
        }

        internal static DeliveryReturnData postRefuseDelivery(DeliveryData deliveryData)
        {
            PostRefuseDeliveryRequest request = (PostRefuseDeliveryRequest)initDefaultParameters(
              new PostRefuseDeliveryRequest(), deliveryData);

            List<DeliveryContainer> containers = new List<DeliveryContainer>();
            foreach (DeliveryParleccMinimumReturnData data in deliveryData.datas)
            {
                DeliveryContainer newItem = new DeliveryContainer();
                newItem.Barcode = data.Barcode;
                newItem.Damaged = deliveryData.damaged;
                containers.Add(newItem);
            }
            request.RefuseParcels = containers.ToArray();
            request.IdentificationType = deliveryData.refuseIdType;
            request.IdentifyDocumentNo = deliveryData.refuseDocNo;
            request.RefuseReason = deliveryData.reason;
            //TODO signaturedata

            PostRefuseDeliveryResponse response = pudoClient.PostRefuseDelivery(request);

            //create return object with base properties
            DeliveryReturnData returnData = (DeliveryReturnData)createSummaryMessage(new DeliveryReturnData(), response);

            returnData.summaryMessage += parcelResultsToString(response.ParcelResults);

            return returnData;
        }

        internal static DeliveryReturnData postDelivery(DeliveryData deliveryData)
        {
            PostDeliveryRequest request = (PostDeliveryRequest)initDefaultParameters(
             new PostDeliveryRequest(), deliveryData);

            List<DeliveryContainer> containers = new List<DeliveryContainer>();
            foreach (DeliveryParleccMinimumReturnData data in deliveryData.datas)
            {
                DeliveryContainer newItem = new DeliveryContainer();
                newItem.Barcode = data.Barcode;
                newItem.Damaged = deliveryData.damaged;
                containers.Add(newItem);
            }
            request.DeliveryParcels = containers.ToArray();
            request.IdentificationType = deliveryData.refuseIdType;
            request.IdentifyDocumentNo = deliveryData.refuseDocNo;
            request.PaymentMethod = deliveryData.reason;
            //TODO signaturedata

            PostDeliveryResponse response = pudoClient.PostDelivery(request);

            //create return object with base properties
            DeliveryReturnData returnData = (DeliveryReturnData)createSummaryMessage(new DeliveryReturnData(), response);

            returnData.summaryMessage += parcelResultsToString(response.ParcelResults);

            return returnData;
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

        internal static MasterDataReturnData findInsertedDictionarySince(MasterDataData masterDataData)
        {
            FindInsertedDictionarySinceRequest request = (FindInsertedDictionarySinceRequest)initDefaultParameters(
                 new FindInsertedDictionarySinceRequest(), masterDataData);

            request.Since = masterDataData.date;

            //execute service call
            FindInsertedDictionarySinceResponse response = pudoClient.FindInsertedDictionarySince(request);

            //create return object with base properties
            MasterDataReturnData returnData = (MasterDataReturnData) createSummaryMessage(new MasterDataReturnData(), response);

            returnData.dictionaries.Clear();
            foreach (Dictionary dictionary in response.Dictionaries)
            {
                DictionaryReturnData newItem = new DictionaryReturnData();
                newItem.Description = dictionary.Description;
                newItem.DictionaryClass = dictionary.DictionaryClass.ToString();
                newItem.KeyValue = dictionary.KeyValue;
                returnData.dictionaries.Add(newItem);

            }

            return returnData;
        }

        internal static MasterDataReturnData findInsertedPartnerSince(MasterDataData masterDataData)
        {
            //TODO ez tényleg nincs implementálva
            throw new NotImplementedException();
        }

        internal static MasterDataReturnData findInsertedParcelSince(MasterDataData masterDataData)
        {
            FindInsertedParcelSinceRequest request = (FindInsertedParcelSinceRequest)initDefaultParameters(
                 new FindInsertedParcelSinceRequest(), masterDataData);

            request.Since = masterDataData.date;

            //execute service call
            FindInsertedParcelSinceResponse response = pudoClient.FindInsertedParcelSince(request);

            //create return object with base properties
            MasterDataReturnData returnData = (MasterDataReturnData)createSummaryMessage(new MasterDataReturnData(), response);

            returnData.parcels.Clear();
            foreach (Parcel parcel in response.Parcels)
            {
                
                ParcelReturnData data = new ParcelReturnData();
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

                returnData.parcels.Add(data);
            }

            return returnData;
        }

        internal static MasterDataReturnData findDeletedDictionarySince(MasterDataData masterDataData)
        {
            FindDeletedDictionarySinceRequest request = (FindDeletedDictionarySinceRequest)initDefaultParameters(
                new FindDeletedDictionarySinceRequest(), masterDataData);

            request.Since = masterDataData.date;

            //execute service call
            FindDeletedDictionarySinceResponse response = pudoClient.FindDeletedDictionarySince(request);

            //create return object with base properties
            MasterDataReturnData returnData = (MasterDataReturnData)createSummaryMessage(new MasterDataReturnData(), response);

            returnData.dictionaries.Clear();
            foreach (Dictionary dictionary in response.Dictionaries)
            {
                DictionaryReturnData newItem = new DictionaryReturnData();
                newItem.Description = dictionary.Description;
                newItem.DictionaryClass = dictionary.DictionaryClass.ToString();
                newItem.KeyValue = dictionary.KeyValue;
                returnData.dictionaries.Add(newItem);

            }

            return returnData;
        }

        internal static MasterDataReturnData findDeletedPartnerSince(MasterDataData masterDataData)
        {
            FindDeletedPartnerSinceRequest request = (FindDeletedPartnerSinceRequest)initDefaultParameters(
                new FindDeletedPartnerSinceRequest(), masterDataData);

            request.Since = masterDataData.date;

            //execute service call
            FindDeletedPartnerSinceResponse response = pudoClient.FindDeletedPartnerSince(request);

            //create return object with base properties
            MasterDataReturnData returnData = (MasterDataReturnData)createSummaryMessage(new MasterDataReturnData(), response);

            returnData.partners.Clear();
            foreach (Partner partner in response.Partners)
            {
                PartnerReturnData newItem = new PartnerReturnData();
                newItem.PartnerID = partner.PartnerID;
                newItem.PartnerName = partner.PartnerName;
                returnData.partners.Add(newItem);
            }

            return returnData;
        }

        internal static MasterDataReturnData findDeletedParcelSince(MasterDataData masterDataData)
        {
            FindDeletedParcelSinceRequest request = (FindDeletedParcelSinceRequest)initDefaultParameters(
                  new FindDeletedParcelSinceRequest(), masterDataData);

            request.Since = masterDataData.date;

            //execute service call
            FindDeletedParcelSinceResponse response = pudoClient.FindDeletedParcelSince(request);

            //create return object with base properties
            MasterDataReturnData returnData = (MasterDataReturnData)createSummaryMessage(new MasterDataReturnData(), response);

            returnData.summaryMessage += "\nResult list:\n";
            foreach (string barcode in response.BarcodeList)
            {
                returnData.summaryMessage += barcode + '\n';
            }

            return returnData;
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
            if (composites != null) { 
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
            }
            return returnData;
        }

        internal static PartnersReturnData findPartnerById(PartnerData partnerData)
        {
            // init request with default parameters
            FindPartnerByIDRequest request = (FindPartnerByIDRequest)initDefaultParameters(
                new FindPartnerByIDRequest(), partnerData);

            // add unique parameters
            request.PartnerID = partnerData.partnerId;

            //execute service call
            FindPartnerByIDResponse response = pudoClient.FindPartnerByID(request);

            //create return object with base properties
            PartnersReturnData returnData = (PartnersReturnData)createSummaryMessage(new PartnersReturnData(), response);

           
            PartnerReturnData newItem = new PartnerReturnData();
            newItem.PartnerID = response.Partner.PartnerID;
            newItem.PartnerName = response.Partner.PartnerName;
            
            returnData.partners.Add(newItem);
            
            //initialize custom values
            return returnData;
        }

        internal static PartnersReturnData findPartnerByFilter(PartnerData partnerData)
        {
            // init request with default parameters
            FindPartnerByFilterRequest request = (FindPartnerByFilterRequest)initDefaultParameters(
                new FindPartnerByFilterRequest(), partnerData);

            // add unique parameters
            request.PartnerNameFilter = partnerData.partnerNamePart;

            //execute service call
            FindPartnerByFilterResponse response = pudoClient.FindPartnerByFilter(request);

            //create return object with base properties
            PartnersReturnData returnData = (PartnersReturnData)createSummaryMessage(new PartnersReturnData(), response);

            //initialize custom values
            foreach (Partner partner in response.Partners)
            {
                PartnerReturnData newItem = new PartnerReturnData();
                newItem.PartnerID = partner.PartnerID;
                newItem.PartnerName = partner.PartnerName;

                returnData.partners.Add(newItem);
            }
                      
            return returnData;
        }

        internal static PartnersReturnData countPartnerByFilter(PartnerData partnerData)
        {
            // init request with default parameters
            CountPartnerByFilterRequest request = (CountPartnerByFilterRequest)initDefaultParameters(
                new CountPartnerByFilterRequest(), partnerData);

            // add unique parameters
            request.PartnerNameFilter = partnerData.partnerNamePart;

            //execute service call
            CountPartnerByFilterResponse response = pudoClient.CountPartnerByFilter(request);

            //create return object with base properties
            PartnersReturnData returnData = (PartnersReturnData)createSummaryMessage(new PartnersReturnData(), response);

            //initialize custom values
            returnData.summaryMessage += "\nResult count: " + response.PartnerCount;          

            return returnData;
        }

        internal static ReceiveReturnData findParcelForReceive(ReceiveData receiveData)
        {
            FindParcelForReceiveRequest request = (FindParcelForReceiveRequest)initDefaultParameters(
               new FindParcelForReceiveRequest(), receiveData);
            // add unique parameters
            request.Barcode = receiveData.barcode;

            //execute service call
            FindParcelForReceiveResponse response = pudoClient.FindParcelForReceive(request);

            //create return object with base properties
            ReceiveReturnData returnData = (ReceiveReturnData)createSummaryMessage(new ReceiveReturnData(), response);

            //initialize custom values
            return initReceiveReturnParcelComposites(returnData, response.ParcelComposites);
        }

        private static ReceiveReturnData initReceiveReturnParcelComposites(ReceiveReturnData returnData, ParcelComposite[] composites)
        {
            foreach (ParcelComposite composite in composites)
            {
                ParcelCompositeSelectableReturnData data = new ParcelCompositeSelectableReturnData();
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

                returnData.datas.Add(data);

            }
            return returnData;
        }

        internal static ReceiveReturnData postReceive(ReceiveData receiveData)
        {
            PostReceiveRequest request = (PostReceiveRequest)initDefaultParameters(
               new PostReceiveRequest(), receiveData);
            
            // add unique parameters
            List<ReceptionContainer> receptionContainers = new List<ReceptionContainer>();
            List<DiscrepancyContainer> discrepancyContainer = new List<DiscrepancyContainer>();
            foreach (ParcelCompositeSelectableReturnData data in receiveData.gridData)
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

            //create return object with base properties
            ReceiveReturnData returnData = (ReceiveReturnData)createSummaryMessage(new ReceiveReturnData(), response);

            returnData.summaryMessage += parcelResultsToString(response.ParcelResults);
           
            return returnData;
        }

        private static string parcelResultsToString(ParcelResult[] results)
        {
            string resultString = "\nParcel Results:\n";
            foreach (ParcelResult result in results)
            {
                resultString += result.Barcode + " - " + result.ActualStatus;
            }

            return resultString;

        }

        internal static ReturnReturnData findParcelForReturn(ReturnData returnedData)
        {
            FindParcelForReturnRequest request = (FindParcelForReturnRequest)initDefaultParameters(
                new FindParcelForReturnRequest(), returnedData);

            //execute service call
            FindParcelForReturnResponse response = pudoClient.FindParcelForReturn(request);

            //create return object with base properties
            ReturnReturnData returnData = (ReturnReturnData)createSummaryMessage(new ReturnReturnData(), response);

            foreach (ParcelMinimal parcel in response.ParcelMinimals)
            {
                ReturnParcelReturnData newItem = new ReturnParcelReturnData();
                newItem.Barcode = parcel.Barcode;
                newItem.Damaged = parcel.Damaged;
                newItem.LinkedCount = parcel.LinkedCount;
                newItem.NextLinkedBarcode = parcel.NextLinkedBarcode;
                newItem.ParcelState = parcel.ParcelState;
                newItem.PriceAtDelivery = parcel.PriceAtDelivery;
                newItem.ReturnDate = parcel.ReturnDate;
                newItem.Selected = false;

                returnData.data.Add(newItem);
            }
            
            return returnData;
        }

        internal static ReturnReturnData postReturn(ReturnData returnedData)
        {
            PostReturnRequest request = (PostReturnRequest) initDefaultParameters(
              new PostReturnRequest(), returnedData);

            List<ReturnContainer> container = new List<ReturnContainer>();

            foreach (ReturnParcelReturnData parcel in returnedData.data)
            {
                if (parcel.Selected) { 
                    ReturnContainer returnContainer = new ReturnContainer();
                    returnContainer.BagBarcode = returnedData.bagBarcode;
                    returnContainer.Barcode = returnedData.barcode;
                    container.Add(returnContainer);
                }
            }
            request.ReturnParcels = container.ToArray();
           
            //execute service call
            PostReturnResponse response = pudoClient.PostReturn(request);

            //create return object with base properties
            ReturnReturnData returnData = (ReturnReturnData)createSummaryMessage(new ReceiveReturnData(), response);

            return returnData;
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
